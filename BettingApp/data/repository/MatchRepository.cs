/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 04/11/2024
 * Heure: 11:33
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Data;
using BettingApp.model;
using MySql.Data.MySqlClient;
using BettingApp.data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;




namespace BettingApp.data.repository
{
	/// <summary>
	/// Description of MatchRepository.
	/// </summary>
	/// 
	public class MatchRepository
	{
		private DatabaseManager dbManager;
		TeamRepository teamRepository = new TeamRepository();
		BetsRepository betsRepository = new BetsRepository();
		UtilsRepository utilsRepository = new UtilsRepository();
		public MatchRepository()
		{
			dbManager = new DatabaseManager();
		}
		
		
		public bool SaveMatch(Match match)
		{
			try {
				if (!utilsRepository.CheckUnique("Matches", "MatchId", match.MatchId)) {
					MessageBox.Show("Un match avec cet ID existe déjà.",
						"Erreur",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error);
					return false;
				}

				using (var connection = dbManager.GetConnection()) {

					string query = @"INSERT INTO Matches
                             (MatchId, MatchType, Country, HomeTeamId, AwayTeamId, HomeWinOdds, DrawOdds, AwayWinOdds, MatchDate, MatchTime)
                             VALUES
                             (@MatchId, @MatchType, @Country, @HomeTeamId, @AwayTeamId, @HomeWinOdds, @DrawOdds, @AwayWinOdds, @MatchDate, @MatchTime)";

					using (var command = new MySqlCommand(query, connection)) {
						command.Parameters.AddWithValue("@MatchId", match.MatchId);
						command.Parameters.AddWithValue("@MatchType", match.MatchType);
						command.Parameters.AddWithValue("@Country", match.Country);
						command.Parameters.AddWithValue("@HomeTeamId", match.HomeTeam);
						command.Parameters.AddWithValue("@AwayTeamId", match.AwayTeam);
						command.Parameters.AddWithValue("@HomeWinOdds", match.HomeWinOdds);
						command.Parameters.AddWithValue("@DrawOdds", match.DrawOdds);
						command.Parameters.AddWithValue("@AwayWinOdds", match.AwayWinOdds);
						command.Parameters.AddWithValue("@MatchDate", match.MatchDate);
						command.Parameters.AddWithValue("@MatchTime", match.MatchTime);

						int rowsAffected = command.ExecuteNonQuery();
						return rowsAffected > 0;
					}
				}
			} catch (Exception ex) {
				MessageBox.Show("Erreur lors de l'insertion du match : " + ex.Message,
					"Erreur",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return false;
			}
		}
		
		
		public void LoadMatch(DataGridView matchDataGridView)
		{
			var connection = dbManager.GetConnection();
			string query = @"
        SELECT
            m.MatchId,
            m.MatchType,
            m.Country,
            m.MatchDate,
            m.MatchTime,
            m.HomeTeamId,
            home.TeamName AS HomeTeamName,
            m.AwayTeamId,
            away.TeamName AS AwayTeamName,
            m.HomeWinOdds,
            m.DrawOdds,
            m.AwayWinOdds,
            m.FinalScore,
            m.Status
        FROM
            Matches m
        INNER JOIN Teams home ON m.HomeTeamId = home.TeamId
        INNER JOIN Teams away ON m.AwayTeamId = away.TeamId";

			using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection)) {
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				matchDataGridView.DataSource = dt;
			}
			connection.Close();
		}

		
		
		public Match GetMatch(string MatchId)
		{
			string query = "SELECT * FROM matches WHERE MatchId = @MatchId";
			MySqlParameter[] parameters = {
				new MySqlParameter("@MatchId", MatchId)
			};

			using (MySqlCommand command = new MySqlCommand(query, dbManager.GetConnection())) {
				command.Parameters.AddRange(parameters);

				using (MySqlDataReader reader = command.ExecuteReader()) {
					if (reader.Read()) {
						Match match = new Match();
						
						match.MatchId = reader.GetString("MatchId");
						match.MatchType = reader.GetString("MatchType");
						match.Country = reader.GetString("MatchType");
						match.MatchDate = reader.GetDateTime("MatchDate");
						match.MatchTime = reader.GetString("MatchTime");
						match.HomeTeam = reader.GetInt32("HomeTeamId");
						match.AwayTeam = reader.GetInt32("AwayTeamId");
						match.HomeWinOdds = reader.GetDecimal("HomeWinOdds");
						match.DrawOdds = reader.GetDecimal("DrawOdds");
						match.AwayWinOdds = reader.GetDecimal("AwayWinOdds");
						match.FinalScore = reader.GetString("FinalScore");
						match.Status = reader.GetString("Status");
						match.CreatedAt = reader.GetDateTime("CreatedAt");
						match.UpdatedAt = reader.GetDateTime("UpdatedAt");
						
						return match;
					}
					return null;
				}
			}
		}
		
		
		
