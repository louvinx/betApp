/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 18/11/2024
 * Heure: 18:34
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
namespace BettingApp.form.admin.user
{
	partial class ResetPasswordForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label status;
		private System.Windows.Forms.Button statusModifyButton;
		private System.Windows.Forms.Label sexe;
		private System.Windows.Forms.Label balance;
		private System.Windows.Forms.Label phone;
		private System.Windows.Forms.Label username;
		private System.Windows.Forms.Label role;
		private System.Windows.Forms.Label nifCin;
		private System.Windows.Forms.Label lastname;
		private System.Windows.Forms.Label firstname;
		private System.Windows.Forms.Label code;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Panel inputEmailPanel;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.PictureBox personPictureBox;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPasswordForm));
			this.status = new System.Windows.Forms.Label();
			this.statusModifyButton = new System.Windows.Forms.Button();
			this.sexe = new System.Windows.Forms.Label();
			this.balance = new System.Windows.Forms.Label();
			this.phone = new System.Windows.Forms.Label();
			this.username = new System.Windows.Forms.Label();
			this.role = new System.Windows.Forms.Label();
			this.nifCin = new System.Windows.Forms.Label();
			this.lastname = new System.Windows.Forms.Label();
			this.firstname = new System.Windows.Forms.Label();
			this.code = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.inputEmailPanel = new System.Windows.Forms.Panel();
			this.label11 = new System.Windows.Forms.Label();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.personPictureBox = new System.Windows.Forms.PictureBox();
			this.inputEmailPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.personPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// status
			// 
			this.status.Location = new System.Drawing.Point(236, 206);
			this.status.Name = "status";
			this.status.Size = new System.Drawing.Size(203, 23);
			this.status.TabIndex = 56;
			this.status.Text = "label22";
			// 
			// statusModifyButton
			// 
			this.statusModifyButton.BackColor = System.Drawing.Color.SteelBlue;
			this.statusModifyButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.statusModifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.statusModifyButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statusModifyButton.ForeColor = System.Drawing.Color.White;
			this.statusModifyButton.Location = new System.Drawing.Point(9, 313);
			this.statusModifyButton.Name = "statusModifyButton";
			this.statusModifyButton.Size = new System.Drawing.Size(194, 40);
			this.statusModifyButton.TabIndex = 54;
			this.statusModifyButton.Text = "Modifier Mot de passe";
			this.statusModifyButton.UseVisualStyleBackColor = false;
			this.statusModifyButton.Click += new System.EventHandler(this.StatusModifyButtonClick);
			// 
			// sexe
			// 
			this.sexe.Location = new System.Drawing.Point(236, 165);
			this.sexe.Name = "sexe";
			this.sexe.Size = new System.Drawing.Size(203, 23);
			this.sexe.TabIndex = 53;
			this.sexe.Text = "label22";
			// 
			// balance
			// 
			this.balance.Location = new System.Drawing.Point(233, 128);
			this.balance.Name = "balance";
			this.balance.Size = new System.Drawing.Size(206, 23);
			this.balance.TabIndex = 52;
			this.balance.Text = "label22";
			// 
			// phone
			// 
			this.phone.Location = new System.Drawing.Point(236, 93);
			this.phone.Name = "phone";
			this.phone.Size = new System.Drawing.Size(203, 23);
			this.phone.TabIndex = 51;
			this.phone.Text = "label22";
			// 
			// username
			// 
			this.username.Location = new System.Drawing.Point(236, 54);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(203, 23);
			this.username.TabIndex = 50;
			this.username.Text = "label22";
			// 
			// role
			// 
			this.role.Location = new System.Drawing.Point(12, 206);
			this.role.Name = "role";
			this.role.Size = new System.Drawing.Size(191, 23);
			this.role.TabIndex = 49;
			this.role.Text = "label22";
			// 
			// nifCin
			// 
			this.nifCin.Location = new System.Drawing.Point(12, 165);
			this.nifCin.Name = "nifCin";
			this.nifCin.Size = new System.Drawing.Size(191, 23);
			this.nifCin.TabIndex = 48;
			this.nifCin.Text = "label22";
			// 
			// lastname
			// 
			this.lastname.Location = new System.Drawing.Point(12, 128);
			this.lastname.Name = "lastname";
			this.lastname.Size = new System.Drawing.Size(191, 23);
			this.lastname.TabIndex = 47;
			this.lastname.Text = "label22";
			// 
			// firstname
			// 
			this.firstname.Location = new System.Drawing.Point(12, 93);
			this.firstname.Name = "firstname";
			this.firstname.Size = new System.Drawing.Size(191, 23);
			this.firstname.TabIndex = 46;
			this.firstname.Text = "label22";
			// 
			// code
			// 
			this.code.Location = new System.Drawing.Point(12, 54);
			this.code.Name = "code";
			this.code.Size = new System.Drawing.Size(191, 23);
			this.code.TabIndex = 45;
			this.code.Text = "label22";
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.SteelBlue;
			this.label14.Location = new System.Drawing.Point(12, -1);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(215, 33);
			this.label14.TabIndex = 44;
			this.label14.Text = "Infos utilisateur";
			// 
			// inputEmailPanel
			// 
			this.inputEmailPanel.BackColor = System.Drawing.Color.White;
			this.inputEmailPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.inputEmailPanel.Controls.Add(this.label11);
			this.inputEmailPanel.Controls.Add(this.passwordTextBox);
			this.inputEmailPanel.Controls.Add(this.personPictureBox);
			this.inputEmailPanel.Location = new System.Drawing.Point(12, 247);
			this.inputEmailPanel.Name = "inputEmailPanel";
			this.inputEmailPanel.Size = new System.Drawing.Size(359, 60);
			this.inputEmailPanel.TabIndex = 57;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(15, 4);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 23);
			this.label11.TabIndex = 2;
			this.label11.Text = "Mot de passe :";
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.passwordTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordTextBox.ForeColor = System.Drawing.Color.Black;
			this.passwordTextBox.Location = new System.Drawing.Point(46, 30);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(289, 22);
			this.passwordTextBox.TabIndex = 1;
			// 
			// personPictureBox
			// 
			this.personPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("personPictureBox.Image")));
			this.personPictureBox.Location = new System.Drawing.Point(15, 30);
			this.personPictureBox.Name = "personPictureBox";
			this.personPictureBox.Size = new System.Drawing.Size(24, 20);
			this.personPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.personPictureBox.TabIndex = 0;
			this.personPictureBox.TabStop = false;
			// 
			// ResetPasswordForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(445, 437);
			this.Controls.Add(this.inputEmailPanel);
			this.Controls.Add(this.status);
			this.Controls.Add(this.statusModifyButton);
			this.Controls.Add(this.sexe);
			this.Controls.Add(this.balance);
			this.Controls.Add(this.phone);
			this.Controls.Add(this.username);
			this.Controls.Add(this.role);
			this.Controls.Add(this.nifCin);
			this.Controls.Add(this.lastname);
			this.Controls.Add(this.firstname);
			this.Controls.Add(this.code);
			this.Controls.Add(this.label14);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "ResetPasswordForm";
			this.Text = "ResetPasswordForm";
			this.inputEmailPanel.ResumeLayout(false);
			this.inputEmailPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.personPictureBox)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
