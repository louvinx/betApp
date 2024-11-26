/*
 * Created by SharpDevelop.
 * User: 1
 * Date: 11/6/2024
 * Time: 7:59 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using BettingApp.data.repository;
using BettingApp.form.authentification;

namespace BettingApp.form.user
{
	/// <summary>
	/// Description of UserDashBoard.
	/// </summary>
	public partial class UserDashBoard : Form
	{
		public UserDashBoard()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.WindowState = FormWindowState.Maximized;
			var index = new DashboardUserIndexForm();
			index.TopLevel = false;
			index.Dock = DockStyle.Fill;
			this.ContainerUserPanel.Controls.Add(index);
			this.ContainerUserPanel.Tag = index;
			index.Show();
		}
		
		public void OpenChildForm(object FormChild)
		{
			if (this.ContainerUserPanel.Controls.Count > 0) {
				this.ContainerUserPanel.Controls.RemoveAt(0);
				var formChild = FormChild as Form;
				formChild.TopLevel = false;
				formChild.Dock = DockStyle.Fill;
				this.ContainerUserPanel.Controls.Add(formChild);
				this.ContainerUserPanel.Tag = formChild;
				formChild.Show();
			}
		}
		
		void DashboardbuttonClick(object sender, EventArgs e)
		{
			OpenChildForm(new DashboardUserIndexForm());
		}
		
		void MatchButtonClick(object sender, EventArgs e)
		{
			OpenChildForm(new UserMatchForm());
		}
		
		void BetButtonClick(object sender, EventArgs e)
		{
			OpenChildForm(new BetForm());
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
			OpenChildForm(new DashboardUserIndexForm());
		}
		
		void PictureBoxMatchClick(object sender, EventArgs e)
		{
			OpenChildForm(new UserMatchForm());
		}
		
		void PictureBoxBetClick(object sender, EventArgs e)
		{
			OpenChildForm(new BetForm());
		}
		
		void PictureBoxDisconnectClick(object sender, EventArgs e)
		{
			AuthenticationRepository authRepository = new AuthenticationRepository();
			if (AuthenticationRepository.authUser != null) {
				this.Hide();
				LoginForm loginForm = new LoginForm();
				loginForm.Show();
				authRepository.Logout();
			}
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
				matchButton.BackColor = settingColorDialog.Color;
				betButton.BackColor = settingColorDialog.Color;
				Dashboardbutton.BackColor = settingColorDialog.Color;
				buttonHistory.BackColor = settingColorDialog.Color;
				buttonDisconnect.BackColor = settingColorDialog.Color;
				settingButton.BackColor = settingColorDialog.Color;
			}
		}
		
		void PictureBoxsettingClick(object sender, EventArgs e)
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
				matchButton.BackColor = settingColorDialog.Color;
				betButton.BackColor = settingColorDialog.Color;
				Dashboardbutton.BackColor = settingColorDialog.Color;
				buttonHistory.BackColor = settingColorDialog.Color;
				buttonDisconnect.BackColor = settingColorDialog.Color;
				settingButton.BackColor = settingColorDialog.Color;
			}
		}
	
		void LabelUserClick(object sender, EventArgs e)
		{
			OpenChildForm(new UserAccountForm());
		}
		
		void ButtonHistoryClick(object sender, EventArgs e)
		{
			OpenChildForm(new HistoryForm());
		}
	
		
		
		

	}
}
