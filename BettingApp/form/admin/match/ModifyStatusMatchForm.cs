/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 18/11/2024
 * Heure: 22:21
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using BettingApp.data.repository;
using BettingApp.model;
using BettingApp.utils.validation;
using BettingApp.utils;

namespace BettingApp.form.admin.match
{
	/// <summary>
	/// Description of ModifyStatusMatchForm.
	/// </summary>
	public partial class ModifyStatusMatchForm : Form
	{
		
		Match matchModify = new Match();
		MatchRepository matchRepository = new MatchRepository();
		TeamRepository teamRepository = new TeamRepository();
		MatchValidation matchValidation = new MatchValidation();
		
		public ModifyStatusMatchForm(Match matchModifyStatus)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			labelTypeMatch.Text = matchModifyStatus.MatchType;
			labelDate.Text = matchModifyStatus.MatchDate.ToString();
			labelHours.Text = matchModifyStatus.MatchTime;
			textBoxScoreFinal.Text = matchModifyStatus.FinalScore;
			comboBoxStatus.Text = matchModifyStatus.Status;
			var homeTeam = teamRepository.GetTeamByID(matchModifyStatus.HomeTeam);
			pictureBoxHomeTeam.Image = Image.FromFile(homeTeam.LogoPath);
			labelHome.Text = homeTeam.TeamName;
			var awayTeam = teamRepository.GetTeamByID(matchModifyStatus.AwayTeam);
			pictureBoxAwayTeam.Image = Image.FromFile(awayTeam.LogoPath);
			labelAway.Text = awayTeam.TeamName;
			matchModify = matchModifyStatus;
		}
		
		
		
		
		void ButtonScoreClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxScoreFinal.Text)) {
				MessageBox.Show("Erreur: Veuillez remplir le score final.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (matchValidation.ValidateScoreFinal(textBoxScoreFinal.Text)) {
				bool success = matchRepository.UpdateMatchStatusAndProcessPayments(matchModify.MatchId, "T", textBoxScoreFinal.Text);
				if (success) {
					this.Hide();
					MessageBox.Show("Match enregistré avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
					
				} else {
					MessageBox.Show("Erreur lors de l'enregistrement ou du traitement des paiements.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			} else {
				MessageBox.Show("Le score final est invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		
		void ButtonModifyStatusClick(object sender, EventArgs e)
		{
			if (comboBoxStatus.SelectedItem == null ||
			    string.IsNullOrEmpty(comboBoxStatus.SelectedItem.ToString())) {
				MessageBox.Show("Erreur: Veuillez sélectionner un statut.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			string selectedStatus = comboBoxStatus.SelectedItem.ToString();
			bool success = matchRepository.UpdateMatchStatusAndProcessPayments(matchModify.MatchId, selectedStatus);

			if (success) {
				if (selectedStatus == "T") {
					MessageBox.Show("Le match est terminé. Veuillez entrer le score final.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
					panelScore.Visible = true;
					buttonScore.Visible = true;
				} else {
					MessageBox.Show("Le statut du match a été modifié avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Hide();
				}
			} else {
				MessageBox.Show("Erreur lors de la modification du statut du match.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		
		
	}
}
