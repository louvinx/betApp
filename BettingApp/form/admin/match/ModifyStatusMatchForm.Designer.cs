/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 18/11/2024
 * Heure: 22:21
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
namespace BettingApp.form.admin.match
{
	partial class ModifyStatusMatchForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBoxAwayTeam;
		private System.Windows.Forms.PictureBox pictureBoxHomeTeam;
		private System.Windows.Forms.Label labelHome;
		private System.Windows.Forms.Label labelAway;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelTypeMatch;
		private System.Windows.Forms.Label labelDate;
		private System.Windows.Forms.Label labelHours;
		private System.Windows.Forms.Panel panelStatus;
		private System.Windows.Forms.ComboBox comboBoxStatus;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.Button buttonModifyStatus;
		private System.Windows.Forms.Panel panelScore;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox textBoxScoreFinal;
		private System.Windows.Forms.Button buttonScore;
//		private System.Windows.Forms.Panel inputEmailPanel;
//		private System.Windows.Forms.ComboBox c;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyStatusMatchForm));
			this.label24 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelHours = new System.Windows.Forms.Label();
			this.labelTypeMatch = new System.Windows.Forms.Label();
			this.labelDate = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.labelAway = new System.Windows.Forms.Label();
			this.labelHome = new System.Windows.Forms.Label();
			this.pictureBoxAwayTeam = new System.Windows.Forms.PictureBox();
			this.pictureBoxHomeTeam = new System.Windows.Forms.PictureBox();
			this.panelStatus = new System.Windows.Forms.Panel();
			this.comboBoxStatus = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.buttonModifyStatus = new System.Windows.Forms.Button();
			this.panelScore = new System.Windows.Forms.Panel();
			this.textBoxScoreFinal = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.buttonScore = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAwayTeam)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomeTeam)).BeginInit();
			this.panelStatus.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			this.panelScore.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.Color.Transparent;
			this.label24.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.ForeColor = System.Drawing.Color.SteelBlue;
			this.label24.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.label24.Location = new System.Drawing.Point(12, 9);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(393, 37);
			this.label24.TabIndex = 45;
			this.label24.Text = "Modifier status match";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.labelHours);
			this.panel1.Controls.Add(this.labelTypeMatch);
			this.panel1.Controls.Add(this.labelDate);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.labelAway);
			this.panel1.Controls.Add(this.labelHome);
			this.panel1.Controls.Add(this.pictureBoxAwayTeam);
			this.panel1.Controls.Add(this.pictureBoxHomeTeam);
			this.panel1.Location = new System.Drawing.Point(12, 49);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(402, 124);
			this.panel1.TabIndex = 46;
			// 
			// labelHours
			// 
			this.labelHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelHours.Location = new System.Drawing.Point(156, 72);
			this.labelHours.Name = "labelHours";
			this.labelHours.Size = new System.Drawing.Size(100, 23);
			this.labelHours.TabIndex = 7;
			this.labelHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelTypeMatch
			// 
			this.labelTypeMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTypeMatch.Location = new System.Drawing.Point(156, 3);
			this.labelTypeMatch.Name = "labelTypeMatch";
			this.labelTypeMatch.Size = new System.Drawing.Size(100, 23);
			this.labelTypeMatch.TabIndex = 6;
			this.labelTypeMatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelDate
			// 
			this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDate.Location = new System.Drawing.Point(156, 49);
			this.labelDate.Name = "labelDate";
			this.labelDate.Size = new System.Drawing.Size(100, 23);
			this.labelDate.TabIndex = 5;
			this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(156, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "vs";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelAway
			// 
			this.labelAway.Location = new System.Drawing.Point(305, 98);
			this.labelAway.Name = "labelAway";
			this.labelAway.Size = new System.Drawing.Size(95, 20);
			this.labelAway.TabIndex = 3;
			this.labelAway.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelHome
			// 
			this.labelHome.Location = new System.Drawing.Point(3, 98);
			this.labelHome.Name = "labelHome";
			this.labelHome.Size = new System.Drawing.Size(95, 20);
			this.labelHome.TabIndex = 2;
			this.labelHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBoxAwayTeam
			// 
			this.pictureBoxAwayTeam.Location = new System.Drawing.Point(305, 4);
			this.pictureBoxAwayTeam.Name = "pictureBoxAwayTeam";
			this.pictureBoxAwayTeam.Size = new System.Drawing.Size(95, 87);
			this.pictureBoxAwayTeam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxAwayTeam.TabIndex = 1;
			this.pictureBoxAwayTeam.TabStop = false;
			// 
			// pictureBoxHomeTeam
			// 
			this.pictureBoxHomeTeam.Location = new System.Drawing.Point(3, 4);
			this.pictureBoxHomeTeam.Name = "pictureBoxHomeTeam";
			this.pictureBoxHomeTeam.Size = new System.Drawing.Size(95, 87);
			this.pictureBoxHomeTeam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxHomeTeam.TabIndex = 0;
			this.pictureBoxHomeTeam.TabStop = false;
			// 
			// panelStatus
			// 
			this.panelStatus.BackColor = System.Drawing.Color.White;
			this.panelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelStatus.Controls.Add(this.comboBoxStatus);
			this.panelStatus.Controls.Add(this.label12);
			this.panelStatus.Controls.Add(this.pictureBox8);
			this.panelStatus.Location = new System.Drawing.Point(12, 179);
			this.panelStatus.Name = "panelStatus";
			this.panelStatus.Size = new System.Drawing.Size(256, 60);
			this.panelStatus.TabIndex = 47;
			// 
			// comboBoxStatus
			// 
			this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxStatus.FormattingEnabled = true;
			this.comboBoxStatus.Items.AddRange(new object[] {
			"N",
			"E",
			"T",
			"A",
			"S"});
			this.comboBoxStatus.Location = new System.Drawing.Point(46, 26);
			this.comboBoxStatus.Name = "comboBoxStatus";
			this.comboBoxStatus.Size = new System.Drawing.Size(205, 21);
			this.comboBoxStatus.TabIndex = 3;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(15, 4);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(163, 23);
			this.label12.TabIndex = 2;
			this.label12.Text = "Modifier status:";
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(15, 30);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(24, 20);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox8.TabIndex = 0;
			this.pictureBox8.TabStop = false;
			// 
			// buttonModifyStatus
			// 
			this.buttonModifyStatus.BackColor = System.Drawing.Color.SteelBlue;
			this.buttonModifyStatus.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonModifyStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonModifyStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonModifyStatus.ForeColor = System.Drawing.Color.White;
			this.buttonModifyStatus.Location = new System.Drawing.Point(274, 199);
			this.buttonModifyStatus.Name = "buttonModifyStatus";
			this.buttonModifyStatus.Size = new System.Drawing.Size(90, 40);
			this.buttonModifyStatus.TabIndex = 48;
			this.buttonModifyStatus.Text = "Modifier";
			this.buttonModifyStatus.UseVisualStyleBackColor = false;
			this.buttonModifyStatus.Click += new System.EventHandler(this.ButtonModifyStatusClick);
			// 
			// panelScore
			// 
			this.panelScore.BackColor = System.Drawing.Color.White;
			this.panelScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelScore.Controls.Add(this.textBoxScoreFinal);
			this.panelScore.Controls.Add(this.label2);
			this.panelScore.Controls.Add(this.pictureBox1);
			this.panelScore.Location = new System.Drawing.Point(12, 245);
			this.panelScore.Name = "panelScore";
			this.panelScore.Size = new System.Drawing.Size(256, 60);
			this.panelScore.TabIndex = 49;
			this.panelScore.Visible = false;
			// 
			// textBoxScoreFinal
			// 
			this.textBoxScoreFinal.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxScoreFinal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxScoreFinal.ForeColor = System.Drawing.Color.Black;
			this.textBoxScoreFinal.Location = new System.Drawing.Point(46, 30);
			this.textBoxScoreFinal.Name = "textBoxScoreFinal";
			this.textBoxScoreFinal.Size = new System.Drawing.Size(205, 20);
			this.textBoxScoreFinal.TabIndex = 29;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(15, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(163, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Modifier score final:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(15, 30);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(24, 20);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// buttonScore
			// 
			this.buttonScore.BackColor = System.Drawing.Color.SteelBlue;
			this.buttonScore.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonScore.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonScore.ForeColor = System.Drawing.Color.White;
			this.buttonScore.Location = new System.Drawing.Point(274, 265);
			this.buttonScore.Name = "buttonScore";
			this.buttonScore.Size = new System.Drawing.Size(90, 40);
			this.buttonScore.TabIndex = 50;
			this.buttonScore.Text = "Ajouter";
			this.buttonScore.UseVisualStyleBackColor = false;
			this.buttonScore.Visible = false;
			this.buttonScore.Click += new System.EventHandler(this.ButtonScoreClick);
			// 
			// ModifyStatusMatchForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(426, 324);
			this.Controls.Add(this.buttonScore);
			this.Controls.Add(this.panelScore);
			this.Controls.Add(this.buttonModifyStatus);
			this.Controls.Add(this.panelStatus);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label24);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "ModifyStatusMatchForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ModifyStatusMatchForm";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAwayTeam)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomeTeam)).EndInit();
			this.panelStatus.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			this.panelScore.ResumeLayout(false);
			this.panelScore.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
