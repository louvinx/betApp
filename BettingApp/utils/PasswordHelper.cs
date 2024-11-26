/*
 * Created by SharpDevelop.
 * User: 1
 * Date: 11/5/2024
 * Time: 9:05 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Security.Cryptography;
using System.Text;

namespace BettingApp.utils
{
	/// <summary>
	/// Description of PasswordHelper.
	/// </summary>
	public class PasswordHelper
	{
		public PasswordHelper()
		{
		}
		
		
		// Hache le mot de passe en utilisant SHA-256
		public static string HashPassword(string password)
		{
			using (SHA256 sha256 = SHA256.Create())
			{
				byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
				return Convert.ToBase64String(bytes);
			}

		}

	
		public static bool VerifyPassword(string password, string storedHash)
		{
			string hashedPassword = HashPassword(password);
			return hashedPassword == storedHash;
		}
	}
}
