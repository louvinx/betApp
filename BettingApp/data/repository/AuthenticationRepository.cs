/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 04/11/2024
 * Heure: 11:33
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using BettingApp.utils;
using BettingApp.model;
using BettingApp.data;
using BettingApp.data.repository;
using MySql.Data.MySqlClient;
using System.Windows.Forms;





namespace BettingApp.data.repository
{
	/// <summary>
	/// Description of AuthenticationRepository
	/// </summary>
	public class AuthenticationRepository
	{
		
		private DatabaseManager dbManager;
		
//		public static User authUser = new User {
//			Code = "44d3803f-1",
//			LastName = "Doe",
//			FirstName = "John",
//			Gender = "Masculin",
//			Phone = "+123456789",
//			NifCin = "NIF123456",
//			Username = "johndoe",
//			Password = PasswordHelper.HashPassword("securePassword123"),
//			Balance = 80000.00m,
//			BirthDate = DateTime.Parse("01/01/2001 00:00:00"),
//			Role = "USER",
//			Status = "Active",
//			CreatedAt = DateTime.Now,
//			UpdatedAt = DateTime.Now
//		};

		public static User authUser = null;
		UtilsRepository utilsRepository = new UtilsRepository();
		public AuthenticationRepository()
		{
			
			dbManager = new DatabaseManager();
		}
		
		
		public bool Register(User user)
		{
			if (dbManager == null) {
				MessageBox.Show("DatabaseManager non initialisé.", "Erreur",
				                MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			
			var connection = dbManager.GetConnection();
			if (connection == null) {
				MessageBox.Show("La connexion à la base de données est invalide.", "Erreur",
				                MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			
			if (!utilsRepository.CheckUnique("users", "Username", user.Username)) {
				MessageBox.Show("Ce nom d'utilisateur est déjà utilisé!", "Erreur",
				                MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			
			
			if (!utilsRepository.CheckUnique("users", "NifCin", user.NifCin)) {
				MessageBox.Show("Ce NIF/CIN est déjà utilisé!", "Erreur",
				                MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			
			
			if (!utilsRepository.CheckUnique("users", "Phone", user.Phone)) {
				MessageBox.Show("Ce numéro de téléphone est déjà utilisé!", "Erreur",
				                MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			try {
				string hashedPassword = PasswordHelper.HashPassword(user.Password);
				string insertQuery = @"
            INSERT INTO Users (Code, LastName, FirstName, Gender, BirthDate,
                             Phone, NifCin, Username, Password, Status)
            VALUES (@Code, @LastName, @FirstName, @Gender, @BirthDate,
                    @Phone, @NifCin, @Username, @Password, 'A');";

				MySqlParameter[] insertParams = new MySqlParameter[] {
					new MySqlParameter("@Code", user.Code),
					new MySqlParameter("@LastName", user.LastName),
					new MySqlParameter("@FirstName", user.FirstName),
					new MySqlParameter("@Gender", user.Gender),
					new MySqlParameter("@BirthDate", user.BirthDate),
					new MySqlParameter("@Phone", user.Phone),
					new MySqlParameter("@NifCin", user.NifCin),
					new MySqlParameter("@Username", user.Username),
					new MySqlParameter("@Password", hashedPassword),
				};
				
				using (MySqlCommand command = new MySqlCommand(insertQuery, connection)) {
					command.Parameters.AddRange(insertParams);
					command.ExecuteNonQuery();
					
					MessageBox.Show("Utilisateur enregistré avec succès!", "Succès",
					                MessageBoxButtons.OK, MessageBoxIcon.Information);
					return true;
				}
			} catch (Exception ex) {
				MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message, "Erreur",
				                MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}
		
		
		public User Login(string username, string password)
		{
			
			if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) {
				MessageBox.Show("Le nom d'utilisateur et le mot de passe sont requis!", "Erreur",
				                MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return null;
			}

			if (dbManager == null) {
				MessageBox.Show("DatabaseManager non initialisé.", "Erreur",
				                MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
			
			var connection = dbManager.GetConnection();
			if (connection == null) {
				MessageBox.Show("La connexion à la base de données est invalide.", "Erreur",
				                MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}

			try {
				string query = @"SELECT * FROM Users
                        WHERE Username = @Username
                        AND Status = 'A'";
				
				using (MySqlCommand command = new MySqlCommand(query, connection)) {
					command.Parameters.AddWithValue("@Username", username);
					
					using (MySqlDataReader reader = command.ExecuteReader()) {
						if (!reader.Read()) {
							MessageBox.Show("Utilisateur non inscrire!", "Erreur de connexion",
							                MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return null;
						}

						User user = new User {
							Code = reader.GetString(0),
							LastName = reader.GetString(1),
							FirstName = reader.GetString(2),
							Gender = reader.GetString(3),
							BirthDate = reader.GetDateTime(4),
							Phone = reader.GetString(5),
							NifCin = reader.GetString(6),
							Username = reader.GetString(7),
							Password = reader.GetString(8),
							Balance = reader.GetDecimal(9),
							Role = reader.GetString(10),
							Status = reader.GetString(11)
						};

						
						if (!PasswordHelper.VerifyPassword(password, user.Password)) {
							MessageBox.Show("Information incorrect!", "Erreur de connexion",
							                MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return null;
						}

						
						if (user.Status != "A") {
							MessageBox.Show("Ce compte est désactivé. Contactez l'administrateur.",
							                "Compte inactif", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return null;
						}

						authUser = user;
						MessageBox.Show("Bienvenue " + user.FirstName + " " + user.LastName, "Connexion réussie",
						                MessageBoxButtons.OK, MessageBoxIcon.Information);
						return user;
					}
				}
			} catch (MySqlException ex) {
				MessageBox.Show("Erreur de connexion à la base de données : " + ex.Message,
				                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			} catch (Exception ex) {
				MessageBox.Show("Une erreur est survenue : " + ex.Message,
				                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}
		
		public void Logout()
		{
			authUser = null;
		}

	}
}
