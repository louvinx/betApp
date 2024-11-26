/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 20/11/2024
 * Heure: 07:16
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;

namespace BettingApp.model
{
	/// <summary>
	/// Description of Bet.
	/// </summary>

	
	public class Bet
	{
		public string BetId { get; set; }
		public string UserId { get; set; }
		public DateTime BetDate { get; set; }
		public decimal TotalAmount { get; set; }
		public string Status { get; set; }

		public Bet()
		{
			BetDate = DateTime.Now;
			Status = "PENDING";
		}
		
		public Bet(string betId, string userId, DateTime betDate, decimal totalAmount, string status)
		{
			BetId = betId;
			UserId = userId;
			BetDate = betDate;
			TotalAmount = totalAmount;
			Status = status;
		}

		
		public override string ToString()
		{
			return "Information du fiche [" +
			"ID : " + BetId + ", " +
//			"User:" + UserId + ", " +
			"Date : " + BetDate + ", " +
			"Montant pari : " + TotalAmount + ", " +
			"Status : " + Status +
			"]";
		}
		
	}
	
}
