/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 22/11/2024
 * Heure: 16:16
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BettingApp.data.repository
{
	/// <summary>
	/// Description of UtilsRepository.
	/// </summary>
	public class UtilsRepository
	{
		private DatabaseManager dbManager;
		public UtilsRepository()
		{
			dbManager = new DatabaseManager();
		}
		
		public bool CheckUnique(string tableName, string fieldName, string value)
		{
			try {
				var connection = dbManager.GetConnection();
				string query = "SELECT COUNT(*) FROM " + tableName + " WHERE " + fieldName + " = @Value";
				using (var command = new MySqlCommand(query, connection)) {
					command.Parameters.AddWithValue("@Value", value);
					int count = Convert.ToInt32(command.ExecuteScalar());
					dbManager.CloseConnection();
					return count == 0;
				}
				
				
			} catch (Exception ex) {
				
				MessageBox.Show("Erreur lors de la vérification de l'unicité : " + ex.Message,
				                "Erreur",
				                MessageBoxButtons.OK,
				                MessageBoxIcon.Error);
				return false;
			}
		}

		
		public bool CheckUniqueForUpdate(string tableName, string fieldName, string value, string idField, string idValue)
		{
			try {
				var connection = dbManager.GetConnection();
				
				string query = "SELECT COUNT(*) FROM " + tableName +
					" WHERE " + fieldName + " = @Value" +
					" AND " + idField + " != @IdValue";
				
				using (var command = new MySqlCommand(query, connection)) {
					command.Parameters.AddWithValue("@Value", value);
					command.Parameters.AddWithValue("@IdValue", idValue);
					int count = Convert.ToInt32(command.ExecuteScalar());
					dbManager.CloseConnection();
					return count == 0;
				}
			} catch (Exception ex) {
				MessageBox.Show("Erreur lors de la vérification de l'unicité : " + ex.Message,
				                "Erreur",
				                MessageBoxButtons.OK,
				                MessageBoxIcon.Error);
				return false;
			}
		}
		
		public bool CheckTeamAvailability(int teamId, DateTime matchDate)
		{
			try
			{
				var connection = dbManager.GetConnection();
				string query = @"SELECT COUNT(*) FROM Matches
                        WHERE (HomeTeamId = @TeamId OR AwayTeamId = @TeamId)
                        AND DATE(MatchDate) = @MatchDate";

				using (var command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@TeamId", teamId);
					command.Parameters.AddWithValue("@MatchDate", matchDate.Date);
					
					int count = Convert.ToInt32(command.ExecuteScalar());
					dbManager.CloseConnection();
					return count == 0;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(
					"Erreur lors de la vérification de la disponibilité de l'équipe : " + ex.Message,
					"Erreur",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return false;
			}
		}
	}
}
