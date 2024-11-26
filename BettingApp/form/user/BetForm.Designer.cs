/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 20/11/2024
 * Heure: 14:22
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
namespace BettingApp.form.user
{
	partial class BetForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panelBet;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView betDataGridView;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Button buttonPreviewBet;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button printButtonFileBet;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BetForm));
			this.panelBet = new System.Windows.Forms.Panel();
			this.betDataGridView = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.buttonPreviewBet = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.printButtonFileBet = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panelBet.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.betDataGridView)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelBet
			// 
			this.panelBet.AutoScroll = true;
			this.panelBet.BackColor = System.Drawing.Color.White;
			this.panelBet.Controls.Add(this.betDataGridView);
			this.panelBet.Controls.Add(this.panel1);
			this.panelBet.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelBet.Location = new System.Drawing.Point(0, 0);
			this.panelBet.Name = "panelBet";
			this.panelBet.Size = new System.Drawing.Size(732, 431);
			this.panelBet.TabIndex = 7;
			// 
			// betDataGridView
			// 
			this.betDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.betDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.betDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.betDataGridView.Location = new System.Drawing.Point(0, 62);
			this.betDataGridView.Name = "betDataGridView";
			this.betDataGridView.Size = new System.Drawing.Size(732, 369);
			this.betDataGridView.TabIndex = 2;
			this.betDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BetDataGridViewCellClick);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Controls.Add(this.buttonPreviewBet);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.printButtonFileBet);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(732, 62);
			this.panel1.TabIndex = 3;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(447, 27);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(23, 20);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 43;
			this.pictureBox3.TabStop = false;
			// 
			// buttonPreviewBet
			// 
			this.buttonPreviewBet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonPreviewBet.BackColor = System.Drawing.Color.Transparent;
			this.buttonPreviewBet.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.buttonPreviewBet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPreviewBet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonPreviewBet.ForeColor = System.Drawing.Color.SteelBlue;
			this.buttonPreviewBet.Location = new System.Drawing.Point(434, 17);
			this.buttonPreviewBet.Name = "buttonPreviewBet";
			this.buttonPreviewBet.Size = new System.Drawing.Size(141, 39);
			this.buttonPreviewBet.TabIndex = 42;
			this.buttonPreviewBet.Text = "Previsualisaer";
			this.buttonPreviewBet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonPreviewBet.UseVisualStyleBackColor = false;
			this.buttonPreviewBet.Click += new System.EventHandler(this.ButtonPreviewBetClick);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.Color.SteelBlue;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(594, 27);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(23, 20);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 41;
			this.pictureBox2.TabStop = false;
			// 
			// printButtonFileBet
			// 
			this.printButtonFileBet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.printButtonFileBet.BackColor = System.Drawing.Color.SteelBlue;
			this.printButtonFileBet.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.printButtonFileBet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.printButtonFileBet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.printButtonFileBet.ForeColor = System.Drawing.Color.White;
			this.printButtonFileBet.Location = new System.Drawing.Point(581, 17);
			this.printButtonFileBet.Name = "printButtonFileBet";
			this.printButtonFileBet.Size = new System.Drawing.Size(141, 39);
			this.printButtonFileBet.TabIndex = 40;
			this.printButtonFileBet.Text = "Imprimer paris";
			this.printButtonFileBet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.printButtonFileBet.UseVisualStyleBackColor = false;
			this.printButtonFileBet.Click += new System.EventHandler(this.PrintButtonFileBetClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(38, 30);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.SteelBlue;
			this.label1.Location = new System.Drawing.Point(56, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(255, 35);
			this.label1.TabIndex = 0;
			this.label1.Text = "Liste des paris en cours";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// BetForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(732, 431);
			this.Controls.Add(this.panelBet);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "BetForm";
			this.Text = "BetForm";
			this.panelBet.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.betDataGridView)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
