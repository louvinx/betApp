/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 04/11/2024
 * Heure: 11:33
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */

using System;
using System.Collections.Generic;
using BettingApp.model;
using MySql.Data.MySqlClient;
using BettingApp.data;
using System.Windows.Forms;
using System.Drawing;
using System.IO;




namespace BettingApp.data.repository
{
	/// <summary>
	/// Description of TeamRepository.
	/// </summary>
	public class TeamRepository
	{
		
		private DatabaseManager dbManager;
		public List<Team> allTeams;
		UtilsRepository utilsRepository = new UtilsRepository();
		public TeamRepository()
		{
			dbManager = new DatabaseManager();
		}
		
		
		
		public bool AddTeam(Team team)
		{
			
			if (!utilsRepository.CheckUnique("Teams", "TeamName", team.TeamName)) {
				return false;
			}
			
			if (!utilsRepository.CheckUnique("Teams", "LogoPath", team.LogoPath)) {
				return false;
			}
			
			var connection = dbManager.GetConnection();
			string query = @"INSERT INTO Teams (TeamName, Country, TypeTeam, LogoPath)
                    VALUES (@TeamName, @Country, @TypeTeam, @LogoPath)";
			
			using (var command = new MySqlCommand(query, connection)) {
				command.Parameters.AddWithValue("@TeamName", team.TeamName);
				command.Parameters.AddWithValue("@Country", team.Country);
				command.Parameters.AddWithValue("@TypeTeam", team.TypeTeam);
				command.Parameters.AddWithValue("@LogoPath", team.LogoPath);
				
				return command.ExecuteNonQuery() > 0;
			}
		}
		
		
		public void LoadAllTeams()
		{
			allTeams = new List<Team>();
			try {
				var connection = dbManager.GetConnection();
				string query = "SELECT TeamID, TeamName, Country FROM Teams ORDER BY TeamName";
				using (MySqlCommand command = new MySqlCommand(query, connection)) {

					using (MySqlDataReader reader = command.ExecuteReader()) {
						while (reader.Read()) {
							var team = new Team();
							team.TeamID = reader.GetInt32("TeamID");
							team.TeamName = reader.GetString("TeamName");
							team.Country = reader.GetString("Country");
							allTeams.Add(team);
						}
					}
				}
			} catch (Exception ex) {
				MessageBox.Show("Erreur lors du chargement des équipes: " + ex.Message);
			}
			
		}

		


		private Image LoadLogoImage(string logoPath)
		{
			try {
				
				if (File.Exists(logoPath)) {
					return Image.FromFile(logoPath);
				} else {
					return null;
				}
			} catch (Exception ex) {
				MessageBox.Show("Error loading logo image: " + ex.Message);
				return null;
			}
		}

		public Team GetTeamByID(int TeamID)
		{
			string query = "SELECT * FROM Teams WHERE TeamID = @TeamID";
			MySqlParameter[] parameters = {
				new MySqlParameter("@TeamID", TeamID)
			};

			using (MySqlCommand command = new MySqlCommand(query, dbManager.GetConnection())) {
				command.Parameters.AddRange(parameters);

				using (MySqlDataReader reader = command.ExecuteReader()) {
					if (reader.Read()) {
						Team team = new Team();
						team.TeamID = reader.GetInt32("TeamID");
						team.TeamName = reader.GetString("TeamName");
						team.Country = reader.GetString("Country");
						team.TypeTeam = reader.GetString("TypeTeam");
						team.LogoPath = reader.GetString("LogoPath");
						
						return team;
					}
					return null;
				}
			}
		}
		
		

		public Team GetTeam(string teamName)
		{
			string query = "SELECT * FROM Teams WHERE TeamName = @teamName";
			MySqlParameter[] parameters = {
				new MySqlParameter("@teamName", teamName)
			};

			using (MySqlCommand command = new MySqlCommand(query, dbManager.GetConnection())) {
				command.Parameters.AddRange(parameters);

				using (MySqlDataReader reader = command.ExecuteReader()) {
					if (reader.Read()) {
						Team team = new Team();
						team.TeamID = reader.GetInt32("TeamID");
						team.TeamName = reader.GetString("TeamName");
						team.Country = reader.GetString("Country");
						team.TypeTeam = reader.GetString("TypeTeam");
						team.LogoPath = reader.GetString("LogoPath");
						
						return team;
					}
					return null;
				}
			}
		}

		
		
