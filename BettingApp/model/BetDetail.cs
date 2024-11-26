/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 20/11/2024
 * Heure: 07:18
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;

namespace BettingApp.model
{
	/// <summary>
	/// Description of BetDetail.
	/// </summary>
	public class BetDetail
	{
		public int BetDetailId { get; set; }
		public string BetId { get; set; }
		public string MatchId { get; set; }
		public int? PredictedTeamWinner { get; set; }
		public decimal OddValue { get; set; }
		public string WinStatus { get; set; }
		public DateTime CreatedAt { get; set; }

		public BetDetail()
		{
			CreatedAt = DateTime.Now;
			WinStatus = "PENDING";
		}
		
		 public BetDetail(int betDetailId, string betId, string matchId, int? predictedTeamWinner, 
                     decimal oddValue, string winStatus)
    {
        BetDetailId = betDetailId;
        BetId = betId;
        MatchId = matchId;
        PredictedTeamWinner = predictedTeamWinner;
        OddValue = oddValue;
        WinStatus = winStatus;
        CreatedAt = DateTime.Now; 
    }

		public override string ToString()
		{
			return BetDetailId + " " + BetId + " " + MatchId  + " " + PredictedTeamWinner + " " + OddValue + " " + WinStatus;
		}
	}
}
