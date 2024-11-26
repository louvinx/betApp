/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 18/11/2024
 * Heure: 21:07
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using BettingApp.data.repository;
using BettingApp.model;
using BettingApp.utils;
using BettingApp.utils.validation;
using System.Collections.Generic;
using System.Linq;

namespace BettingApp.form.admin.match
{
	/// <summary>
	/// Description of MatchForm.
	/// </summary>
	public partial class MatchForm : Form
	{
		Match matchModify = new Match();
		Match matchModifyStatus = new Match();
		MatchValidation matchValidation = new MatchValidation();
		TeamRepository teamRepository = new TeamRepository();
		MatchRepository matchRepository = new MatchRepository();
		UtilsRepository utilsRepository = new UtilsRepository();
		public MatchForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			
			var style = new StyleForm();
			style.StyleDataGridView(matchDataGridView);
			teamRepository.LoadAllTeams();
			matchRepository.LoadMatch(matchDataGridView);
			
			matchTabControl.BackColor = Color.White;
			foreach (TabPage tabPage in matchTabControl.TabPages) {
				tabPage.BackColor = Color.White;
			}
		}
		
		private void LoadHomeTeamsToComboBoxes()
		{
			try {
				teamRepository.LoadAllTeams();
				hometeamComboBox.Items.Clear();
				hometeamComboBox.Items.Add("-- Sélectionnez une équipe --");
				
				string selectedType = "";
			
				if (typeMatchComboBox.SelectedItem != null) {
					selectedType = typeMatchComboBox.SelectedItem.ToString();
				}
				
				if (!matchValidation.ValidateTypeMatch(selectedType)) {
					return;
				}
				
				if (selectedType == "coupe du monde") {
					var availableTeams = teamRepository.allTeams
						.Where(t => t.TypeTeam == "National")
						.ToList();
					
					foreach (var team in availableTeams) {
						hometeamComboBox.Items.Add(team.TeamName);
					}
				} else {
					foreach (var team in teamRepository.allTeams) {
						hometeamComboBox.Items.Add(team.TeamName);
					}
				}
				
				hometeamComboBox.SelectedIndex = 0;
			} catch (Exception ex) {
				MessageBox.Show("Erreur lors du chargement des équipes: " + ex.Message,
					"Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadAwayTeamsToComboBoxes()
		{
			try {
				if (hometeamComboBox.SelectedIndex == 0) {
					MessageBox.Show("Veuillez d'abord sélectionner l'équipe à domicile",
						"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				awayTeamComboBox.Items.Clear();
				awayTeamComboBox.Items.Add("-- Sélectionnez une équipe --");

				var selectedHomeTeam = teamRepository.GetTeam(hometeamComboBox.SelectedItem.ToString());
				if (selectedHomeTeam == null) {
					MessageBox.Show("Équipe non trouvée", "Erreur",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				string matchType = "";
				if (typeMatchComboBox.SelectedItem != null) {
					matchType = typeMatchComboBox.SelectedItem.ToString();
				}

				if (!matchValidation.ValidateTypeMatch(matchType)) {
					return;
				}
				
				List<Team> availableTeams = new List<Team>();

				
				if (matchType == "championnat - ligue national") {
					availableTeams = teamRepository.allTeams
						.Where(t => t.TeamID != selectedHomeTeam.TeamID &&
					t.Country == selectedHomeTeam.Country)
						.ToList();
					
				} else if (matchType == "coupe du monde") {
					availableTeams = teamRepository.allTeams
						.Where(t => t.TeamID != selectedHomeTeam.TeamID &&
					t.TypeTeam == "National")
						.ToList();
				} else {
					availableTeams = teamRepository.allTeams
						.Where(t => t.TeamID != selectedHomeTeam.TeamID)
						.ToList();
				}

				foreach (var team in availableTeams) {
					awayTeamComboBox.Items.Add(team.TeamName);
				}

				awayTeamComboBox.SelectedIndex = 0;
			} catch (Exception ex) {
				MessageBox.Show("Erreur lors du chargement des équipes adverses: " + ex.Message,
					"Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void NextMatchButtonClick(object sender, EventArgs e)
		{
			string type = "";
		

			if (typeMatchComboBox.SelectedItem != null) {
				type = typeMatchComboBox.SelectedItem.ToString();
			}


			
			if (string.IsNullOrEmpty(type)) {
				MessageBox.Show("Veuillez sélectionner un type de match",
					"Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}



			
			homeTeamAddButton.Visible = true;
			panelHomeTeam.Visible = true;
			panelCoteHome.Visible = true;
			typeMatchComboBox.Enabled = false;
			nextMatchButton.Visible = false;
			panelCountry.Visible = true;


			LoadHomeTeamsToComboBoxes();
		}

		private void HomeTeamAddButtonClick(object sender, EventArgs e)
		{
			if (hometeamComboBox.SelectedIndex == 0) {
				MessageBox.Show("Veuillez sélectionner une équipe à domicile",
					"Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			if (!matchValidation.ValidateCotes(homeTeamCoteTextBox.Text)) {
				return;
			}
			

			
			panelAwayTeam.Visible = true;
			panelCoteAwayTeam.Visible = true;
			awayTeamAddButton.Visible = true;
			hometeamComboBox.Enabled = false;
			LoadAwayTeamsToComboBoxes();
			homeTeamAddButton.Visible = false;
			comboBoxCountry.Enabled = false;
		}
		
		private void AwayTeamAddButtonClick(object sender, System.EventArgs e)
		{
			try {
				if (awayTeamComboBox.SelectedIndex == 0) {
					MessageBox.Show("Veuillez sélectionner une équipe adverse",
						"Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				
				
				if (!matchValidation.ValidateCotes(awayTeamCoteTextBox.Text)) {
					return;
				}
				

				if (awayTeamComboBox.SelectedItem.ToString() == hometeamComboBox.SelectedItem.ToString()) {
					MessageBox.Show("L'équipe adverse ne peut pas être la même que l'équipe à domicile",
						"Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				panelDateMatch.Visible = true;
				panelHoursMatch.Visible = true;
				panelDraw.Visible = true;
				addMatchButton.Visible = true;

				awayTeamAddButton.Visible = false;
			} catch (Exception ex) {
				MessageBox.Show("Erreur lors de la sélection de l'équipe adverse: " + ex.Message,
					"Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		public bool CanAddMatch(int homeTeamId, int awayTeamId, DateTime matchDate)
		{
    
			bool isHomeTeamAvailable = utilsRepository.CheckTeamAvailability(homeTeamId, matchDate);
			if (!isHomeTeamAvailable) {
				MessageBox.Show(
					"L'équipe à domicile a déjà un match prévu pour cette date.",
					"Indisponibilité",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
				return false;
			}

    
			bool isAwayTeamAvailable = utilsRepository.CheckTeamAvailability(awayTeamId, matchDate);
			if (!isAwayTeamAvailable) {
				MessageBox.Show(
					"L'équipe à l'extérieur a déjà un match prévu pour cette date.",
					"Indisponibilité",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
				return false;
			}

			return true;
		}
				
		void AddMatchButtonClick(object sender, EventArgs e)
		{
			try {
				
				if (hometeamComboBox.SelectedIndex == 0 || awayTeamComboBox.SelectedIndex == 0) {
					MessageBox.Show("Veuillez sélectionner les deux équipes",
						"Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				
				if (!matchValidation.ValidateCotes(homeTeamCoteTextBox.Text)) {
					return;
				}
				if (!matchValidation.ValidateCotes(textBoxCoteDraw.Text)) {
					return;
				}
				if (!matchValidation.ValidateCotes(awayTeamCoteTextBox.Text)) {
					return;
				}
				
				if (awayTeamCoteTextBox.Text == homeTeamCoteTextBox.Text || awayTeamCoteTextBox.Text == textBoxCoteDraw.Text || homeTeamCoteTextBox.Text == textBoxCoteDraw.Text) {
					MessageBox.Show("Les trois cotes doivent etre differentes l'une de l'autre",
						"Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				var homeTeam = teamRepository.GetTeam(hometeamComboBox.SelectedItem.ToString());
				var awayTeam = teamRepository.GetTeam(awayTeamComboBox.SelectedItem.ToString());

				string matchTime = (numericUpDownHours.Value < 10 ? "0" + numericUpDownHours.Value : numericUpDownHours.Value.ToString())
				                   + "h"
				                   + (numericUpDownMinutes.Value < 10 ? "0" + numericUpDownMinutes.Value : numericUpDownMinutes.Value.ToString())
				                   + "mm";


				if (!matchValidation.ValidateHourMatch(matchTime)) {
					return;
				}
				
				var match = new Match {
					MatchId = Guid.NewGuid().ToString(),
					MatchType = typeMatchComboBox.SelectedItem.ToString(),
					Country = comboBoxCountry.SelectedItem.ToString(),
					MatchDate = dateTimePickerDateMatch.Value,
					MatchTime = matchTime,
					HomeTeam = homeTeam.TeamID,
					AwayTeam = awayTeam.TeamID,
					HomeWinOdds = decimal.Parse(homeTeamCoteTextBox.Text),
					DrawOdds = decimal.Parse(textBoxCoteDraw.Text),
					AwayWinOdds = decimal.Parse(awayTeamCoteTextBox.Text)
				};

				if (CanAddMatch(match.HomeTeam, match.AwayTeam, match.MatchDate)) {
					if (matchRepository.SaveMatch(match)) {
						MessageBox.Show("Match enregistré avec succès",
							"Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
						addMatchButton.Visible = false;
						ResetForm();
					} else {
						MessageBox.Show("Erreur lors de l'enregistrement du match",
							"Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				
			} catch (Exception ex) {
				MessageBox.Show("Erreur : " + ex.Message,
					"Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		
		
		
		
		void ButtonModifyClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(matchModifyStatus.MatchId)) {
				MessageBox.Show("Veuillez sélectionner une ligne valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			ModifyStatusMatchForm modifyStatusMatch = new ModifyStatusMatchForm(matchModifyStatus);
			modifyStatusMatch.Show();
		}
		
		
		void MatchDataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
		{
			matchModifyStatus = new Match();

			
			if (matchDataGridView.SelectedRows.Count == 1) {
				
				DataGridViewRow selectedRow = matchDataGridView.SelectedRows[0];
				if (string.IsNullOrEmpty(selectedRow.Cells["MatchId"].Value.ToString())) {
					MessageBox.Show("Veuillez sélectionner une ligne valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				matchModifyStatus.MatchId = selectedRow.Cells["MatchId"].Value.ToString();
				matchModifyStatus.MatchType = selectedRow.Cells["MatchType"].Value.ToString();
				matchModifyStatus.Country = selectedRow.Cells["Country"].Value.ToString();
				matchModifyStatus.MatchDate = DateTime.Parse(selectedRow.Cells["MatchDate"].Value.ToString());
				matchModifyStatus.MatchTime = selectedRow.Cells["MatchTime"].Value.ToString();
				matchModifyStatus.HomeTeam = int.Parse(selectedRow.Cells["HomeTeamId"].Value.ToString());
				matchModifyStatus.AwayTeam = int.Parse(selectedRow.Cells["AwayTeamId"].Value.ToString());
				matchModifyStatus.HomeWinOdds = decimal.Parse(selectedRow.Cells["HomeWinOdds"].Value.ToString());
				matchModifyStatus.DrawOdds = decimal.Parse(selectedRow.Cells["DrawOdds"].Value.ToString());
				matchModifyStatus.AwayWinOdds = decimal.Parse(selectedRow.Cells["AwayWinOdds"].Value.ToString());
				matchModifyStatus.FinalScore = selectedRow.Cells["FinalScore"].Value.ToString();
				matchModifyStatus.Status = selectedRow.Cells["Status"].Value.ToString();
			} else if (matchDataGridView.SelectedRows.Count > 1) {
				MessageBox.Show("Veuillez sélectionner une seule ligne.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				matchDataGridView.ClearSelection();
			}
		}
		
		private void ResetForm()
		{
			
			typeMatchComboBox.Enabled = true;
			comboBoxCountry.Enabled = true;
			hometeamComboBox.Enabled = true;
			
			
			hometeamComboBox.SelectedIndex = 0;
			awayTeamComboBox.SelectedIndex = 0;
			homeTeamCoteTextBox.Clear();
			textBoxCoteDraw.Clear();
			awayTeamCoteTextBox.Clear();
			
			
			nextMatchButton.Visible = true;
			homeTeamAddButton.Visible = false;
			awayTeamAddButton.Visible = false;
			panelHomeTeam.Visible = false;
			panelAwayTeam.Visible = false;
			panelCoteHome.Visible = false;
			panelCoteAwayTeam.Visible = false;
			panelDateMatch.Visible = false;
			panelHoursMatch.Visible = false;
			panelDraw.Visible = false;
			panelCountry.Visible = false;
		}
		
		void MatchDataGridViewRowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{

			var row = matchDataGridView.Rows[e.RowIndex];

			if (row.Cells["Status"].Value != null) {
				string status = row.Cells["Status"].Value.ToString();

				
				switch (status) {
					case "N":  // Non joué
						row.DefaultCellStyle.BackColor = Color.LightGray; 
						break;

					case "E":  // En cours
						row.DefaultCellStyle.BackColor = Color.LightBlue;  
						break;

					case "T":  // Terminé
						row.DefaultCellStyle.BackColor = Color.LightGreen;  
						break;

					case "A":  // Annulé
						row.DefaultCellStyle.BackColor = Color.LightCoral;  
						break;

					case "S":  // Supprimé
						row.DefaultCellStyle.BackColor = Color.LightYellow;  
						break;

					default:
						row.DefaultCellStyle.BackColor = Color.White;  
						break;
				}
			} else {
				
				row.DefaultCellStyle.BackColor = Color.White;
			}


		}

	}
}

