/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 20/11/2024
 * Heure: 07:10
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */

using System;
using System.Data;
using BettingApp.model;
using BettingApp.data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;

namespace BettingApp.data.repository
{
	/// <summary>
	/// Description of BetsRepository.
	/// </summary>
	public class BetsRepository
	{
		
		
		private DatabaseManager dbManager;

		public BetsRepository()
		{
			dbManager = new DatabaseManager();
		}

		public bool CreateBet(Bet bet)
		{
			try {
				using (var connection = dbManager.GetConnection()) {
					string query = @"INSERT INTO Bets
                        (BetId, UserId, BetDate, TotalAmount, Status)
                        VALUES (@BetId, @UserId, @BetDate, @TotalAmount, @Status)";

					using (var command = new MySqlCommand(query, connection)) {
						command.Parameters.AddWithValue("@BetId", bet.BetId);
						command.Parameters.AddWithValue("@UserId", bet.UserId);
						command.Parameters.AddWithValue("@BetDate", bet.BetDate);
						command.Parameters.AddWithValue("@TotalAmount", bet.TotalAmount);
						command.Parameters.AddWithValue("@Status", bet.Status);

						return command.ExecuteNonQuery() > 0;
					}
				}
			} catch (Exception ex) {
				MessageBox.Show("Erreur lors de la création du pari: " + ex.Message);
				return false;
			}
		}

		public Bet GetBetById(string betId)
		{
			try {
				using (var connection = dbManager.GetConnection()) {
					string query = "SELECT * FROM Bets WHERE BetId = @BetId";
					using (var command = new MySqlCommand(query, connection)) {
						command.Parameters.AddWithValue("@BetId", betId);

						using (var reader = command.ExecuteReader()) {
							if (reader.Read()) {
								return new Bet {
									BetId = reader.GetString("BetId"),
									UserId = reader.GetString("UserId"),
									BetDate = reader.GetDateTime("BetDate"),
									TotalAmount = reader.GetDecimal("TotalAmount"),
									Status = reader.GetString("Status")
								};
							}
						}
					}
				}
			} catch (Exception ex) {
				MessageBox.Show("Erreur lors de la récupération du pari: " + ex.Message);
			}
			return null;
		}
		
		public void LoadAllBetSummary(DataGridView betSummaryDataGridView)
		{
			var connection = dbManager.GetConnection();
			string query = @"
        SELECT
            b.BetId AS BetId,
            b.TotalAmount AS TotalAmount,
            b.Status AS Status,
            b.WinStatus AS WinStatus,
            COUNT(bd.BetDetailId) AS TotalMatches,
            SUM(CASE WHEN m.Status = 'T' THEN 1 ELSE 0 END) AS CompletedMatches,
            SUM(CASE WHEN bd.WinStatus = 'WON' THEN 1 ELSE 0 END) AS WonMatches
        FROM
            Bets b
        JOIN
            BetDetails bd ON b.BetId = bd.BetId
        JOIN
            Matches m ON bd.MatchId = m.MatchId
    
        GROUP BY
            b.BetId, b.TotalAmount, b.Status";

			using (MySqlCommand command = new MySqlCommand(query, connection)) {
				
				using (MySqlDataAdapter adapter = new MySqlDataAdapter(command)) {
					DataTable dt = new DataTable();
					adapter.Fill(dt);
					betSummaryDataGridView.DataSource = dt;
				}
			}
			connection.Close();
		}
		
		public void LoadPendingBetSummary(DataGridView betSummaryDataGridView)
		{
			var connection = dbManager.GetConnection();
			string query = @"
        SELECT
            b.BetId AS BetId,
            b.TotalAmount AS TotalAmount,
            b.Status AS Status,
            COUNT(bd.BetDetailId) AS TotalMatches,
            SUM(CASE WHEN m.Status = 'T' THEN 1 ELSE 0 END) AS CompletedMatches,
            SUM(CASE WHEN bd.WinStatus = 'WON' THEN 1 ELSE 0 END) AS WonMatches
        FROM
            Bets b
        JOIN
            BetDetails bd ON b.BetId = bd.BetId
        JOIN
            Matches m ON bd.MatchId = m.MatchId
        WHERE
            b.Status = 'PENDING'
        GROUP BY
            b.BetId, b.TotalAmount, b.Status";

			using (MySqlCommand command = new MySqlCommand(query, connection)) {
				
				using (MySqlDataAdapter adapter = new MySqlDataAdapter(command)) {
					DataTable dt = new DataTable();
					adapter.Fill(dt);
					betSummaryDataGridView.DataSource = dt;
				}
			}
			connection.Close();
		}

		public void LoadBetSummary(DataGridView betSummaryDataGridView, string status, string userId = null)
		{
			var connection = dbManager.GetConnection();
			var statusList = status.Split(',').Select(s => s.Trim()).ToList();

			
			string query = @"
        SELECT
            b.BetId AS BetId,
            b.TotalAmount AS TotalAmount,
            b.Status AS Status,
            b.WinStatus AS WinStatus,
            COUNT(bd.BetDetailId) AS TotalMatches,
            SUM(CASE WHEN m.Status = 'T' THEN 1 ELSE 0 END) AS CompletedMatches,
            SUM(CASE WHEN bd.WinStatus = 'WON' THEN 1 ELSE 0 END) AS WonMatches
        FROM
            Bets b
        JOIN
            BetDetails bd ON b.BetId = bd.BetId
        JOIN
            Matches m ON bd.MatchId = m.MatchId
        WHERE
            b.Status IN (" + string.Join(", ", statusList.Select((s, i) => "@Status" + i)) + ")";

			if (!string.IsNullOrEmpty(userId)) {
				query += " AND b.UserId = @UserId";
			}

			query += @"
        GROUP BY
            b.BetId, b.TotalAmount, b.Status";

			using (MySqlCommand command = new MySqlCommand(query, connection)) {
				for (int i = 0; i < statusList.Count; i++) {
					command.Parameters.AddWithValue("@Status" + i, statusList[i]);
				}

				if (!string.IsNullOrEmpty(userId)) {
					command.Parameters.AddWithValue("@UserId", userId);
				}

				using (MySqlDataAdapter adapter = new MySqlDataAdapter(command)) {
					DataTable dt = new DataTable();
					adapter.Fill(dt);

					ConfigureDataGridView(betSummaryDataGridView, dt, status);
				}
			}

			connection.Close();
		}
		

