/*
 * Created by SharpDevelop.
 * User: 1
 * Date: 11/14/2024
 * Time: 7:47 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;

namespace BettingApp.model
{
	/// <summary>
	/// Description of Match.
	/// </summary>
	public class Match
	{
		
		public string MatchId { get; set; }
		public string MatchType { get; set; }
		public string Country { get; set; }
		public DateTime MatchDate { get; set; }
		public string MatchTime { get; set; }
		public int HomeTeam { get; set; }
		public int AwayTeam { get; set; }
		public decimal HomeWinOdds { get; set; }
		public decimal DrawOdds { get; set; }
		public decimal AwayWinOdds { get; set; }
		public string Status { get; set; }
		public string FinalScore { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
		
		
		
		
		public Match()
		{
			CreatedAt = DateTime.Now;
			UpdatedAt = DateTime.Now;
		}

		
		public Match(string matchId, string matchType, string country, DateTime matchDate, string matchTime,
		             int homeTeam, int awayTeam, decimal homeWinOdds, decimal drawOdds, decimal awayWinOdds,
		             string status, string finalScore)
		{
			MatchId = matchId;
			MatchType = matchType;
			Country = country;
			MatchDate = matchDate;
			MatchTime = matchTime;
			HomeTeam = homeTeam;
			AwayTeam = awayTeam;
			HomeWinOdds = homeWinOdds;
			DrawOdds = drawOdds;
			AwayWinOdds = awayWinOdds;
			Status = status;
			FinalScore = finalScore;
			CreatedAt = DateTime.Now;
			UpdatedAt = DateTime.Now;
		}

		public Match(MySqlDataReader reader)
		{
			MatchId = reader["MatchId"] != DBNull.Value ? reader["MatchId"].ToString() : "";
			MatchType = reader["MatchType"] != DBNull.Value ? reader["MatchType"].ToString() : "";
			Country = reader["Country"] != DBNull.Value ? reader["Country"].ToString() : "";
			MatchDate = reader["MatchDate"] != DBNull.Value ? Convert.ToDateTime(reader["MatchDate"]) : DateTime.MinValue;
			MatchTime = reader["MatchTime"] != DBNull.Value ? reader["MatchTime"].ToString() : "";
			HomeTeam = reader["HomeTeamId"] != DBNull.Value ? Convert.ToInt32(reader["HomeTeamId"]) : 0;
			AwayTeam = reader["AwayTeamId"] != DBNull.Value ? Convert.ToInt32(reader["AwayTeamId"]) : 0;
			HomeWinOdds = reader["HomeWinOdds"] != DBNull.Value ? Convert.ToDecimal(reader["HomeWinOdds"]) : 0;
			DrawOdds = reader["DrawOdds"] != DBNull.Value ? Convert.ToDecimal(reader["DrawOdds"]) : 0;
			AwayWinOdds = reader["AwayWinOdds"] != DBNull.Value ? Convert.ToDecimal(reader["AwayWinOdds"]) : 0;
			FinalScore = reader["FinalScore"] != DBNull.Value ? reader["FinalScore"].ToString() : "";
			Status = reader["Status"] != DBNull.Value ? reader["Status"].ToString() : "";
			CreatedAt = reader["CreatedAt"] != DBNull.Value ? Convert.ToDateTime(reader["CreatedAt"]) : DateTime.MinValue;
			UpdatedAt = reader["UpdatedAt"] != DBNull.Value ? Convert.ToDateTime(reader["UpdatedAt"]) : DateTime.MinValue;
		}


		
	}
	
	
}