		public bool UpdateMatchStatusAndProcessPayments(string matchId, string status, string finalScore = null)
		{
			try {
				ModifyStatusMatch(matchId, status, finalScore);
				if (status == "T" && finalScore != null) {
					var connection = dbManager.GetConnection();
					
					string betIdQuery = @"SELECT BetId FROM BetDetails  WHERE MatchId = @MatchId";
					
					using (var command = new MySqlCommand(betIdQuery, connection)) {
						command.Parameters.AddWithValue("@MatchId", matchId);
						using (var reader = command.ExecuteReader()) {
							while (reader.Read()) {
								string idBet = reader.GetString("BetId");
								UpdateBetWinStatus(idBet);
							}
						}
					}
					
					int winningTeamId = ProcessMatchResult(matchId, finalScore);
					UpdateBetStatuses(matchId, winningTeamId);
					
				}

				return true;
			} catch (Exception ex) {
				MessageBox.Show("Erreur lors du traitement : " + ex.Message);
				return false;
			}
		}

		private void ModifyStatusMatch(string matchId, string status, string finalScore)
		{
			var connection = dbManager.GetConnection();
			string updateMatchQuery = @"UPDATE Matches
                                    SET Status = @Status" +
			                          (finalScore != null ? ", FinalScore = @FinalScore" : "") +
			                          " WHERE MatchId = @MatchId";

			using (var command = new MySqlCommand(updateMatchQuery, connection)) {
				command.Parameters.AddWithValue("@Status", status);
				command.Parameters.AddWithValue("@MatchId", matchId);
				if (finalScore != null) {
					command.Parameters.AddWithValue("@FinalScore", finalScore);
				}
				command.ExecuteNonQuery();
			}
			
		}
		
		private int ProcessMatchResult(string matchId, string finalScore)
		{
			var connection = dbManager.GetConnection();
			string[] scores = finalScore.Split(':');
			int homeScore = int.Parse(scores[0]);
			int awayScore = int.Parse(scores[1]);

			string matchQuery = @"SELECT HomeTeamId, AwayTeamId
                          FROM Matches
                          WHERE MatchId = @MatchId";

			using (var command = new MySqlCommand(matchQuery, connection)) {
				command.Parameters.AddWithValue("@MatchId", matchId);
				using (var reader = command.ExecuteReader()) {
					reader.Read();
					int homeTeamId = reader.GetInt32("HomeTeamId");
					int awayTeamId = reader.GetInt32("AwayTeamId");


					
					if (homeScore == awayScore) {
						return 0;
					}

					return (homeScore > awayScore) ? homeTeamId : awayTeamId;
				}
			}

		}

		private void UpdateBetStatuses(string matchId, int winningTeamId)
		{
			var connection = dbManager.GetConnection();
			string updateBetsQuery = @"UPDATE BetDetails
                               SET WinStatus = CASE
                                   WHEN @WinningTeamId = 0 AND PredictedTeamWinner = 0 THEN 'WON'
                                   WHEN @WinningTeamId = 0 AND PredictedTeamWinner != 0 THEN 'LOST'
                                   WHEN PredictedTeamWinner = @WinningTeamId THEN 'WON'
                                   ELSE 'LOST'
                               END
                               WHERE MatchId = @MatchId AND WinStatus = 'PENDING'";

			using (var command = new MySqlCommand(updateBetsQuery, connection)) {
				command.Parameters.AddWithValue("@WinningTeamId", winningTeamId);
				command.Parameters.AddWithValue("@MatchId", matchId);
				command.ExecuteNonQuery();
			}
			
		}


