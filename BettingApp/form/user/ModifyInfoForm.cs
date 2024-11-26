/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 21/11/2024
 * Heure: 11:53
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using BettingApp.model;
using BettingApp.data.repository;
using BettingApp.utils;
using BettingApp.utils.validation;

namespace BettingApp.form.user
{
	public partial class ModifyInfoForm : Form
	{
		public UserRepository userRepository = new UserRepository();
		public User userModify = new User();
		private bool isAddingNewPassword = false;

		public ModifyInfoForm()
		{
			InitializeComponent();

			User user = AuthenticationRepository.authUser;
			modifyLastnameTextBox.Text = user.LastName;
			modifyFirstnameTextBox.Text = user.FirstName;
			modifyRoleComboBox.SelectedItem = user.Role;
			modifySexeComboBox.SelectedItem = user.Gender;
			modifyBirthdayDateTimePicker.Value = user.BirthDate;
			modifyPhoneTextBox.Text = user.Phone;
			modifyNifCinTextBox.Text = user.NifCin;
			modifyUsernameTextBox.Text = user.Username;
		}

		void ModifyButtonClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(passwordTextBox.Text)) {
				MessageBox.Show("Erreur : Le champ de confirmation du mot de passe est vide.", "Erreur",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (isAddingNewPassword && string.IsNullOrEmpty(textBoxNewPassword.Text)) {
				MessageBox.Show("Erreur : Le champ du nouveau mot de passe est vide.", "Erreur",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			UserValidation validator = new UserValidation();

			if (!validator.ValidateLastName(modifyLastnameTextBox.Text) ||
			    !validator.ValidateFirstName(modifyFirstnameTextBox.Text) ||
			    !validator.ValidateUsername(modifyUsernameTextBox.Text) ||
			    !validator.ValidatePassword(passwordTextBox.Text)) {
				MessageBox.Show("Erreur : Un ou plusieurs champs sont invalides.", "Erreur",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (modifySexeComboBox.SelectedItem == null || !validator.ValidateGender(modifySexeComboBox.SelectedItem.ToString())) {
				MessageBox.Show("Erreur : Le champ du genre est invalide.", "Erreur",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (modifyRoleComboBox.SelectedItem == null || !validator.ValidateRole(modifyRoleComboBox.SelectedItem.ToString())) {
				MessageBox.Show("Erreur : Le champ du rôle est invalide.", "Erreur",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!validator.ValidateBirthDate(modifyBirthdayDateTimePicker.Value) ||
			    !validator.ValidatePhone(modifyPhoneTextBox.Text) ||
			    !validator.ValidateNifCin(modifyNifCinTextBox.Text)) {
				MessageBox.Show("Erreur : Un ou plusieurs champs sont invalides.", "Erreur",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!PasswordHelper.VerifyPassword(passwordTextBox.Text, AuthenticationRepository.authUser.Password)) {
				MessageBox.Show("Erreur : Le mot de passe de confirmation ne correspond pas.", "Erreur",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			userModify.Code = AuthenticationRepository.authUser.Code;
			userModify.LastName = modifyLastnameTextBox.Text;
			userModify.FirstName = modifyFirstnameTextBox.Text;
			userModify.Role = modifyRoleComboBox.SelectedItem.ToString();
			userModify.Gender = modifySexeComboBox.SelectedItem.ToString();
			userModify.BirthDate = modifyBirthdayDateTimePicker.Value;
			userModify.Phone = modifyPhoneTextBox.Text;
			userModify.NifCin = modifyNifCinTextBox.Text;
			userModify.Username = modifyUsernameTextBox.Text;
			

			try {
				if (userModify.Code == "ADMIN01" && userModify.Role == "USER") {
					MessageBox.Show("Erreur : On ne peut pas modifier le rôle de l'administrateur principal!!!", "Erreur",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				
				
				var result = userRepository.UpdateUser(userModify);
				if (result) {
					if (isAddingNewPassword) {
						userRepository.ModifyPassworUser(userModify, textBoxNewPassword.Text);
					}

					MessageBox.Show("Information modifiée avec succès.", "Succès!!!",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Hide();
				} else {
					MessageBox.Show("Erreur lors de la modification!!!", "Erreur",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					this.Hide();
				}
			} catch (Exception ex) {
				MessageBox.Show("Erreur!!! " + ex.Message, "Erreur",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Hide();
			}
		}

		void ButtonNextClick(object sender, EventArgs e)
		{
			UserValidation validator = new UserValidation();
			if (!validator.ValidateLastName(modifyLastnameTextBox.Text) ||
			    !validator.ValidateFirstName(modifyFirstnameTextBox.Text) ||
			    !validator.ValidateUsername(modifyUsernameTextBox.Text) ||
			    !validator.ValidatePhone(modifyPhoneTextBox.Text) ||
			    !validator.ValidateNifCin(modifyNifCinTextBox.Text)) {
				MessageBox.Show("Erreur : Un ou plusieurs champs sont invalides.", "Erreur",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (modifyRoleComboBox.SelectedItem == null) {
				MessageBox.Show("Erreur: Veuillez sélectionner un rôle.", "Erreur de Validation",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (modifySexeComboBox.SelectedItem == null) {
				MessageBox.Show("Erreur: Veuillez sélectionner un sexe.", "Erreur de Validation",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			panelTwo.Visible = true;
			buttonNext.Visible = false;
			modifyButton.Visible = true;
		}

		void ButtonNewPasswordClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(passwordTextBox.Text)) {
				MessageBox.Show("Erreur : Le champ de confirmation du mot de passe est vide.", "Erreur",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (PasswordHelper.VerifyPassword(passwordTextBox.Text, AuthenticationRepository.authUser.Password)) {
				panelChangePassword.Visible = true;
				isAddingNewPassword = true;
			} else {
				MessageBox.Show("Erreur : Le mot de passe de confirmation ne correspond pas.", "Erreur",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}

