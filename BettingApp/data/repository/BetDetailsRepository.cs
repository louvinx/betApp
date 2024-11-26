/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 20/11/2024
 * Heure: 07:21
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Collections.Generic;
using BettingApp.model;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BettingApp.data.repository
{
	/// <summary>
	/// Description of BetDetailsRepository.
	/// </summary>
	public class BetDetailsRepository
	{
		private DatabaseManager dbManager;

		public BetDetailsRepository()
		{
			dbManager = new DatabaseManager();
		}

		public bool CreateBetDetail(BetDetail betDetail)
		{
			try {
				using (var connection = dbManager.GetConnection()) {
					string query = @"INSERT INTO BetDetails
                        (BetId, MatchId, PredictedTeamWinner, OddValue, WinStatus)
                        VALUES (@BetId, @MatchId, @PredictedTeamWinner, @OddValue, @WinStatus)";

					using (var command = new MySqlCommand(query, connection)) {
						command.Parameters.AddWithValue("@BetId", betDetail.BetId);
						command.Parameters.AddWithValue("@MatchId", betDetail.MatchId);
						command.Parameters.AddWithValue("@PredictedTeamWinner", betDetail.PredictedTeamWinner ?? (object)DBNull.Value);
						command.Parameters.AddWithValue("@OddValue", betDetail.OddValue);
						command.Parameters.AddWithValue("@WinStatus", betDetail.WinStatus);

						return command.ExecuteNonQuery() > 0;
					}
				}
			} catch (Exception ex) {
				MessageBox.Show("Erreur lors de la création du détail de pari: " + ex.Message);
				return false;
			}
		}

		public List<BetDetail> GetBetDetailsByBetId(string betId)
		{
			var betDetails = new List<BetDetail>();
			try {
				using (var connection = dbManager.GetConnection()) {
					string query = "SELECT * FROM BetDetails WHERE BetId = @BetId";
					using (var command = new MySqlCommand(query, connection)) {
						command.Parameters.AddWithValue("@BetId", betId);

						using (var reader = command.ExecuteReader()) {
							while (reader.Read()) {
								betDetails.Add(new BetDetail {
									BetDetailId = reader.GetInt32("BetDetailId"),
									BetId = reader.GetString("BetId"),
									MatchId = reader.GetString("MatchId"),
									PredictedTeamWinner = reader.IsDBNull(reader.GetOrdinal("PredictedTeamWinner"))
								               		? (int?)null
								               		: reader.GetInt32("PredictedTeamWinner"),
									OddValue = reader.GetDecimal("OddValue"),
									WinStatus = reader.GetString("WinStatus")
								});
							}
						}
					}
				}
			} catch (Exception ex) {
				MessageBox.Show("Erreur lors de la récupération des détails de pari: " + ex.Message);
			}
			return betDetails;
		}
		
		public bool DeleteBetSummary(string userId, string matchId)
		{
			try {
				using (var connection = dbManager.GetConnection()) {
					string queryDelete = @"DELETE FROM BetDetails
                             WHERE MatchId = @MatchId
                             AND BetId IN (SELECT BetId FROM Bets WHERE UserId = @UserId)";

					using (var command = new MySqlCommand(queryDelete, connection)) {
						command.Parameters.AddWithValue("@MatchId", matchId);
						command.Parameters.AddWithValue("@UserId", userId);

						return command.ExecuteNonQuery() > 0;
					}
				}
			} catch (Exception ex) {
				MessageBox.Show("Erreur lors de la suppression du détail de pari: " + ex.Message);
				return false;
			}
		}

	}
}
