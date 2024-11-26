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
using System.Windows.Forms; 
using BettingApp.utils;



namespace BettingApp.data.repository
{
	/// <summary>
	/// Description of UserRepository.
	/// </summary>
	public class UserRepository
	{
		private DatabaseManager dbManager;
		UtilsRepository utilsRepository = new UtilsRepository();
		public UserRepository()
		{
			dbManager = new DatabaseManager();
		}
		

		
		
		public bool ModifyPassworUser(User user, String password)
		{
			var connection = dbManager.GetConnection();
			string hashedPassword = PasswordHelper.HashPassword(password);
			string query = "Update Users SET Password = @Password WHERE Code = @Code";
			using (var command = new MySqlCommand(query, connection)) {
				command.Parameters.AddWithValue("@Code", user.Code);
				command.Parameters.AddWithValue("@Password", hashedPassword);
				int rowsAffected = command.ExecuteNonQuery();
				connection.Close();
				return rowsAffected > 0;
			}
		}

		public bool ModifyStatusUser(User user, String status)
		{
			var connection = dbManager.GetConnection();
			string query = "Update Users SET Status = @Status WHERE Code = @Code";
			using (var command = new MySqlCommand(query, connection)) {
				command.Parameters.AddWithValue("@Code", user.Code);
				command.Parameters.AddWithValue("@Status", status);
				int rowsAffected = command.ExecuteNonQuery();
				connection.Close();
				return rowsAffected > 0;
			}
		}
		
		
		public bool ModifyBalanceUser(User user, decimal balance)
		{
			var connection = dbManager.GetConnection();
			string query = "Update Users SET Balance = @Balance WHERE Code = @Code";
			using (var command = new MySqlCommand(query, connection)) {
				command.Parameters.AddWithValue("@Code", user.Code);
				command.Parameters.AddWithValue("@Balance", balance);
				int rowsAffected = command.ExecuteNonQuery();
				connection.Close();
				return rowsAffected > 0;
			}
		}

		
		
		public bool UpdateUser(User user)
		{
			   
			if (!utilsRepository.CheckUniqueForUpdate("users", "Username", user.Username, "Code", user.Code)) {
				MessageBox.Show("Ce nom d'utilisateur est déjà utilisé!", "Erreur", 
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
   
			if (!utilsRepository.CheckUniqueForUpdate("users", "NifCin", user.NifCin, "Code", user.Code)) {
				MessageBox.Show("Ce NIF/Ninu est déjà utilisé!", "Erreur", 
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
    
  
			if (!utilsRepository.CheckUniqueForUpdate("users", "Phone", user.Phone, "Code", user.Code)) {
				MessageBox.Show("Ce numéro de téléphone est déjà utilisé!", "Erreur", 
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			
			var connection = dbManager.GetConnection();
			string query = @"
            UPDATE users
            SET Lastname = @lastName,
                Firstname = @firstName,
                Gender = @gender,
                Birthdate = @birthDate,
                Phone = @phone,
                NifCin = @nifCin,
                Username = @username,
                Role = @role 
            WHERE Code = @code";

			using (var command = new MySqlCommand(query, connection)) {
				
				command.Parameters.AddWithValue("@lastName", user.LastName);
				command.Parameters.AddWithValue("@firstName", user.FirstName);
				command.Parameters.AddWithValue("@gender", user.Gender);
				command.Parameters.AddWithValue("@birthDate", user.BirthDate);
				command.Parameters.AddWithValue("@phone", user.Phone);
				command.Parameters.AddWithValue("@nifCin", user.NifCin);
				command.Parameters.AddWithValue("@username", user.Username);
				command.Parameters.AddWithValue("@role", user.Role);
				command.Parameters.AddWithValue("@code", user.Code); 
			

				
				int rowsAffected = command.ExecuteNonQuery();
				return rowsAffected > 0;
			}
			
		}
		
		
		
	
		public User GetUser(string code)
		{
			string query = "SELECT * FROM Users WHERE Code = @Code";
			MySqlParameter[] parameters = {
				new MySqlParameter("@Code", code)
			};

			using (MySqlCommand command = new MySqlCommand(query, dbManager.GetConnection())) {
				command.Parameters.AddRange(parameters);

				using (MySqlDataReader reader = command.ExecuteReader()) {
					if (reader.Read()) {
						User user = new User();
						user.Code = reader.GetString(0);
						user.LastName = reader.GetString(1);
						user.FirstName = reader.GetString(2);
						user.Gender = reader.GetString(3);
						user.BirthDate = reader.GetDateTime(4);
						user.Phone = reader.GetString(5);
						user.NifCin = reader.GetString(6);
						user.Username = reader.GetString(7);
						user.Password = reader.GetString(8);
						user.Balance = reader.GetDecimal(9);
						user.Role = reader.GetString(10);
						user.Status = reader.GetString(11);
						return user;
					}
					return null;
				}
			}
		}
		
		
		public void LoadUserAccounts(DataGridView usersDataGridView)
		{
			var connection = dbManager.GetConnection();
			string query = "SELECT * FROM users";
			
			using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection)) {
				
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				usersDataGridView.DataSource = dt;
			}
			connection.Close();
		}
		
		
		public bool RechargeAccount(User user, decimal amount)
		{

			var connection = dbManager.GetConnection();
			string query = "UPDATE users SET Balance = Balance + @amount WHERE Code = @code";
			using (MySqlCommand command = new MySqlCommand(query, connection)) {
				command.Parameters.AddWithValue("@amount", amount);
				command.Parameters.AddWithValue("@code", user.Code);
				int rowsAffected = command.ExecuteNonQuery();
				connection.Close();
				return rowsAffected > 0;

			}
			
		}
		
		public decimal GetUserTotalBetAmountForToday(string userId)
		{
			try {
				using (var connection = dbManager.GetConnection()) {
					string query = @"SELECT COALESCE(SUM(TotalAmount), 0)
                             FROM Bets
                             WHERE UserId = @UserId
                             AND DATE(BetDate) = CURDATE()";

					using (var command = new MySqlCommand(query, connection)) {
						command.Parameters.AddWithValue("@UserId", userId);
						return Convert.ToDecimal(command.ExecuteScalar());
					}
				}
			} catch (Exception ex) {
				MessageBox.Show("Erreur lors du calcul du montant total des paris: " + ex.Message);
				return 0;
			}
		}
		
	}
}