		public void UpdateBetWinStatus(string betId)
		{
			string winStatusResult = "WON";
			string matchId = string.Empty;

			using (var connection = dbManager.GetConnection()) {
				
				string betDetailStatusQuery = @"SELECT bd.WinStatus, m.MatchId, m.Status
                                        FROM BetDetails bd
                                        JOIN Matches m ON m.MatchId = bd.MatchId
                                        WHERE bd.BetId = @BetId";

				using (var command = new MySqlCommand(betDetailStatusQuery, connection)) {
					command.Parameters.AddWithValue("@BetId", betId);

					using (var reader = command.ExecuteReader()) {
						while (reader.Read()) {
							string winStatus = reader.GetString("WinStatus");
							string matchStatus = reader.GetString("Status");
							matchId = reader.GetString("MatchId");

							if (matchStatus != "T") {
								winStatusResult = "PENDING";
								break;
							}

							
							if (winStatus == "LOST") {
								winStatusResult = "LOST";
								break;
							}
						}
					}
				}

				string updateBetStatusQuery = @"UPDATE Bets
                                        SET WinStatus = @WinStatus
                                        WHERE BetId = @BetId";

				using (var command = new MySqlCommand(updateBetStatusQuery, connection)) {
					command.Parameters.AddWithValue("@WinStatus", winStatusResult);
					command.Parameters.AddWithValue("@BetId", betId);
					command.ExecuteNonQuery();
				}

				
				if (winStatusResult == "WON" || winStatusResult == "LOST") {
					string betPaymentQuery = @"SELECT bd.MatchId
                                        FROM BetDetails bd
                                        JOIN Bets b ON b.BetId = bd.BetId
                                        WHERE bd.BetId = @BetId";

					using (var command = new MySqlCommand(betPaymentQuery, connection)) {
						command.Parameters.AddWithValue("@BetId", betId);

						using (var reader = command.ExecuteReader()) {
							while (reader.Read()) {
								matchId = reader.GetString("MatchId");
								ProcessWinningBets(matchId);
								UpdateBetStatus(betId);
							}
						}
					}
				}
			}
		}


		private void ProcessWinningBets(string matchId)
		{
			var connection = dbManager.GetConnection();
			
			string winningBetsQuery = @"
		        SELECT bd.BetId, b.UserId, bd.OddValue, b.TotalAmount
		        FROM BetDetails bd
		        JOIN Bets b ON b.BetId = bd.BetId
		        WHERE bd.MatchId = @MatchId
		        AND b.WinStatus = 'WON'";

			using (var command = new MySqlCommand(winningBetsQuery, connection)) {
				command.Parameters.AddWithValue("@MatchId", matchId);

				using (var reader = command.ExecuteReader()) {


					while (reader.Read()) {
						string betId = reader.GetString("BetId");
						string betUserId = reader.GetString("UserId");
						decimal oddValue = reader.GetDecimal("OddValue");
						decimal betAmount = reader.GetDecimal("TotalAmount");
						decimal winningAmount = betAmount * oddValue;
						InsertPayment(betId, winningAmount);
						UpdateUserBalance(betUserId, winningAmount);
						
					}
					
				}
			}
		}



		private void InsertPayment(string betId, decimal amount)
		{
			var connection = dbManager.GetConnection();
			
			string insertPaymentQuery = @"INSERT INTO Payments
                                      (BetId, Amount, PaymentStatus)
                                      VALUES (@BetId, @Amount, 'COMPLETED')";

			using (var command = new MySqlCommand(insertPaymentQuery, connection)) {
				command.Parameters.AddWithValue("@BetId", betId);
				command.Parameters.AddWithValue("@Amount", amount);
				command.ExecuteNonQuery();
				
			}
		}

