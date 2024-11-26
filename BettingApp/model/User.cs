/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 04/11/2024
 * Heure: 11:34
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;

namespace BettingApp.model
{
	/// <summary>
	/// Description of User.
	/// </summary>
	public class User
	{
		public string Code { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public string Gender { get; set; }
		public DateTime BirthDate { get; set; }
		public string Phone { get; set; }
		public string NifCin { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public decimal Balance { get; set; }
		public string Role { get; set; }
		public string Status { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
		
		
		
		public User()
		{
			CreatedAt = DateTime.Now;
			UpdatedAt = DateTime.Now;
		}

		
		public User(string code, string lastName, string firstName, string gender, DateTime birthDate, 
			string phone, string nifCin, string username, string password, decimal balance, 
			string role, string status)
		{
			Code = code;
			LastName = lastName;
			FirstName = firstName;
			Gender = gender;
			BirthDate = birthDate;
			Phone = phone;
			NifCin = nifCin;
			Username = username;
			Password = password;
			Balance = balance;
			Role = role;
			Status = status;
			CreatedAt = DateTime.Now;
			UpdatedAt = DateTime.Now;
		}
		
		
		public override String ToString()
		{
			return Code + " " + LastName + " " + FirstName + " " + Gender + " " +
			BirthDate + " " + Phone + " " + NifCin + " " + Username + " " + Password + " " + Role + " " +
			Balance + " " + Status + " " + CreatedAt;
		}
	}
}