		private void ConfigureDataGridView(DataGridView gridView, DataTable dataTable, string status)
		{
			
			
			gridView.DataSource = null;
			gridView.Columns.Clear();
			gridView.DataSource = dataTable;

			if (status != "PENDING") {
				DataGridViewButtonColumn printButtonColumn = new DataGridViewButtonColumn {
					Name = "PrintButton",
					HeaderText = "",
					Text = "🖨️ Imprimer",
					UseColumnTextForButtonValue = true
						
				};
				
				gridView.Columns.Add(printButtonColumn);

				
				gridView.CellFormatting += (sender, e) => {
					if (e.ColumnIndex == gridView.Columns["PrintButton"].Index) {
						DataGridViewRow row = gridView.Rows[e.RowIndex];
						string winStatus = row.Cells["WinStatus"].Value.ToString();

						if (winStatus != "WON") {
							DataGridViewButtonCell buttonCell =
								(DataGridViewButtonCell)gridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
							buttonCell.Style.BackColor = Color.LightGray;
							buttonCell.Style.ForeColor = Color.LightGray;
							buttonCell.FlatStyle = FlatStyle.Flat;
						}
					}
				};

				
				gridView.CellClick += (sender, e) => {
					if (e.ColumnIndex == gridView.Columns["PrintButton"].Index && e.RowIndex >= 0) {
						DataGridViewRow row = gridView.Rows[e.RowIndex];
						string winStatus = row.Cells["WinStatus"].Value.ToString();

						if (winStatus == "WON") {
							string betId = row.Cells["BetId"].Value.ToString();
							var printer = new BetDetailsPrinter(betId);
							printer.Print();
						}
					}
				};
			}
		}


		
		
		public void LoadBetMatchSummary(DataGridView betMatchDetailsDataGridView, string betId)
		{
			var connection = dbManager.GetConnection();
			string query = @"
        SELECT
            CONCAT(ht.TeamName, ' vs ', at.TeamName) AS Pari,
            m.Country AS Pays,
            m.MatchDate AS DateMatch,
            m.MatchTime AS HeureMatch,
            m.HomeWinOdds AS CoteVictoireDomicile,
            m.DrawOdds AS CoteMatchNul,
            m.AwayWinOdds AS CoteVictoireExterieur,
            bd.OddValue AS CotePari,
            b.TotalAmount As quantiteArgentPari,
            (b.TotalAmount * bd.OddValue) AS GainPotentiel,
            b.Status AS Statut,
            b.WinStatus AS WinStatus,
            bd.WinStatus AS StatutResultatPari,
            CASE
                WHEN bd.PredictedTeamWinner = m.HomeTeamId THEN ht.TeamName
                WHEN bd.PredictedTeamWinner = m.AwayTeamId THEN at.TeamName
                ELSE 'Match Nul'
            END AS EquipeChoisie,
            m.FinalScore AS ScoreFinal
        FROM
            Bets b
        JOIN
            BetDetails bd ON b.BetId = bd.BetId
        JOIN
            Matches m ON bd.MatchId = m.MatchId
        JOIN
            Teams ht ON m.HomeTeamId = ht.TeamId
        JOIN
            Teams at ON m.AwayTeamId = at.TeamId
        WHERE
            b.BetId = @BetId";

			using (MySqlCommand command = new MySqlCommand(query, connection)) {
				command.Parameters.AddWithValue("@BetId", betId);
				using (MySqlDataAdapter adapter = new MySqlDataAdapter(command)) {
					DataTable dt = new DataTable();
					adapter.Fill(dt);
					betMatchDetailsDataGridView.DataSource = dt;
				}
			}
			connection.Close();
		}

		
		public void LoadPaymentsDataGridView(DataGridView paymentDataGridView, string userId = null)
		{
			var connection = dbManager.GetConnection();

			string query = @"
        SELECT
            p.PaymentId,
            p.BetId,
            b.TotalAmount,
            p.PaymentDate,
            p.Amount,
            p.PaymentStatus
        FROM
            Payments p
        JOIN
            Bets b ON p.BetId = b.BetId";

			if (!string.IsNullOrEmpty(userId)) {
				query += " WHERE b.UserId = @UserId";
			}

			query += " ORDER BY p.PaymentDate DESC";

			using (MySqlCommand command = new MySqlCommand(query, connection)) {
				if (!string.IsNullOrEmpty(userId)) {
					command.Parameters.AddWithValue("@UserId", userId);
				}

				using (MySqlDataAdapter adapter = new MySqlDataAdapter(command)) {
					DataTable dt = new DataTable();
					adapter.Fill(dt);

					paymentDataGridView.DataSource = dt;
				}
			}

			connection.Close();
		}
		
	}
}
