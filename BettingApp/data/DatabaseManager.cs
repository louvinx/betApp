/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 04/11/2024
 * Heure: 10:49
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using BettingApp.utils;

namespace BettingApp.data
{
	/// <summary>
	/// Description of DatabaseContext.
	/// </summary>
	
	public class DatabaseManager
	{

		private MySqlConnection _connection = null;
		private static string connectionString = "Server=localhost;Database=bettingPhoenix_db;Uid=root;Pwd='';";


		// Constructeur privé pour empêcher l'instanciation directe
		public DatabaseManager()
		{
			InsertAdminIfNotExists(
				code: "ADMIN01",
				lastName: "Louvinx",
				firstName: "PIERRE",
				gender: "Masculin",
				birthDate: new DateTime(1990, 1, 1),
				phone: "00000000",
				nifCin: "0000000000",
				username: "admin",
				password: "admin123"
			);
		}
		


		public MySqlConnection GetConnection()
		{
			try {
				_connection = new MySqlConnection(connectionString);
				_connection.Open();
				return _connection;
			} catch (Exception ex) {
				MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}

		

		public object ExecuteScalar(string query, MySqlParameter[] parameters = null)
		{
			MySqlCommand command = new MySqlCommand(query, _connection);

			if (parameters != null) {
				command.Parameters.AddRange(parameters);
			}

			return command.ExecuteScalar();
		}

		
		
		public void CloseConnection()
		{
			if (_connection.State == System.Data.ConnectionState.Open) {
				_connection.Close();
			}
		}
		
		public void InsertAdminIfNotExists(string code, string lastName, string firstName, string gender, DateTime birthDate, string phone, string nifCin, string username, string password)
		{
			string hashedPassword = PasswordHelper.HashPassword(password);
			string checkQuery = "SELECT COUNT(*) FROM Users WHERE Code = 'ADMIN01'";
			string insertQuery = @"INSERT INTO Users (Code, LastName, FirstName, Gender, BirthDate, Phone, NifCin, Username, Password, Role, Status)
                                   VALUES (@Code, @LastName, @FirstName, @Gender, @BirthDate, @Phone, @NifCin, @Username, @Password, 'ADMIN', 'A')";

			using (var connection = GetConnection()) {
				using (var checkCommand = new MySqlCommand(checkQuery, connection)) {
					int adminCount = Convert.ToInt32(checkCommand.ExecuteScalar());
					if (adminCount == 0) {
						using (var insertCommand = new MySqlCommand(insertQuery, connection)) {
							insertCommand.Parameters.AddWithValue("@Code", code);
							insertCommand.Parameters.AddWithValue("@LastName", lastName);
							insertCommand.Parameters.AddWithValue("@FirstName", firstName);
							insertCommand.Parameters.AddWithValue("@Gender", gender);
							insertCommand.Parameters.AddWithValue("@BirthDate", birthDate);
							insertCommand.Parameters.AddWithValue("@Phone", phone);
							insertCommand.Parameters.AddWithValue("@NifCin", nifCin);
							insertCommand.Parameters.AddWithValue("@Username", username);
							insertCommand.Parameters.AddWithValue("@Password", hashedPassword);

							insertCommand.ExecuteNonQuery();
						}
					}
				}
			}
		}

	}
}