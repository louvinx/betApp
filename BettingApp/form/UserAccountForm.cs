/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 21/11/2024
 * Heure: 11:31
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using BettingApp.data.repository;
using BettingApp.model;
using BettingApp.form.user;

namespace BettingApp.form
{
	/// <summary>
	/// Description of UserAccountForm.
	/// </summary>
	public partial class UserAccountForm : Form
	{
		public UserAccountForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			User user = AuthenticationRepository.authUser;
			code.Text = "Code : " + user.Code;
			firstname.Text = "Prenom : " + user.FirstName;
			lastname.Text = "Nom : " + user.LastName;
			username.Text = "Nom utilisateur : " + user.Username;
			sexe.Text = "Sexe : " + user.Gender;
			phone.Text = "Telephone : " + user.Phone;
			balance.Text = "Balance : " + user.Balance.ToString("F2");
			nifCin.Text = "Nif/Cin : " + user.NifCin;
			role.Text = "Role : " + user.Role;
			status.Text = "Status: " + user.Status;
		}
		
		void ModifyButtonClick(object sender, EventArgs e)
		{
			ModifyInfoForm modifyInfoForm = new ModifyInfoForm();
			modifyInfoForm.Show();
		}
	}
}
