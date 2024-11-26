/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 04/11/2024
 * Heure: 11:39
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using BettingApp.data.repository;
using BettingApp.model;
using BettingApp.form.admin;
using BettingApp.form.user;

namespace BettingApp.form.authentification
{
	/// <summary>
	/// Description of Login.
	/// </summary>
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void CloseButtonClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void PasswordPictureBoxMouseEnter(object sender, EventArgs e)
		{
			loginPasswordTextBox.UseSystemPasswordChar = true;
		}
		
		
		void PasswordPictureBoxMouseDown(object sender, MouseEventArgs e)
		{
			loginPasswordTextBox.UseSystemPasswordChar = false;
		}
		

		
		void LoginButtonClick(object sender, EventArgs e)
		{
			try
			{
				
				if (string.IsNullOrEmpty(loginUsernameTextBox.Text) || string.IsNullOrEmpty(loginPasswordTextBox.Text))
				{
					MessageBox.Show("Erreur: Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
					
					return;
				}
				
				var auth = new AuthenticationRepository();
				User user = auth.Login(loginUsernameTextBox.Text, loginPasswordTextBox.Text);
				if(user != null){
					if(user.Role == "ADMIN"){
						this.Hide();
						var adminForm = new AdminDashboard();
						adminForm.Show();
					}else{
						this.Hide();
						var userForm = new UserDashBoard();
						userForm.Show();
					}

				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message,"Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
	}
}
