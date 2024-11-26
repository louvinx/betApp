/*
 * Created by SharpDevelop.
 * User: 1
 * Date: 11/15/2024
 * Time: 11:29 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BettingApp.utils.validation
{
	/// <summary>
	/// Description of TeamValidation.
	/// </summary>
	public class TeamValidation
	{
		public TeamValidation()
		{
		}
		
		
		public bool ValidateNameTeam(string nameTeam)
		{
			if (string.IsNullOrWhiteSpace(nameTeam))
			{
				MessageBox.Show("Le nom de l'équipe ne peut pas être vide.", "Erreur de validation",
				                MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (nameTeam.Length > 100)
			{
				MessageBox.Show("Le nom de l'équipe ne peut pas dépasser 100 caractères.", "Erreur de validation",
				                MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}

		public bool ValidateCountry(string country)
		{
			if (string.IsNullOrWhiteSpace(country))
			{
				MessageBox.Show("Le pays ne peut pas être vide.", "Erreur de validation",
				                MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (country.Length > 50)
			{
				MessageBox.Show("Le nom du pays ne peut pas dépasser 50 caractères.", "Erreur de validation",
				                MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;
		}
		
		
		public bool ValidateType(string typeTeam)
		{
			if (string.IsNullOrWhiteSpace(typeTeam))
			{
				MessageBox.Show("Le type ne peut pas être vide.", "Erreur de validation",
				                MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (typeTeam.Length > 50)
			{
				MessageBox.Show("Le type ne peut pas dépasser 50 caractères.", "Erreur de validation",
				                MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			
			if (typeTeam != "National" && typeTeam != "Club")
			{
				MessageBox.Show("Le type doit etre National ou Club.", "Erreur de validation",
				                MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			

			return true;
		}

	}
}
