/*
 * Created by SharpDevelop.
 * User: 1
 * Date: 11/7/2024
 * Time: 7:21 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using BettingApp.data.repository;
using BettingApp.model;
using BettingApp.utils.validation;
using System.IO;

namespace BettingApp.form.admin
{
	/// <summary>
	/// Description of TeamForm.
	/// </summary>
	public partial class TeamForm : Form
	{
		TeamValidation teamValidation = new TeamValidation();
		TeamRepository teamRepository = new TeamRepository();
		UtilsRepository utilsRepository = new UtilsRepository();
		public TeamForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			teamRepository.LoadTeams(listTeamPanel);
		}

		void AddTeamButtonClick(object sender, EventArgs e)
		{
			
			var team = new Team();
			if (teamValidation.ValidateNameTeam(nameTeamTextBox.Text) && teamValidation.ValidateCountry(countryTeamComboBox.SelectedItem.ToString()) && teamValidation.ValidateType(typeTeamComboBox.SelectedItem.ToString())) {
				team.TeamName = nameTeamTextBox.Text;
				team.Country = countryTeamComboBox.SelectedItem.ToString();
				team.TypeTeam = typeTeamComboBox.SelectedItem.ToString();
				if (!utilsRepository.CheckUnique("Teams", "TeamName", nameTeamTextBox.Text)) {
					return;
				}
				string logoPath = SaveLogo(nameTeamTextBox.Text);
				if (logoPath == null) {
					MessageBox.Show("Erreur lors de l'enregistrement du logo, choisir un logo!!!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				team.LogoPath = logoPath;
				
				if (teamRepository.AddTeam(team)) {
					MessageBox.Show("Équipe enregistrée avec succès !", "succès ", MessageBoxButtons.OK, MessageBoxIcon.Information);
					teamRepository.LoadTeams(listTeamPanel);
					Clear();
				} else {
					MessageBox.Show("Erreur lors de l'enregistrement de l'équipe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					
				}
			}

			
		}
		
		
		void UploadImageButtonClick(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Images Files (*.jpg; *.jpeg; *.png) | *.jpg; *.jpeg; *.png";
			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				logoPictureBox.Image = new Bitmap(openFileDialog.FileName);
			}
			addTeamButton.Visible = true;
		}
		
		private string SaveLogo(string nameLogo)
		{

			if (logoPictureBox.Image == null) {
				return null;
			}

			string folderPath = @"C:\LogosTeams"; 

			if (!Directory.Exists(folderPath)) {
				Directory.CreateDirectory(folderPath);
			}

			string fileName = "logo_" + nameLogo + ".png";
			string filePath = Path.Combine(folderPath, fileName);

			if (!utilsRepository.CheckUnique("Teams", "LogoPath", filePath)) {
				return null; 
			}

			try {
				logoPictureBox.Image.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
			} catch (Exception ex) {
				Console.WriteLine("Error saving logo: " + ex.Message);
				return null;
			}
			return filePath;
		}

		
		

		private void Clear()
		{
			nameTeamTextBox.Clear();
			logoPictureBox.Image = null;
			
		}

	}
}
