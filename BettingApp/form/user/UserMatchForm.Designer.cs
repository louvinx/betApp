/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 19/11/2024
 * Heure: 18:16
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
namespace BettingApp.form.user
{
	partial class UserMatchForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView matchUsersDataGridView;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label loginLabel;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button buttonCreateBet;
		private System.Windows.Forms.Label labelBetNow;
		private System.Windows.Forms.Button buttonValidate;
		
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonValidate = new System.Windows.Forms.Button();
			this.labelBetNow = new System.Windows.Forms.Label();
			this.buttonCreateBet = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.loginLabel = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.matchUsersDataGridView = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.matchUsersDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.buttonValidate);
			this.panel1.Controls.Add(this.labelBetNow);
			this.panel1.Controls.Add(this.buttonCreateBet);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.loginLabel);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(732, 127);
			this.panel1.TabIndex = 5;
			// 
			// buttonValidate
			// 
			this.buttonValidate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonValidate.BackColor = System.Drawing.Color.Black;
			this.buttonValidate.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonValidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonValidate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonValidate.ForeColor = System.Drawing.Color.White;
			this.buttonValidate.Location = new System.Drawing.Point(468, 11);
			this.buttonValidate.Name = "buttonValidate";
			this.buttonValidate.Size = new System.Drawing.Size(100, 37);
			this.buttonValidate.TabIndex = 51;
			this.buttonValidate.Text = "Valider fiche";
			this.buttonValidate.UseVisualStyleBackColor = false;
			this.buttonValidate.Visible = false;
			this.buttonValidate.Click += new System.EventHandler(this.ButtonValidateClick);
			// 
			// labelBetNow
			// 
			this.labelBetNow.BackColor = System.Drawing.Color.WhiteSmoke;
			this.labelBetNow.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelBetNow.Location = new System.Drawing.Point(12, 62);
			this.labelBetNow.Name = "labelBetNow";
			this.labelBetNow.Size = new System.Drawing.Size(691, 20);
			this.labelBetNow.TabIndex = 50;
			this.labelBetNow.Text = "label1";
			this.labelBetNow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelBetNow.Visible = false;
			// 
			// buttonCreateBet
			// 
			this.buttonCreateBet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCreateBet.BackColor = System.Drawing.Color.SteelBlue;
			this.buttonCreateBet.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonCreateBet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCreateBet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCreateBet.ForeColor = System.Drawing.Color.White;
			this.buttonCreateBet.Location = new System.Drawing.Point(574, 11);
			this.buttonCreateBet.Name = "buttonCreateBet";
			this.buttonCreateBet.Size = new System.Drawing.Size(129, 37);
			this.buttonCreateBet.TabIndex = 49;
			this.buttonCreateBet.Text = "Ajouter une fiche";
			this.buttonCreateBet.UseVisualStyleBackColor = false;
			this.buttonCreateBet.Click += new System.EventHandler(this.ButtonCreateBetClick);
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Scandia Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.label10.Location = new System.Drawing.Point(93, 11);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(174, 37);
			this.label10.TabIndex = 25;
			this.label10.Text = "des matchs";
			// 
			// loginLabel
			// 
			this.loginLabel.BackColor = System.Drawing.Color.Transparent;
			this.loginLabel.Font = new System.Drawing.Font("Scandia Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginLabel.ForeColor = System.Drawing.Color.SteelBlue;
			this.loginLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.loginLabel.Location = new System.Drawing.Point(12, 11);
			this.loginLabel.Name = "loginLabel";
			this.loginLabel.Size = new System.Drawing.Size(88, 37);
			this.loginLabel.TabIndex = 24;
			this.loginLabel.Text = "Listes";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.matchUsersDataGridView);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 127);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(732, 304);
			this.panel3.TabIndex = 7;
			// 
			// matchUsersDataGridView
			// 
			this.matchUsersDataGridView.AllowUserToOrderColumns = true;
			this.matchUsersDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.matchUsersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.matchUsersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.matchUsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.matchUsersDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
			this.matchUsersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.matchUsersDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
			this.matchUsersDataGridView.Location = new System.Drawing.Point(0, 0);
			this.matchUsersDataGridView.Name = "matchUsersDataGridView";
			this.matchUsersDataGridView.Size = new System.Drawing.Size(732, 304);
			this.matchUsersDataGridView.TabIndex = 5;
			this.matchUsersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MatchUsersDataGridViewCellClick);
			// 
			// UserMatchForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(732, 431);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "UserMatchForm";
			this.Text = "MatchUserForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserMatchFormFormClosing);
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.matchUsersDataGridView)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
