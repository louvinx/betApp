/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 18/11/2024
 * Heure: 15:57
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
namespace BettingApp.form.admin.user
{
	partial class ChangeStatusUserForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel24;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Panel infoUserDeletePanel;
		private System.Windows.Forms.Label status;
		private System.Windows.Forms.Panel panel28;
		private System.Windows.Forms.ComboBox statusModifyUserComboBox;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.PictureBox pictureBox22;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeStatusUserForm));
			this.panel24 = new System.Windows.Forms.Panel();
			this.label24 = new System.Windows.Forms.Label();
			this.infoUserDeletePanel = new System.Windows.Forms.Panel();
			this.status = new System.Windows.Forms.Label();
			this.panel28 = new System.Windows.Forms.Panel();
			this.statusModifyUserComboBox = new System.Windows.Forms.ComboBox();
			this.label26 = new System.Windows.Forms.Label();
			this.pictureBox22 = new System.Windows.Forms.PictureBox();
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
			this.panel24.SuspendLayout();
			this.infoUserDeletePanel.SuspendLayout();
			this.panel28.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
			this.SuspendLayout();
			// 
			// panel24
			// 
			this.panel24.BackColor = System.Drawing.Color.White;
			this.panel24.Controls.Add(this.label24);
			this.panel24.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel24.Location = new System.Drawing.Point(0, 0);
			this.panel24.Name = "panel24";
			this.panel24.Size = new System.Drawing.Size(445, 57);
			this.panel24.TabIndex = 10;
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.Color.Transparent;
			this.label24.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.ForeColor = System.Drawing.Color.SteelBlue;
			this.label24.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.label24.Location = new System.Drawing.Point(6, 6);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(393, 37);
			this.label24.TabIndex = 44;
			this.label24.Text = "Modifier status utilisateur";
			// 
			// infoUserDeletePanel
			// 
			this.infoUserDeletePanel.BackColor = System.Drawing.Color.White;
			this.infoUserDeletePanel.Controls.Add(this.status);
			this.infoUserDeletePanel.Controls.Add(this.panel28);
			this.infoUserDeletePanel.Controls.Add(this.statusModifyButton);
			this.infoUserDeletePanel.Controls.Add(this.sexe);
			this.infoUserDeletePanel.Controls.Add(this.balance);
			this.infoUserDeletePanel.Controls.Add(this.phone);
			this.infoUserDeletePanel.Controls.Add(this.username);
			this.infoUserDeletePanel.Controls.Add(this.role);
			this.infoUserDeletePanel.Controls.Add(this.nifCin);
			this.infoUserDeletePanel.Controls.Add(this.lastname);
			this.infoUserDeletePanel.Controls.Add(this.firstname);
			this.infoUserDeletePanel.Controls.Add(this.code);
			this.infoUserDeletePanel.Controls.Add(this.label14);
			this.infoUserDeletePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.infoUserDeletePanel.Location = new System.Drawing.Point(0, 57);
			this.infoUserDeletePanel.Name = "infoUserDeletePanel";
			this.infoUserDeletePanel.Size = new System.Drawing.Size(445, 380);
			this.infoUserDeletePanel.TabIndex = 11;
			// 
			// status
			// 
			this.status.Location = new System.Drawing.Point(230, 217);
			this.status.Name = "status";
			this.status.Size = new System.Drawing.Size(203, 23);
			this.status.TabIndex = 43;
			this.status.Text = "label22";
			// 
			// panel28
			// 
			this.panel28.BackColor = System.Drawing.Color.White;
			this.panel28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel28.Controls.Add(this.statusModifyUserComboBox);
			this.panel28.Controls.Add(this.label26);
			this.panel28.Controls.Add(this.pictureBox22);
			this.panel28.Location = new System.Drawing.Point(6, 258);
			this.panel28.Name = "panel28";
			this.panel28.Size = new System.Drawing.Size(359, 60);
			this.panel28.TabIndex = 42;
			// 
			// statusModifyUserComboBox
			// 
			this.statusModifyUserComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.statusModifyUserComboBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statusModifyUserComboBox.FormattingEnabled = true;
			this.statusModifyUserComboBox.Items.AddRange(new object[] {
			"A",
			"S",
			"F"});
			this.statusModifyUserComboBox.Location = new System.Drawing.Point(46, 25);
			this.statusModifyUserComboBox.Name = "statusModifyUserComboBox";
			this.statusModifyUserComboBox.Size = new System.Drawing.Size(290, 25);
			this.statusModifyUserComboBox.TabIndex = 11;
			// 
			// label26
			// 
			this.label26.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label26.Location = new System.Drawing.Point(12, 4);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(130, 23);
			this.label26.TabIndex = 2;
			this.label26.Text = "Status :";
			// 
			// pictureBox22
			// 
			this.pictureBox22.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox22.Image")));
			this.pictureBox22.Location = new System.Drawing.Point(15, 30);
			this.pictureBox22.Name = "pictureBox22";
			this.pictureBox22.Size = new System.Drawing.Size(22, 21);
			this.pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox22.TabIndex = 0;
			this.pictureBox22.TabStop = false;
			// 
			// statusModifyButton
			// 
			this.statusModifyButton.BackColor = System.Drawing.Color.SteelBlue;
			this.statusModifyButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.statusModifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.statusModifyButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statusModifyButton.ForeColor = System.Drawing.Color.White;
			this.statusModifyButton.Location = new System.Drawing.Point(3, 324);
			this.statusModifyButton.Name = "statusModifyButton";
			this.statusModifyButton.Size = new System.Drawing.Size(155, 40);
			this.statusModifyButton.TabIndex = 10;
			this.statusModifyButton.Text = "Modifier status";
			this.statusModifyButton.UseVisualStyleBackColor = false;
			this.statusModifyButton.Click += new System.EventHandler(this.StatusModifyButtonClick);
			// 
			// sexe
			// 
			this.sexe.Location = new System.Drawing.Point(230, 176);
			this.sexe.Name = "sexe";
			this.sexe.Size = new System.Drawing.Size(203, 23);
			this.sexe.TabIndex = 9;
			this.sexe.Text = "label22";
			// 
			// balance
			// 
			this.balance.Location = new System.Drawing.Point(227, 139);
			this.balance.Name = "balance";
			this.balance.Size = new System.Drawing.Size(206, 23);
			this.balance.TabIndex = 8;
			this.balance.Text = "label22";
			// 
			// phone
			// 
			this.phone.Location = new System.Drawing.Point(230, 104);
			this.phone.Name = "phone";
			this.phone.Size = new System.Drawing.Size(203, 23);
			this.phone.TabIndex = 7;
			this.phone.Text = "label22";
			// 
			// username
			// 
			this.username.Location = new System.Drawing.Point(230, 65);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(203, 23);
			this.username.TabIndex = 6;
			this.username.Text = "label22";
			// 
			// role
			// 
			this.role.Location = new System.Drawing.Point(6, 217);
			this.role.Name = "role";
			this.role.Size = new System.Drawing.Size(191, 23);
			this.role.TabIndex = 5;
			this.role.Text = "label22";
			// 
			// nifCin
			// 
			this.nifCin.Location = new System.Drawing.Point(6, 176);
			this.nifCin.Name = "nifCin";
			this.nifCin.Size = new System.Drawing.Size(191, 23);
			this.nifCin.TabIndex = 4;
			this.nifCin.Text = "label22";
			// 
			// lastname
			// 
			this.lastname.Location = new System.Drawing.Point(6, 139);
			this.lastname.Name = "lastname";
			this.lastname.Size = new System.Drawing.Size(191, 23);
			this.lastname.TabIndex = 3;
			this.lastname.Text = "label22";
			// 
			// firstname
			// 
			this.firstname.Location = new System.Drawing.Point(6, 104);
			this.firstname.Name = "firstname";
			this.firstname.Size = new System.Drawing.Size(191, 23);
			this.firstname.TabIndex = 2;
			this.firstname.Text = "label22";
			// 
			// code
			// 
			this.code.Location = new System.Drawing.Point(6, 65);
			this.code.Name = "code";
			this.code.Size = new System.Drawing.Size(191, 23);
			this.code.TabIndex = 1;
			this.code.Text = "label22";
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.SteelBlue;
			this.label14.Location = new System.Drawing.Point(6, 3);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(215, 43);
			this.label14.TabIndex = 0;
			this.label14.Text = "Infos utilisateur";
			// 
			// ChangeStatusUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(445, 437);
			this.Controls.Add(this.infoUserDeletePanel);
			this.Controls.Add(this.panel24);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "ChangeStatusUserForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ChangeStatusUserForm";
			this.panel24.ResumeLayout(false);
			this.infoUserDeletePanel.ResumeLayout(false);
			this.panel28.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
