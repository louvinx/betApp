/*
 * Created by SharpDevelop.
 * User: 1
 * Date: 11/7/2024
 * Time: 7:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BettingApp.model
{
	/// <summary>
	/// Description of Team.
	/// </summary>

	public class Team
	{
		public int TeamID { get; set; }
		public string TeamName { get; set; }
		public string Country { get; set; }
		public string TypeTeam { get; set; }
		public string LogoPath { get; set; }
		public DateTime CreatedAt { get; set; }


		  
    public Team()
    {
        CreatedAt = DateTime.Now; 
    }

   
    public Team(int teamID, string teamName, string country, string typeTeam, string logoPath)
    {
        TeamID = teamID;
        TeamName = teamName;
        Country = country;
        TypeTeam = typeTeam;
        LogoPath = logoPath;
        CreatedAt = DateTime.Now; 
    }

		// Méthode ToString
		public override string ToString()
		{
			return "ID : " + TeamID + "  Name : " + TeamName + "Country : " + Country + "TypeTeam" + TypeTeam + " LogoPath " + LogoPath ;
		}
	}


}