		private void UpdateUserBalance(string userId, decimal winningAmount)
		{
			var connection = dbManager.GetConnection();
			
			string updateUserBalanceQuery = @"UPDATE Users
                                          SET Balance = Balance + @WinningAmount
                                          WHERE Code = @UserId";

			using (var command = new MySqlCommand(updateUserBalanceQuery, connection)) {
				command.Parameters.AddWithValue("@WinningAmount", winningAmount);
				command.Parameters.AddWithValue("@UserId", userId);
				command.ExecuteNonQuery();
			}
			
		}

		
		private void UpdateBetStatus(string betId)
		{
			var connection = dbManager.GetConnection();
			
			string updateBetStatusQuery = @"UPDATE Bets
                                        SET Status = 'COMPLETED'
                                        WHERE BetId = @BetId";

			using (var command = new MySqlCommand(updateBetStatusQuery, connection)) {
				command.Parameters.AddWithValue("@BetId", betId);
				command.ExecuteNonQuery();
			}
			
		}

		public void LoadMatchDetailsInDataGridView(DataGridView dataGridView)
		{
			string query = @"
			    SELECT
			        MatchId,
			        MatchType,
			        Country,
			        MatchDate,
			        MatchTime,
			        HomeTeamId,
			        AwayTeamId,
			        HomeWinOdds,
			        DrawOdds,
			        AwayWinOdds,
			        Status
			    FROM matches WHERE Status In ('E','N')";

			try {
				using (var connection = dbManager.GetConnection()) {
					using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection)) {
						DataTable dt = new DataTable();
						adapter.Fill(dt);

						// Préparer le DataGridView
						dataGridView.DataSource = null;
						dataGridView.Columns.Clear();

						// Définir les colonnes nécessaires dans le DataGridView
						dataGridView.Columns.Add("MatchId", "Match ID");
						dataGridView.Columns.Add("MatchType", "Type");
						dataGridView.Columns.Add("Country", "Pays");
						dataGridView.Columns.Add("MatchDate", "Date");
						dataGridView.Columns.Add("MatchTime", "Heure");

						// Colonnes pour les logos des équipes
						var homeLogoColumn = new DataGridViewImageColumn {
							HeaderText = "",
							Name = "HomeLogo",
							ImageLayout = DataGridViewImageCellLayout.Zoom,
						};

						var awayLogoColumn = new DataGridViewImageColumn {
							HeaderText = "",
							Name = "AwayLogo",
							ImageLayout = DataGridViewImageCellLayout.Zoom
						};

						// Ajouter les colonnes pour les logos
						dataGridView.Columns.Add(homeLogoColumn);
						dataGridView.Columns.Add("HomeTeamName", "Home");
						dataGridView.Columns.Add(awayLogoColumn);
						dataGridView.Columns.Add("AwayTeamName", "Away");



						dataGridView.Columns.Add("Status", "Status");

						foreach (DataRow row in dt.Rows) {
							var homeTeam = teamRepository.GetTeamByID((int)row["HomeTeamId"]);
							var awayTeam = teamRepository.GetTeamByID((int)row["AwayTeamId"]);

							Image homeTeamLogo = LoadTeamLogo(homeTeam.LogoPath);
							Image awayTeamLogo = LoadTeamLogo(awayTeam.LogoPath);

							int rowIndex = dataGridView.Rows.Add(
								               row["MatchId"].ToString(),
								               row["MatchType"].ToString(),
								               row["Country"].ToString(),
								               Convert.ToDateTime(row["MatchDate"]).ToString("yyyy-MM-dd"),
								               row["MatchTime"].ToString(),
								               null,
								               homeTeam.TeamName,
								               null,
								               awayTeam.TeamName,
								
								               row["Status"].ToString()
							               );

							dataGridView.Rows[rowIndex].Cells["HomeLogo"].Value = homeTeamLogo;
							dataGridView.Rows[rowIndex].Cells["AwayLogo"].Value = awayTeamLogo;

							
						}
					}
				}
			} catch (Exception ex) {
				Console.WriteLine("Erreur lors du chargement des matches : " + ex.Message);
			}
		}


		public void LoadMatchesInDataGridView(DataGridView dataGridView)
		{
			string query = @"
			    SELECT
			        MatchId,
			        MatchType,
			        Country,
			        MatchDate,
			        MatchTime,
			        HomeTeamId,
			        AwayTeamId,
			        HomeWinOdds,
			        DrawOdds,
			        AwayWinOdds,
			        Status
			    FROM matches WHERE Status IN ('N','E')";

			try {
				using (var connection = dbManager.GetConnection()) {
					using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection)) {
						DataTable dt = new DataTable();
						adapter.Fill(dt);

						
						dataGridView.DataSource = null;
						dataGridView.Columns.Clear();

						// Définir les colonnes nécessaires dans le DataGridView
						dataGridView.Columns.Add("MatchId", "Match ID");
						dataGridView.Columns.Add("MatchType", "Type");
						dataGridView.Columns.Add("Country", "Pays");
						dataGridView.Columns.Add("MatchDate", "Date");
						dataGridView.Columns.Add("MatchTime", "Heure");

						// Colonnes pour les logos des équipes
						var homeLogoColumn = new DataGridViewImageColumn {
							HeaderText = "",
							Name = "HomeLogo",
							ImageLayout = DataGridViewImageCellLayout.Zoom,
						};

						var awayLogoColumn = new DataGridViewImageColumn {
							HeaderText = "",
							Name = "AwayLogo",
							ImageLayout = DataGridViewImageCellLayout.Zoom
						};

						// Ajouter les colonnes pour les logos
						dataGridView.Columns.Add(homeLogoColumn);
						dataGridView.Columns.Add("HomeTeamName", "Home");
						dataGridView.Columns.Add(awayLogoColumn);
						dataGridView.Columns.Add("AwayTeamName", "Away");

						// Colonnes pour les boutons des cotes
						var homeOddsButtonColumn = new DataGridViewButtonColumn {
							HeaderText = "Home Odds",
							Name = "HomeOddsButton",
							Text = "",
							UseColumnTextForButtonValue = false
						};

						var drawOddsButtonColumn = new DataGridViewButtonColumn {
							HeaderText = "Draw Odds",
							Name = "DrawOddsButton",
							Text = "",
							UseColumnTextForButtonValue = false
						};

						var awayOddsButtonColumn = new DataGridViewButtonColumn {
							HeaderText = "Away Odds",
							Name = "AwayOddsButton",
							Text = "",
							UseColumnTextForButtonValue = false
						};

						dataGridView.Columns.Add(homeOddsButtonColumn);
						dataGridView.Columns.Add(drawOddsButtonColumn);
						dataGridView.Columns.Add(awayOddsButtonColumn);

						dataGridView.Columns.Add("Status", "Status");

						foreach (DataRow row in dt.Rows) {
							var homeTeam = teamRepository.GetTeamByID((int)row["HomeTeamId"]);
							var awayTeam = teamRepository.GetTeamByID((int)row["AwayTeamId"]);

							Image homeTeamLogo = LoadTeamLogo(homeTeam.LogoPath);
							Image awayTeamLogo = LoadTeamLogo(awayTeam.LogoPath);

							int rowIndex = dataGridView.Rows.Add(
								               row["MatchId"].ToString(),
								               row["MatchType"].ToString(),
								               row["Country"].ToString(),
								               Convert.ToDateTime(row["MatchDate"]).ToString("yyyy-MM-dd"),
								               row["MatchTime"].ToString(),
								               null,
								               homeTeam.TeamName,
								               null,
								               awayTeam.TeamName,
								               null,
								               null,
								               null,
								               row["Status"].ToString()
							               );

							dataGridView.Rows[rowIndex].Cells["HomeLogo"].Value = homeTeamLogo;
							dataGridView.Rows[rowIndex].Cells["AwayLogo"].Value = awayTeamLogo;

							
							dataGridView.Rows[rowIndex].Cells["HomeOddsButton"].Value = row["HomeWinOdds"].ToString();
							dataGridView.Rows[rowIndex].Cells["DrawOddsButton"].Value = row["DrawOdds"].ToString();
							dataGridView.Rows[rowIndex].Cells["AwayOddsButton"].Value = row["AwayWinOdds"].ToString();
						}
					}
				}
			} catch (Exception ex) {
				Console.WriteLine("Erreur lors du chargement des matches : " + ex.Message);
			}
		}


		private Image LoadTeamLogo(string logoPath)
		{
			return File.Exists(logoPath) ? Image.FromFile(logoPath) : null;
		}


		
	}
}
