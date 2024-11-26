/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 22/11/2024
 * Heure: 07:55
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
namespace BettingApp.form
{
	partial class MatchInfoForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView matchBetSummaryDataGridView;
		private System.Windows.Forms.Label labelIdFiche;
		
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
			this.panel = new System.Windows.Forms.Panel();
			this.labelIdFiche = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.matchBetSummaryDataGridView = new System.Windows.Forms.DataGridView();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.matchBetSummaryDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.labelIdFiche);
			this.panel.Controls.Add(this.label2);
			this.panel.Controls.Add(this.label1);
			this.panel.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel.Location = new System.Drawing.Point(0, 0);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(735, 58);
			this.panel.TabIndex = 0;
			// 
			// labelIdFiche
			// 
			this.labelIdFiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelIdFiche.ForeColor = System.Drawing.Color.SteelBlue;
			this.labelIdFiche.Location = new System.Drawing.Point(261, 11);
			this.labelIdFiche.Name = "labelIdFiche";
			this.labelIdFiche.Size = new System.Drawing.Size(471, 23);
			this.labelIdFiche.TabIndex = 28;
			this.labelIdFiche.Text = "label3";
			this.labelIdFiche.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Scandia Medium", 15.25F);
			this.label2.ForeColor = System.Drawing.Color.SteelBlue;
			this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.label2.Location = new System.Drawing.Point(3, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 26;
			this.label2.Text = "Listes";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Scandia Medium", 15.25F);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.label1.Location = new System.Drawing.Point(69, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(201, 23);
			this.label1.TabIndex = 27;
			this.label1.Text = "Matches du fiche";
			// 
			// matchBetSummaryDataGridView
			// 
			this.matchBetSummaryDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.matchBetSummaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.matchBetSummaryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.matchBetSummaryDataGridView.Location = new System.Drawing.Point(0, 58);
			this.matchBetSummaryDataGridView.Name = "matchBetSummaryDataGridView";
			this.matchBetSummaryDataGridView.Size = new System.Drawing.Size(735, 242);
			this.matchBetSummaryDataGridView.TabIndex = 3;
			this.matchBetSummaryDataGridView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.MatchBetSummaryDataGridViewRowPrePaint);
			// 
			// MatchInfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(735, 300);
			this.Controls.Add(this.matchBetSummaryDataGridView);
			this.Controls.Add(this.panel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MatchInfoForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MatchInfoForm";
			this.TopMost = true;
			this.panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.matchBetSummaryDataGridView)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
