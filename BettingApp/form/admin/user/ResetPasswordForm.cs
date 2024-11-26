﻿/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 18/11/2024
 * Heure: 18:34
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using BettingApp.data.repository;
using BettingApp.model;
using BettingApp.utils.validation;

namespace BettingApp.form.admin.user
{
	/// <summary>
	/// Description of ResetPasswordForm.
	/// </summary>
	public partial class ResetPasswordForm : Form
	{
		
		UserForm userForm = new UserForm();
		User userModify = new User();
		public UserRepository userRepository = new UserRepository();
		public ResetPasswordForm(User userModifyStatus)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			if (string.IsNullOrEmpty(userModifyStatus.Code)) {
				MessageBox.Show("Veuillez sélectionner une ligne valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			code.Text = "Code : " + userModifyStatus.Code;
			firstname.Text = "Prenom : " + userModifyStatus.FirstName;
			lastname.Text = "Nom : " + userModifyStatus.LastName;
			username.Text = "Nom utilisateur : " + userModifyStatus.Username;
			sexe.Text = "Sexe : " + userModifyStatus.Gender;
			phone.Text = "Telephone : " + userModifyStatus.Phone;
			balance.Text = "Balance : " + userModifyStatus.Balance.ToString("F2");
			nifCin.Text = "Nif/Cin : " + userModifyStatus.NifCin;
			role.Text = "Role : " + userModifyStatus.Role;
			status.Text = "Status: " + userModifyStatus.Status;
			userModify = userModifyStatus;
		}
		
		
		void StatusModifyButtonClick(object sender, EventArgs e)
		{
			var password = passwordTextBox.Text;  
			UserValidation validator = new UserValidation();
			if (!validator.ValidatePassword(password))
				return;
			
			var result = userRepository.ModifyPassworUser(userModify, password);
			
			if (result) {
				MessageBox.Show("Opération réussie !!!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
				userForm.LoadUser();
				this.Hide();
			} else {
				MessageBox.Show("Erreur !!!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		

	}
}