		public void LoadTeams(Panel logoPanel)
		{
			var connection = dbManager.GetConnection();
			string query = "SELECT * FROM teams";

			using (MySqlCommand command = new MySqlCommand(query, connection))
			using (MySqlDataReader reader = command.ExecuteReader()) {
				logoPanel.Controls.Clear();
				logoPanel.AutoScroll = true;
				int xPos = 20;
				int yPos = 20;

				while (reader.Read()) {
					Panel teamPanel = new Panel {
						Size = new Size(280, 160),
						Location = new Point(xPos, yPos),
						BackColor = Color.FromArgb(248, 249, 250),
						Cursor = Cursors.Hand
					};

					PictureBox logoPictureBox = new PictureBox {
						Size = new Size(70, 70),
						Image = LoadLogoImage(reader["LogoPath"].ToString()),
						SizeMode = PictureBoxSizeMode.Zoom,
						Location = new Point(190, 20),
						BackColor = Color.Transparent
					};

					Label teamIdLabel = CreateStyledLabel("ID: " + reader["TeamId"], new Point(20, 20), FontStyle.Bold, Color.FromArgb(100, 100, 100));
					Label teamNameLabel = CreateStyledLabel(reader["TeamName"].ToString(), new Point(20, 50), FontStyle.Bold, Color.FromArgb(51, 51, 51));
					Label countryLabel = CreateStyledLabel("🌍 " + reader["Country"], new Point(20, 80), FontStyle.Regular, Color.FromArgb(102, 102, 102));
					Label typeTeamLabel = CreateStyledLabel("📊 " + reader["TypeTeam"], new Point(20, 110), FontStyle.Regular, Color.FromArgb(102, 102, 102));
					Label deleteTeamLabel = CreateStyledLabel("Supprimer", new Point(20, 140), FontStyle.Regular, Color.Red);
					deleteTeamLabel.Font = new Font("Century Gothic", 8.5f);
					deleteTeamLabel.Cursor = Cursors.Hand;
					int idTeam = Convert.ToInt32(reader["TeamId"]);
					deleteTeamLabel.Click += (sender, e) => {
						if (DeleteTeam(idTeam)) {
							MessageBox.Show("Équipe supprimer avec succès !", "succès ", MessageBoxButtons.OK, MessageBoxIcon.Information);
						    LoadTeams(logoPanel);
						}
					};

					teamPanel.Controls.AddRange(new Control[] {
						logoPictureBox,
						teamIdLabel,
						teamNameLabel,
						countryLabel,
						typeTeamLabel,
						deleteTeamLabel
					});

					teamPanel.MouseEnter += (s, e) => {
						teamPanel.BackColor = Color.White;
					};
					teamPanel.MouseLeave += (s, e) => {
						teamPanel.BackColor = Color.FromArgb(248, 249, 250);
					};

					logoPanel.Controls.Add(teamPanel);

					
					xPos += 300;
					if (xPos > logoPanel.Width) {
						yPos += 180;
						xPos = 20;
					}
				}
			}
		}


		
		private Label CreateStyledLabel(string text, Point location, FontStyle style, Color color)
		{
			return new Label {
				Text = text,
				Font = new Font("Century Gothic", 9.5f, style),
				ForeColor = color,
				Location = location,
				AutoSize = true,
				BackColor = Color.Transparent
			};
		}
		
		
		public bool DeleteTeam(int teamId)
		{
			try {
				using (var connection = dbManager.GetConnection()) {
					string query = @"DELETE FROM Teams WHERE TeamId = @TeamId";
					using (var command = new MySqlCommand(query, connection)) {
						command.Parameters.AddWithValue("@TeamId", teamId);

						int rowsAffected = command.ExecuteNonQuery();
						return rowsAffected > 0;
					}
				}
			} catch (Exception) {
				MessageBox.Show("Erreur lors de la suppression de l'équipe a des matches en cours");
				return false;
			}
		}

	}
}
