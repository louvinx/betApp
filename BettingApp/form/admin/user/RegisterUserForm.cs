/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 18/11/2024
 * Heure: 15:45
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using BettingApp.model;
using BettingApp.data.repository;
using BettingApp.utils.validation;

namespace BettingApp.form.admin.user
{
	/// <summary>
	/// Description of RegisterUserForm.
	/// </summary>
	public partial class RegisterUserForm : Form
	{
		UserForm userForm = new UserForm();
		public UserRepository userRepository = new UserRepository();
		public RegisterUserForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void InscrireButtonClick(object sender, EventArgs e)
		{
			try {
				
				UserValidation validator = new UserValidation();

				if (!validator.ValidateLastName(lastnameTextBox.Text) ||
				    !validator.ValidateFirstName(firstnameTextBox.Text) ||
				    !validator.ValidateUsername(usernameTextBox.Text) ||
				    !validator.ValidatePassword(passwordTextBox.Text)) {
					return;
				}

				
				if (sexeComboBox.SelectedItem == null || !validator.ValidateGender(sexeComboBox.SelectedItem.ToString())) {
					return;
				}

				
				if (roleComboBox.SelectedItem == null || !validator.ValidateRole(roleComboBox.SelectedItem.ToString())) {
					return;
				}

				
				if (!validator.ValidateBirthDate(birthdayDateTimePicker.Value) ||
				    !validator.ValidatePhone(phoneTextBox.Text) ||
				    !validator.ValidateNifCin(nifCinTextBox.Text)) {
					return;
				}

				
				string userCode = Guid.NewGuid().ToString();

				
				User user = new User {
					Code = userCode,
					LastName = lastnameTextBox.Text,
					FirstName = firstnameTextBox.Text,
					Gender = sexeComboBox.SelectedItem.ToString(),
					Role = roleComboBox.SelectedItem.ToString(),
					BirthDate = birthdayDateTimePicker.Value,
					Phone = phoneTextBox.Text,
					NifCin = nifCinTextBox.Text,
					Username = usernameTextBox.Text,
					Password = passwordTextBox.Text,
					Balance = 0,
					CreatedAt = DateTime.UtcNow
				};

				var auth = new AuthenticationRepository();

				
				if (auth.Register(user)) {
					userForm.LoadUser();
					MessageBox.Show("Enregistrement réussi!!!",
						"Succès",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information);
					ClearForm();
					this.Hide();
				} else {
					MessageBox.Show("Erreur: Nom d'utilisateur déjà utilisé!!!",
						"Erreur d'Enregistrement",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning);
				}
			} catch (Exception ex) {
				MessageBox.Show("Erreur:" + ex.Message,
					"Erreur de Validation",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				
			}
		}



		
		private void ClearForm()
		{
			
			lastnameTextBox.Clear();
			firstnameTextBox.Clear();
			sexeComboBox.SelectedIndex = -1;
			birthdayDateTimePicker.Value = DateTime.Now;
			phoneTextBox.Clear();
			nifCinTextBox.Clear();
			usernameTextBox.Clear();
			passwordTextBox.Clear();
		}

	}
}
