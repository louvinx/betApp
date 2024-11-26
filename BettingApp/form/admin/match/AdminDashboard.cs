/*
 * Created by SharpDevelop.
 * User: 1
 * Date: 11/5/2024
 * Time: 11:11 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using BettingApp.form.admin.user;
using BettingApp.form.admin.match;
using System.Drawing;
using BettingApp.data.repository;
using BettingApp.form.authentification;


namespace BettingApp.form.admin
{
	/// <summary>
	/// Description of AdminDashboard.
	/// </summary>
	public partial class AdminDashboard : Form
	{
		public AdminDashboard()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.WindowState = FormWindowState.Maximized;
			var index = new DashboardIndexForm();
			index.TopLevel = false;
			index.Dock = DockStyle.Fill;
			this.ContainerAdminPanel.Controls.Add(index);
			this.ContainerAdminPanel.Tag = index;
			index.Show();
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		public void OpenChildForm(object FormChild)
		{
			if (this.ContainerAdminPanel.Controls.Count > 0) {
				this.ContainerAdminPanel.Controls.RemoveAt(0);
				var formChild = FormChild as Form;
				formChild.TopLevel = false;
				formChild.Dock = DockStyle.Fill;
				this.ContainerAdminPanel.Controls.Add(formChild);
				this.ContainerAdminPanel.Tag = formChild;
				formChild.Show();
			}
		}
		

		
		
		void UserButtonClick(object sender, EventArgs e)
		{
			OpenChildForm(new UserForm());
		}
		

		
		void DashboardbuttonClick(object sender, EventArgs e)
		{
			OpenChildForm(new DashboardIndexForm());
		}
		
				
		void TeambuttonClick(object sender, EventArgs e)
		{
			OpenChildForm(new TeamForm());
		}
		
		
		void MatchButtonClick(object sender, EventArgs e)
		{
			OpenChildForm(new MatchForm());
		}
		
		

		
		void SettingButtonClick(object sender, EventArgs e)
		{
			DialogResult result = settingColorDialog.ShowDialog();
			if (result == DialogResult.OK) {
				if (settingColorDialog.Color == Color.White) {
					MessageBox.Show("Erreur: Couleur innaproprie pour la lisibilite!!!", 
						"Erreur", 
						MessageBoxButtons.OK, 
						MessageBoxIcon.Warning);
					return;
				}
				panel2.BackColor = settingColorDialog.Color;
				userButton.BackColor = settingColorDialog.Color;
				teambutton.BackColor = settingColorDialog.Color;
				matchButton.BackColor = settingColorDialog.Color;
				betButton.BackColor = settingColorDialog.Color;
				Dashboardbutton.BackColor = settingColorDialog.Color;
				buttonHistory.BackColor = settingColorDialog.Color;
				buttonDisconnect.BackColor = settingColorDialog.Color;
				settingButton.BackColor = settingColorDialog.Color;
			}

		}

		
			
		void MenuBurgerpictureBoxClick(object sender, EventArgs e)
		{
			if (rightPanel.Width > 50) {
				rightPanel.Width = 50;
				title.Text = "";
				title.ForeColor = Color.White;
			} else {
				rightPanel.Width = 210;
				title.Text = "PHOENIX";
				title.ForeColor = Color.White;
			}
		}
		void ButtonDisconnectClick(object sender, EventArgs e)
		{
	
			AuthenticationRepository authRepository = new AuthenticationRepository();
			if (AuthenticationRepository.authUser != null) {
				this.Hide();
				LoginForm loginForm = new LoginForm();
				loginForm.Show();
				authRepository.Logout();
			}
			
		}
		
		void PictureBoxDashboardClick(object sender, EventArgs e)
		{
			OpenChildForm(new DashboardIndexForm());
		}
		
		void PictureBoxUserClick(object sender, EventArgs e)
		{
			OpenChildForm(new UserForm());
		}
		
		void PictureBoxTeamClick(object sender, EventArgs e)
		{
			OpenChildForm(new TeamForm());
		}
		
		void PictureBoxMatchClick(object sender, EventArgs e)
		{
			OpenChildForm(new MatchForm());
		}
		
		void LabelUserClick(object sender, EventArgs e)
		{
			OpenChildForm(new UserAccountForm());
		}
		
		void BetButtonClick(object sender, EventArgs e)
		{
			OpenChildForm(new BetAdminForm());
		}
		
		void ButtonHistoryClick(object sender, EventArgs e)
		{
			OpenChildForm(new HistoryAdminForm());
		}
		
	}
}
