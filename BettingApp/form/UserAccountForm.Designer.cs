/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 21/11/2024
 * Heure: 11:31
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
namespace BettingApp.form
{
	partial class UserAccountForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label status;
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
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button ModifyButton;
		private System.Windows.Forms.Panel panel1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccountForm));
			this.status = new System.Windows.Forms.Label();
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.ModifyButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// status
			// 
			this.status.Location = new System.Drawing.Point(236, 223);
			this.status.Name = "status";
			this.status.Size = new System.Drawing.Size(203, 21);
			this.status.TabIndex = 54;
			this.status.Text = "label22";
			// 
			// sexe
			// 
			this.sexe.Location = new System.Drawing.Point(236, 182);
			this.sexe.Name = "sexe";
			this.sexe.Size = new System.Drawing.Size(203, 21);
			this.sexe.TabIndex = 53;
			this.sexe.Text = "label22";
			// 
			// balance
			// 
			this.balance.Location = new System.Drawing.Point(233, 145);
			this.balance.Name = "balance";
			this.balance.Size = new System.Drawing.Size(206, 21);
			this.balance.TabIndex = 52;
			this.balance.Text = "label22";
			// 
			// phone
			// 
			this.phone.Location = new System.Drawing.Point(236, 110);
			this.phone.Name = "phone";
			this.phone.Size = new System.Drawing.Size(203, 21);
			this.phone.TabIndex = 51;
			this.phone.Text = "label22";
			// 
			// username
			// 
			this.username.Location = new System.Drawing.Point(236, 71);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(203, 21);
			this.username.TabIndex = 50;
			this.username.Text = "label22";
			// 
			// role
			// 
			this.role.Location = new System.Drawing.Point(12, 223);
			this.role.Name = "role";
			this.role.Size = new System.Drawing.Size(191, 21);
			this.role.TabIndex = 49;
			this.role.Text = "label22";
			// 
			// nifCin
			// 
			this.nifCin.Location = new System.Drawing.Point(12, 182);
			this.nifCin.Name = "nifCin";
			this.nifCin.Size = new System.Drawing.Size(191, 21);
			this.nifCin.TabIndex = 48;
			this.nifCin.Text = "label22";
			// 
			// lastname
			// 
			this.lastname.Location = new System.Drawing.Point(12, 145);
			this.lastname.Name = "lastname";
			this.lastname.Size = new System.Drawing.Size(191, 21);
			this.lastname.TabIndex = 47;
			this.lastname.Text = "label22";
			// 
			// firstname
			// 
			this.firstname.Location = new System.Drawing.Point(12, 110);
			this.firstname.Name = "firstname";
			this.firstname.Size = new System.Drawing.Size(191, 21);
			this.firstname.TabIndex = 46;
			this.firstname.Text = "label22";
			// 
			// code
			// 
			this.code.Location = new System.Drawing.Point(12, 71);
			this.code.Name = "code";
			this.code.Size = new System.Drawing.Size(191, 21);
			this.code.TabIndex = 45;
			this.code.Text = "label22";
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.SteelBlue;
			this.label14.Location = new System.Drawing.Point(12, 9);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(163, 28);
			this.label14.TabIndex = 44;
			this.label14.Text = "Infos utilisateur";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(181, 9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(39, 28);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 55;
			this.pictureBox1.TabStop = false;
			// 
			// ModifyButton
			// 
			this.ModifyButton.BackColor = System.Drawing.Color.SteelBlue;
			this.ModifyButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.ModifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ModifyButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ModifyButton.ForeColor = System.Drawing.Color.White;
			this.ModifyButton.Location = new System.Drawing.Point(12, 298);
			this.ModifyButton.Name = "ModifyButton";
			this.ModifyButton.Size = new System.Drawing.Size(194, 40);
			this.ModifyButton.TabIndex = 56;
			this.ModifyButton.Text = "Modifier Information";
			this.ModifyButton.UseVisualStyleBackColor = false;
			this.ModifyButton.Click += new System.EventHandler(this.ModifyButtonClick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.SteelBlue;
			this.panel1.Location = new System.Drawing.Point(13, 41);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(587, 8);
			this.panel1.TabIndex = 57;
			// 
			// UserAccountForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(729, 410);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.ModifyButton);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.status);
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
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "UserAccountForm";
			this.Text = "UserAccountForm";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
