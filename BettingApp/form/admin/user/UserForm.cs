/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 18/11/2024
 * Heure: 20:44
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */

using System;
using System.Data;
using System.Windows.Forms;
using BettingApp.model;
using BettingApp.data.repository;
using BettingApp.utils;
using BettingApp.utils.validation;
using System.Drawing;



namespace BettingApp.form.admin.user
{
	/// <summary>
	/// Description of UserForm.
	/// </summary>
	public partial class UserForm : Form
	{
		public UserRepository userRepository = new UserRepository();
		public User userModify = new User();
		public User userModifyStatus = new User();
		public User userRecharge = null;
		
		public UserForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			
			var style = new StyleForm();
			style.StyleDataGridView(usersDataGridView);
			userRepository.LoadUserAccounts(usersDataGridView);
			
			userTabControl.BackColor = Color.White;
			foreach (TabPage tabPage in userTabControl.TabPages) {
				tabPage.BackColor = Color.White;
				
			}

		}
	
		
		public void LoadUser()
		{
			userRepository.LoadUserAccounts(usersDataGridView);
		}
	
		
		void SearchButtonClick(object sender, EventArgs e)
		{
			
			if (string.IsNullOrEmpty(modifySearchTextBox.Text)) {
				MessageBox.Show("Erreur: Veuillez remplir le champs de recherche.",
					"Champs vide",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}
			
			
			userModify = userRepository.GetUser(modifySearchTextBox.Text);
			if (userModify != null) {
				infoUserPanel.Visible = true;
				userNotFoundLabel.Visible = false;
				modifyLastnameTextBox.Text = userModify.LastName;
				modifyFirstnameTextBox.Text = userModify.FirstName;
				modifyRoleComboBox.SelectedItem = userModify.Role;
				modifySexeComboBox.SelectedItem = userModify.Gender;
				modifyBirthdayDateTimePicker.Value = userModify.BirthDate;
				modifyPhoneTextBox.Text = userModify.Phone;
				modifyNifCinTextBox.Text = userModify.NifCin;
				modifyUsernameTextBox.Text = userModify.Username;
			} else {
				infoUserPanel.Visible = false;
				userNotFoundLabel.Visible = true;
			}
			
		}
		
		
		
		
		void ModifyButtonClick(object sender, EventArgs e)
		{
			UserValidation validator = new UserValidation();

			
			if (!validator.ValidateLastName(modifyLastnameTextBox.Text))
				return;
			if (!validator.ValidateFirstName(modifyFirstnameTextBox.Text))
				return;
			if (!validator.ValidateUsername(modifyUsernameTextBox.Text))
				return;
			if (!validator.ValidatePhone(modifyPhoneTextBox.Text))
				return;
			if (!validator.ValidateNifCin(modifyNifCinTextBox.Text))
				return;
			
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

			
			userModify.LastName = modifyLastnameTextBox.Text;
			userModify.FirstName = modifyFirstnameTextBox.Text;
			userModify.Role = modifyRoleComboBox.SelectedItem.ToString();
			userModify.Gender = modifySexeComboBox.SelectedItem.ToString();
			userModify.BirthDate = modifyBirthdayDateTimePicker.Value;
			userModify.Phone = modifyPhoneTextBox.Text;
			userModify.NifCin = modifyNifCinTextBox.Text;
			userModify.Username = modifyUsernameTextBox.Text;
			try {
				var result = userRepository.UpdateUser(userModify);
				if (result) {
					MessageBox.Show("Modification réussi!!!", "Succes",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					userRepository.LoadUserAccounts(usersDataGridView);
				} else {
					MessageBox.Show("Erreur!!!", "Erreur",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			} catch (Exception ex) {
				MessageBox.Show("Erreur!!! " + ex.Message, "Erreur",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}
		
		
		
		void SearchRechargeButtonClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(searchRechargeTextBox.Text)) {
				MessageBox.Show("Erreur: Veuillez remplir le champs de recherche.",
					"Champs vide",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}
			
			userRecharge = userRepository.GetUser(searchRechargeTextBox.Text);
			if (userRecharge != null) {
				infoUserRechargePanel.Visible = true;
				userNotFoundRechargeLabel.Visible = false;
				codeRechargeLabel.Text = "Code : " + userRecharge.Code;
				usernameRechargeLabel.Text = "Nom utilisateur : " + userRecharge.Username;
			} else {
				infoUserRechargePanel.Visible = false;
				userNotFoundRechargeLabel.Visible = true;
			}
		}
		
		
		
		
		void RechargeButtonClick(object sender, EventArgs e)
		{
			// Vérifie si le champ du montant est vide
			if (string.IsNullOrEmpty(rechargeTextBox.Text)) {
				MessageBox.Show(
					"Erreur: Veuillez entrer le montant.",
					"Montant manquant",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				return;
			}

			// Tentative de conversion du montant avec gestion des erreurs si l'entrée est invalide
			decimal amount;
			try {
				amount = Convert.ToDecimal(rechargeTextBox.Text);
				if (amount <= 0) {
					MessageBox.Show(
						"Erreur: Le montant doit être un nombre positif.",
						"Montant invalide",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error
					);
					return;
				}
			} catch (FormatException) {
				MessageBox.Show(
					"Erreur: Le montant saisi est invalide. Veuillez entrer un nombre valide.",
					"Erreur de format",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
				return;
			}

			// Vérifie si un utilisateur est sélectionné pour la recharge
			if (userRecharge == null) {
				MessageBox.Show(
					"Erreur: Aucun utilisateur sélectionné pour la recharge.",
					"Utilisateur non trouvé",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				return;
			}

			// Effectue la recharge du compte de l'utilisateur
			var result = userRepository.RechargeAccount(userRecharge, amount);
			if (result) {
				MessageBox.Show(
					"Le compte de l'utilisateur " + userRecharge.Username + " a été rechargé de " + amount + " gourdes.",
					"Recharge réussie",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				);
				userRepository.LoadUserAccounts(usersDataGridView); // Recharge la liste des utilisateurs
			} else {
				MessageBox.Show(
					"Erreur lors de la recharge. Veuillez réessayer.",
					"Erreur",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
		}


		
		void ButtonAddUserClick(object sender, EventArgs e)
		{
			var registerUserForm = new RegisterUserForm();
			registerUserForm.Show();
		}
		
		
		void ButtonModifyClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(userModifyStatus.Code)) {
				MessageBox.Show("Veuillez sélectionner une ligne valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			ChangeStatusUserForm change = new ChangeStatusUserForm(userModifyStatus);
			change.Show();
		}
		
		
		void UsersDataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
		{
			userModifyStatus = new User();
			// Vérifie qu'une seule ligne est sélectionnée
			if (usersDataGridView.SelectedRows.Count == 1) {
				// Accède à la ligne sélectionnée
				DataGridViewRow selectedRow = usersDataGridView.SelectedRows[0];
				if (string.IsNullOrEmpty(selectedRow.Cells["Code"].Value.ToString())) {
					MessageBox.Show("Veuillez sélectionner une ligne valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				userModifyStatus.Code = selectedRow.Cells["Code"].Value.ToString();
				userModifyStatus.FirstName = selectedRow.Cells["FirstName"].Value.ToString();
				userModifyStatus.LastName = selectedRow.Cells["LastName"].Value.ToString();
				userModifyStatus.Username = selectedRow.Cells["Username"].Value.ToString();
				userModifyStatus.Gender = selectedRow.Cells["Gender"].Value.ToString();
				userModifyStatus.Phone = selectedRow.Cells["Phone"].Value.ToString();
				userModifyStatus.Balance = decimal.Parse(selectedRow.Cells["Balance"].Value.ToString());
				userModifyStatus.NifCin = selectedRow.Cells["NifCin"].Value.ToString();
				userModifyStatus.Role = selectedRow.Cells["Role"].Value.ToString();
				userModifyStatus.Status = selectedRow.Cells["Status"].Value.ToString();

			} else if (usersDataGridView.SelectedRows.Count > 1) {
				MessageBox.Show("Veuillez sélectionner une seule ligne.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				usersDataGridView.ClearSelection();
			}
		}
		
		
		void TextBoxSearchKeyPress(object sender, KeyPressEventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxSearch.Text)) {
				(usersDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
			} else {
				string filterExpression = "Code LIKE '%" + textBoxSearch.Text + "%' OR " +
				                          "FirstName LIKE '%" + textBoxSearch.Text + "%' OR " +
				                          "LastName LIKE '%" + textBoxSearch.Text + "%' OR " +
				                          "Username LIKE '%" + textBoxSearch.Text + "%'";

				(usersDataGridView.DataSource as DataTable).DefaultView.RowFilter = filterExpression;
			}
		}
		
		
		void ButtonResetClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(userModifyStatus.Code)) {
				MessageBox.Show("Veuillez sélectionner une ligne valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			ResetPasswordForm change = new ResetPasswordForm(userModifyStatus);
			change.Show();
		}
		void InfoUserPanelPaint(object sender, PaintEventArgs e)
		{
	
		}
		void InfoUserRechargePanelPaint(object sender, PaintEventArgs e)
		{
	
		}


	}
}

