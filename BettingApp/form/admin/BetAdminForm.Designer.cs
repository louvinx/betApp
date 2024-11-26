/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 21/11/2024
 * Heure: 15:13
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
namespace BettingApp.form.admin
{
	partial class BetAdminForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.DataGridView betsPendingDataGridView;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage listParisPendingTabPage;
		private System.Windows.Forms.TabControl userTabControl;
		private System.Windows.Forms.TabPage listParisTabPage;
		private System.Windows.Forms.DataGridView betsDataGridView;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BetAdminForm));
			this.listParisTabPage = new System.Windows.Forms.TabPage();
			this.betsDataGridView = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.listParisPendingTabPage = new System.Windows.Forms.TabPage();
			this.panel5 = new System.Windows.Forms.Panel();
			this.betsPendingDataGridView = new System.Windows.Forms.DataGridView();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.userTabControl = new System.Windows.Forms.TabControl();
			this.listParisTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.betsDataGridView)).BeginInit();
			this.panel1.SuspendLayout();
			this.listParisPendingTabPage.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.betsPendingDataGridView)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			this.userTabControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// listParisTabPage
			// 
			this.listParisTabPage.BackColor = System.Drawing.Color.White;
			this.listParisTabPage.Controls.Add(this.betsDataGridView);
			this.listParisTabPage.Controls.Add(this.panel1);
			this.listParisTabPage.Location = new System.Drawing.Point(4, 22);
			this.listParisTabPage.Name = "listParisTabPage";
			this.listParisTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.listParisTabPage.Size = new System.Drawing.Size(721, 430);
			this.listParisTabPage.TabIndex = 2;
			this.listParisTabPage.Text = "Listes total des paris";
			// 
			// betsDataGridView
			// 
			this.betsDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.betsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.betsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.betsDataGridView.Location = new System.Drawing.Point(3, 62);
			this.betsDataGridView.Name = "betsDataGridView";
			this.betsDataGridView.Size = new System.Drawing.Size(715, 365);
			this.betsDataGridView.TabIndex = 0;
			this.betsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BetsDataGridViewCellClick);
			this.betsDataGridView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.BetsDataGridViewRowPrePaint);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.panel7);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(715, 59);
			this.panel1.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(259, 5);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 14);
			this.label5.TabIndex = 5;
			this.label5.Text = "LOST";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(133, 5);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 14);
			this.label4.TabIndex = 4;
			this.label4.Text = "WIN";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 14);
			this.label3.TabIndex = 3;
			this.label3.Text = "PENDING";
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.LightCoral;
			this.panel7.Location = new System.Drawing.Point(259, 22);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(94, 22);
			this.panel7.TabIndex = 2;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.LightGreen;
			this.panel3.Location = new System.Drawing.Point(133, 22);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(94, 22);
			this.panel3.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.LightYellow;
			this.panel2.Location = new System.Drawing.Point(5, 22);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(94, 22);
			this.panel2.TabIndex = 0;
			// 
			// listParisPendingTabPage
			// 
			this.listParisPendingTabPage.BackColor = System.Drawing.Color.Transparent;
			this.listParisPendingTabPage.Controls.Add(this.panel5);
			this.listParisPendingTabPage.Controls.Add(this.panel4);
			this.listParisPendingTabPage.Controls.Add(this.label1);
			this.listParisPendingTabPage.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listParisPendingTabPage.Location = new System.Drawing.Point(4, 22);
			this.listParisPendingTabPage.Name = "listParisPendingTabPage";
			this.listParisPendingTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.listParisPendingTabPage.Size = new System.Drawing.Size(721, 430);
			this.listParisPendingTabPage.TabIndex = 0;
			this.listParisPendingTabPage.Text = "Listes paris en cours";
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.White;
			this.panel5.Controls.Add(this.betsPendingDataGridView);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(3, 93);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(715, 334);
			this.panel5.TabIndex = 4;
			// 
			// betsPendingDataGridView
			// 
			this.betsPendingDataGridView.AllowUserToOrderColumns = true;
			this.betsPendingDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.betsPendingDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.betsPendingDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.betsPendingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.betsPendingDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
			this.betsPendingDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.betsPendingDataGridView.GridColor = System.Drawing.SystemColors.Control;
			this.betsPendingDataGridView.Location = new System.Drawing.Point(0, 0);
			this.betsPendingDataGridView.Name = "betsPendingDataGridView";
			this.betsPendingDataGridView.Size = new System.Drawing.Size(715, 334);
			this.betsPendingDataGridView.TabIndex = 2;
			this.betsPendingDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BetsPendingDataGridViewCellClick);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.White;
			this.panel4.Controls.Add(this.panel6);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(3, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(715, 90);
			this.panel4.TabIndex = 3;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.White;
			this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel6.Controls.Add(this.pictureBox6);
			this.panel6.Controls.Add(this.textBoxSearch);
			this.panel6.Location = new System.Drawing.Point(5, 35);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(308, 38);
			this.panel6.TabIndex = 3;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(12, 8);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(27, 21);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox6.TabIndex = 3;
			this.pictureBox6.TabStop = false;
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.BackColor = System.Drawing.Color.White;
			this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSearch.Location = new System.Drawing.Point(43, 8);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(249, 20);
			this.textBoxSearch.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.SteelBlue;
			this.label2.Location = new System.Drawing.Point(5, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(334, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "Listes des paris en cours";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// userTabControl
			// 
			this.userTabControl.Controls.Add(this.listParisPendingTabPage);
			this.userTabControl.Controls.Add(this.listParisTabPage);
			this.userTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.userTabControl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.userTabControl.ItemSize = new System.Drawing.Size(81, 18);
			this.userTabControl.Location = new System.Drawing.Point(0, 0);
			this.userTabControl.Name = "userTabControl";
			this.userTabControl.SelectedIndex = 0;
			this.userTabControl.Size = new System.Drawing.Size(729, 456);
			this.userTabControl.TabIndex = 4;
			// 
			// BetAdminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(729, 456);
			this.Controls.Add(this.userTabControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "BetAdminForm";
			this.Text = "ParisForm";
			this.listParisTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.betsDataGridView)).EndInit();
			this.panel1.ResumeLayout(false);
			this.listParisPendingTabPage.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.betsPendingDataGridView)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			this.userTabControl.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
