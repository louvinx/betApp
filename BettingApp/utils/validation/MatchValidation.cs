/*
 * Created by SharpDevelop.
 * User: 1
 * Date: 11/15/2024
 * Time: 8:57 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace BettingApp.utils.validation
{
	/// <summary>
	/// Description of MatchValidation.
	/// </summary>
	public class MatchValidation
	{
		public MatchValidation()
		{
		}
		
		
		public bool ValidateTypeMatch(string typeMatch)
		{
			
			if (typeMatch != "championnat - ligue national" && typeMatch != "coupe du monde" && typeMatch != "éliminatoire" && typeMatch != "amical" && typeMatch != "autre") {
				MessageBox.Show("Type de match invalide.", "Erreur de validation",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}

		public bool ValidateDateMatch(DateTime dateMatch)
		{
			if (dateMatch.Date < DateTime.Now.Date) {
				MessageBox.Show("La date du match ne peut pas être dans le passé.", "Erreur de validation",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}
		
		public bool ValidateHourMatch(string heureMatch)
		{
			try {
				
				if (!Regex.IsMatch(heureMatch, @"^\d{2}h\d{2}mm$")) {
					MessageBox.Show("L'heure doit être au format '00h00mm'.", "Erreur de validation",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}

				
				int hours = int.Parse(heureMatch.Substring(0, 2));
				int minutes = int.Parse(heureMatch.Substring(3, 2));

				
				if (hours < 0 || hours >= 24) {
					MessageBox.Show("Les heures doivent être entre 01 et 23 inclus.", "Erreur de validation",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}

				if (minutes < 0 || minutes >= 60) {
					MessageBox.Show("Les minutes doivent être entre 00 et 59.", "Erreur de validation",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}

				if (hours == 0 && minutes == 0) {
					MessageBox.Show("L'heure du match doit être strictement supérieure à 00h00mm.", "Erreur de validation",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}

				return true;
			} catch (Exception) {
				MessageBox.Show("L'heure du match est invalide.", "Erreur de validation",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}



		public bool ValidateCotes(string cotes)
		{
			try {
				decimal cotesValue = decimal.Parse(cotes);

				if (cotesValue <= 1.0m) {
					MessageBox.Show("Les cotes doivent être supérieures à 1.", "Erreur de validation",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
				if (cotesValue > 999.99m) {
					MessageBox.Show("Les cotes ne peuvent pas dépasser 999.99.", "Erreur de validation",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
				return true;
			} catch (FormatException) {
				MessageBox.Show("L'entrée du cote n'est pas un nombre valide.", "Erreur de validation",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			} catch (OverflowException) {
				MessageBox.Show("L'entrée du cote est trop grande pour être un nombre valide.", "Erreur de validation",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}


		public bool ValidateScoreFinal(string scoreFinal)
		{
			if (!Regex.IsMatch(scoreFinal, @"^\d{1,2}:\d{1,2}$")) {
				MessageBox.Show("Format de score invalide. Utilisez le format 'X:Y'.", "Erreur de validation",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}
	}
}

