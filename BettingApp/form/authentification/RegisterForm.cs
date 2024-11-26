/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 04/11/2024
 * Heure: 12:16
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Windows.Forms;
using BettingApp.model;
using BettingApp.data.repository;
using BettingApp.utils.validation;



namespace BettingApp.form.authentification
{
	/// <summary>
	/// Description of RegisterForm.
	/// </summary>
	public partial class RegisterForm : Form
	{
		public RegisterForm()
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
		

		
		void InscriptionButtonClick(object sender, EventArgs e)
		{
			try {
        
				UserValidation validator = new UserValidation();

        
				if (!validator.ValidateLastName(registerLastnameTextBox.Text) ||
				    !validator.ValidateFirstName(registerFirstnameTextBox.Text) ||
				    !validator.ValidateUsername(registerUsernameTextBox.Text) ||
				    !validator.ValidatePassword(registerPasswordTextBox.Text)) {
					return; // Arrêter si une validation échoue
				}

				if (registerSexeComboBox.SelectedItem == null ||
				    !validator.ValidateGender(registerSexeComboBox.SelectedItem.ToString())) {
					return;
				}

        
				if (!validator.ValidateBirthDate(registerBirthdayDateTimePicker.Value) ||
				    !validator.ValidatePhone(registerPhoneTextBox.Text) ||
				    !validator.ValidateNifCin(registerNifCinTextBox.Text)) {
					return;
				}

       
				string userCode = Guid.NewGuid().ToString();

				User user = new User();
				user.Code = userCode;
				user.LastName = registerLastnameTextBox.Text;
				user.FirstName = registerFirstnameTextBox.Text;
				user.Gender = registerSexeComboBox.SelectedItem.ToString();
				user.BirthDate = registerBirthdayDateTimePicker.Value;
				user.Phone = registerPhoneTextBox.Text;
				user.Balance = 0;
				user.NifCin = registerNifCinTextBox.Text;
				user.Username = registerUsernameTextBox.Text;
				user.Password = registerPasswordTextBox.Text;
				user.CreatedAt = DateTime.UtcNow;
			

       
				var auth = new AuthenticationRepository();
				if (auth.Register(user)) {
					// Enregistrement réussi
					MessageBox.Show("Enregistrement réussi!!!",
						"Succès",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information);

					ClearForm(); 
					this.Hide();

            
					LoginForm loginForm = new LoginForm();
					loginForm.Show();
				} else {
           
					MessageBox.Show("Erreur: Nom d'utilisateur déjà utilisé!!!",
						"Erreur d'Enregistrement",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning);
				}
			} catch (Exception ex) {
				// Gérer les erreurs imprévues
				MessageBox.Show("Erreur: " + ex.Message,
					"Erreur de Validation",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}

		

		private void ClearForm()
		{
			
			registerLastnameTextBox.Clear();
			registerFirstnameTextBox.Clear();
			registerSexeComboBox.SelectedIndex = -1;
			registerBirthdayDateTimePicker.Value = DateTime.Now;
			registerPhoneTextBox.Clear();
			registerNifCinTextBox.Clear();
			registerUsernameTextBox.Clear();
			registerPasswordTextBox.Clear();
		}
		
		void LabelLoginClick(object sender, EventArgs e)
		{
			this.Hide();
			LoginForm loginForm = new LoginForm();
			loginForm.Show();
		}


	}
}
