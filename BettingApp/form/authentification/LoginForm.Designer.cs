/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 04/11/2024
 * Heure: 11:39
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
namespace BettingApp.form.authentification
{
	partial class LoginForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel leftPanel;
		private System.Windows.Forms.Panel rightPanel;
		private System.Windows.Forms.Label developLabel;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Button registerButton;
		private System.Windows.Forms.Label loginLabel;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.leftPanel = new System.Windows.Forms.Panel();
			this.sloganLabel = new System.Windows.Forms.Label();
			this.welcomeLabel = new System.Windows.Forms.Label();
			this.louvinxLabel = new System.Windows.Forms.Label();
			this.developLabel = new System.Windows.Forms.Label();
			this.logoPanel = new System.Windows.Forms.Panel();
			this.betLabel = new System.Windows.Forms.Label();
			this.title = new System.Windows.Forms.Label();
			this.rightPanel = new System.Windows.Forms.Panel();
			this.panel9 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.loginPasswordTextBox = new System.Windows.Forms.TextBox();
			this.passwordPictureBox = new System.Windows.Forms.PictureBox();
			this.panel8 = new System.Windows.Forms.Panel();
			this.loginUsernameTextBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.usernameTextBox = new System.Windows.Forms.TextBox();
			this.usernamepictureBox = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.loginButton = new System.Windows.Forms.Button();
			this.registerButton = new System.Windows.Forms.Button();
			this.loginLabel = new System.Windows.Forms.Label();
			this.closeButton = new System.Windows.Forms.Button();
			this.leftPanel.SuspendLayout();
			this.logoPanel.SuspendLayout();
			this.rightPanel.SuspendLayout();
			this.panel9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).BeginInit();
			this.panel8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.usernamepictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// leftPanel
			// 
			this.leftPanel.BackColor = System.Drawing.Color.SteelBlue;
			this.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.leftPanel.Controls.Add(this.sloganLabel);
			this.leftPanel.Controls.Add(this.welcomeLabel);
			this.leftPanel.Controls.Add(this.louvinxLabel);
			this.leftPanel.Controls.Add(this.developLabel);
			this.leftPanel.Controls.Add(this.logoPanel);
			this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.leftPanel.Location = new System.Drawing.Point(0, 0);
			this.leftPanel.Name = "leftPanel";
			this.leftPanel.Size = new System.Drawing.Size(300, 450);
			this.leftPanel.TabIndex = 0;
			// 
			// sloganLabel
			// 
			this.sloganLabel.Font = new System.Drawing.Font("Scandia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sloganLabel.ForeColor = System.Drawing.Color.White;
			this.sloganLabel.Location = new System.Drawing.Point(29, 296);
			this.sloganLabel.Name = "sloganLabel";
			this.sloganLabel.Size = new System.Drawing.Size(266, 23);
			this.sloganLabel.TabIndex = 10;
			this.sloganLabel.Text = "Vivre l\'intensite du football dans le pari";
			// 
			// welcomeLabel
			// 
			this.welcomeLabel.Font = new System.Drawing.Font("Scandia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.welcomeLabel.ForeColor = System.Drawing.Color.White;
			this.welcomeLabel.Location = new System.Drawing.Point(29, 261);
			this.welcomeLabel.Name = "welcomeLabel";
			this.welcomeLabel.Size = new System.Drawing.Size(239, 23);
			this.welcomeLabel.TabIndex = 8;
			this.welcomeLabel.Text = "Welcome to phoenix bet";
			// 
			// louvinxLabel
			// 
			this.louvinxLabel.Font = new System.Drawing.Font("Scandia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.louvinxLabel.ForeColor = System.Drawing.Color.White;
			this.louvinxLabel.Location = new System.Drawing.Point(29, 404);
			this.louvinxLabel.Name = "louvinxLabel";
			this.louvinxLabel.Size = new System.Drawing.Size(130, 27);
			this.louvinxLabel.TabIndex = 7;
			this.louvinxLabel.Text = "Louvinx PIERRE";
			// 
			// developLabel
			// 
			this.developLabel.Font = new System.Drawing.Font("Scandia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.developLabel.ForeColor = System.Drawing.Color.White;
			this.developLabel.Location = new System.Drawing.Point(29, 381);
			this.developLabel.Name = "developLabel";
			this.developLabel.Size = new System.Drawing.Size(130, 23);
			this.developLabel.TabIndex = 6;
			this.developLabel.Text = "Develop by";
			// 
			// logoPanel
			// 
			this.logoPanel.Controls.Add(this.betLabel);
			this.logoPanel.Controls.Add(this.title);
			this.logoPanel.Location = new System.Drawing.Point(29, 41);
			this.logoPanel.Name = "logoPanel";
			this.logoPanel.Size = new System.Drawing.Size(239, 100);
			this.logoPanel.TabIndex = 5;
			// 
			// betLabel
			// 
			this.betLabel.BackColor = System.Drawing.Color.Black;
			this.betLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.betLabel.ForeColor = System.Drawing.Color.White;
			this.betLabel.Location = new System.Drawing.Point(142, 33);
			this.betLabel.Name = "betLabel";
			this.betLabel.Size = new System.Drawing.Size(60, 34);
			this.betLabel.TabIndex = 6;
			this.betLabel.Text = "3ET";
			// 
			// title
			// 
			this.title.Font = new System.Drawing.Font("Scandia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.title.ForeColor = System.Drawing.Color.Black;
			this.title.Location = new System.Drawing.Point(37, 40);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(114, 27);
			this.title.TabIndex = 5;
			this.title.Text = "PHOENIX";
			// 
			// rightPanel
			// 
			this.rightPanel.AutoSize = true;
			this.rightPanel.BackColor = System.Drawing.Color.White;
			this.rightPanel.Controls.Add(this.panel9);
			this.rightPanel.Controls.Add(this.panel8);
			this.rightPanel.Controls.Add(this.label1);
			this.rightPanel.Controls.Add(this.loginButton);
			this.rightPanel.Controls.Add(this.registerButton);
			this.rightPanel.Controls.Add(this.loginLabel);
			this.rightPanel.Controls.Add(this.closeButton);
			this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rightPanel.Location = new System.Drawing.Point(300, 0);
			this.rightPanel.Name = "rightPanel";
			this.rightPanel.Size = new System.Drawing.Size(380, 450);
			this.rightPanel.TabIndex = 1;
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.Color.White;
			this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel9.Controls.Add(this.label9);
			this.panel9.Controls.Add(this.loginPasswordTextBox);
			this.panel9.Controls.Add(this.passwordPictureBox);
			this.panel9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel9.Location = new System.Drawing.Point(11, 228);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(359, 60);
			this.panel9.TabIndex = 21;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(15, 4);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 2;
			this.label9.Text = "Password :";
			// 
			// loginPasswordTextBox
			// 
			this.loginPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.loginPasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginPasswordTextBox.ForeColor = System.Drawing.Color.Black;
			this.loginPasswordTextBox.Location = new System.Drawing.Point(46, 34);
			this.loginPasswordTextBox.Name = "loginPasswordTextBox";
			this.loginPasswordTextBox.Size = new System.Drawing.Size(289, 20);
			this.loginPasswordTextBox.TabIndex = 1;
			this.loginPasswordTextBox.UseSystemPasswordChar = true;
			// 
			// passwordPictureBox
			// 
			this.passwordPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("passwordPictureBox.Image")));
			this.passwordPictureBox.Location = new System.Drawing.Point(15, 30);
			this.passwordPictureBox.Name = "passwordPictureBox";
			this.passwordPictureBox.Size = new System.Drawing.Size(24, 24);
			this.passwordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.passwordPictureBox.TabIndex = 0;
			this.passwordPictureBox.TabStop = false;
			this.passwordPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PasswordPictureBoxMouseDown);
			this.passwordPictureBox.MouseEnter += new System.EventHandler(this.PasswordPictureBoxMouseEnter);
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.White;
			this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel8.Controls.Add(this.loginUsernameTextBox);
			this.panel8.Controls.Add(this.label8);
			this.panel8.Controls.Add(this.usernameTextBox);
			this.panel8.Controls.Add(this.usernamepictureBox);
			this.panel8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel8.Location = new System.Drawing.Point(11, 162);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(359, 60);
			this.panel8.TabIndex = 20;
			// 
			// loginUsernameTextBox
			// 
			this.loginUsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.loginUsernameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginUsernameTextBox.ForeColor = System.Drawing.Color.Black;
			this.loginUsernameTextBox.Location = new System.Drawing.Point(46, 34);
			this.loginUsernameTextBox.Name = "loginUsernameTextBox";
			this.loginUsernameTextBox.Size = new System.Drawing.Size(289, 20);
			this.loginUsernameTextBox.TabIndex = 3;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(15, 4);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 2;
			this.label8.Text = "Nom utilisateur :";
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.usernameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernameTextBox.ForeColor = System.Drawing.Color.Black;
			this.usernameTextBox.Location = new System.Drawing.Point(0, 0);
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(289, 20);
			this.usernameTextBox.TabIndex = 1;
			// 
			// usernamepictureBox
			// 
			this.usernamepictureBox.Image = ((System.Drawing.Image)(resources.GetObject("usernamepictureBox.Image")));
			this.usernamepictureBox.Location = new System.Drawing.Point(15, 30);
			this.usernamepictureBox.Name = "usernamepictureBox";
			this.usernamepictureBox.Size = new System.Drawing.Size(24, 24);
			this.usernamepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.usernamepictureBox.TabIndex = 0;
			this.usernamepictureBox.TabStop = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.label1.Location = new System.Drawing.Point(10, 105);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(299, 37);
			this.label1.TabIndex = 7;
			this.label1.Text = "PhoenixBet";
			// 
			// loginButton
			// 
			this.loginButton.BackColor = System.Drawing.Color.SteelBlue;
			this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loginButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginButton.ForeColor = System.Drawing.Color.White;
			this.loginButton.Location = new System.Drawing.Point(275, 354);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(90, 40);
			this.loginButton.TabIndex = 6;
			this.loginButton.Text = "Connecter";
			this.loginButton.UseVisualStyleBackColor = false;
			this.loginButton.Click += new System.EventHandler(this.LoginButtonClick);
			// 
			// registerButton
			// 
			this.registerButton.BackColor = System.Drawing.Color.White;
			this.registerButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.registerButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.registerButton.ForeColor = System.Drawing.Color.SteelBlue;
			this.registerButton.Location = new System.Drawing.Point(179, 354);
			this.registerButton.Name = "registerButton";
			this.registerButton.Size = new System.Drawing.Size(90, 40);
			this.registerButton.TabIndex = 5;
			this.registerButton.Text = "Inscrire";
			this.registerButton.UseVisualStyleBackColor = false;
			this.registerButton.Click += new System.EventHandler(this.RegisterButtonClick);
			// 
			// loginLabel
			// 
			this.loginLabel.BackColor = System.Drawing.Color.White;
			this.loginLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginLabel.ForeColor = System.Drawing.Color.SteelBlue;
			this.loginLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.loginLabel.Location = new System.Drawing.Point(6, 68);
			this.loginLabel.Name = "loginLabel";
			this.loginLabel.Size = new System.Drawing.Size(249, 37);
			this.loginLabel.TabIndex = 2;
			this.loginLabel.Text = "Connnecter vous";
			// 
			// closeButton
			// 
			this.closeButton.BackColor = System.Drawing.Color.SteelBlue;
			this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.closeButton.FlatAppearance.BorderSize = 0;
			this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.closeButton.ForeColor = System.Drawing.Color.White;
			this.closeButton.Location = new System.Drawing.Point(333, 12);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(35, 35);
			this.closeButton.TabIndex = 0;
			this.closeButton.Text = "X";
			this.closeButton.UseVisualStyleBackColor = false;
			this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(680, 450);
			this.ControlBox = false;
			this.Controls.Add(this.rightPanel);
			this.Controls.Add(this.leftPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.leftPanel.ResumeLayout(false);
			this.logoPanel.ResumeLayout(false);
			this.rightPanel.ResumeLayout(false);
			this.panel9.ResumeLayout(false);
			this.panel9.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).EndInit();
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.usernamepictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.TextBox loginUsernameTextBox;
		private System.Windows.Forms.PictureBox usernamepictureBox;
		private System.Windows.Forms.TextBox usernameTextBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.PictureBox passwordPictureBox;
		private System.Windows.Forms.TextBox loginPasswordTextBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.Label welcomeLabel;
		private System.Windows.Forms.Label sloganLabel;
		private System.Windows.Forms.Panel logoPanel;
		private System.Windows.Forms.Label louvinxLabel;
		private System.Windows.Forms.Label title;
		private System.Windows.Forms.Label betLabel;
		
	
		
		
		
		void RegisterButtonClick(object sender, System.EventArgs e)
		{
			this.Hide();
			RegisterForm registerForm = new RegisterForm();
			registerForm.Show();			
		}
	}
}
