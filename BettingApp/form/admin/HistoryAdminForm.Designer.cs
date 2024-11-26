/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 22/11/2024
 * Heure: 11:20
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
namespace BettingApp.form.admin
{
	partial class HistoryAdminForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl userTabControl;
		private System.Windows.Forms.TabPage listParisCompletedTabPage;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.DataGridView betsHistoryDataGridView;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage listPaymentTabPage;
		private System.Windows.Forms.DataGridView paymentUserDataGridView;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button printButtonFileBet;
		private System.Windows.Forms.Button printButtonBetPayment;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonPreviewBet;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Button buttonPreviewPay;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryAdminForm));
			this.userTabControl = new System.Windows.Forms.TabControl();
			this.listParisCompletedTabPage = new System.Windows.Forms.TabPage();
			this.panel5 = new System.Windows.Forms.Panel();
			this.betsHistoryDataGridView = new System.Windows.Forms.DataGridView();
			this.panel4 = new System.Windows.Forms.Panel();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.buttonPreviewBet = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.printButtonFileBet = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.listPaymentTabPage = new System.Windows.Forms.TabPage();
			this.paymentUserDataGridView = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.buttonPreviewPay = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.printButtonBetPayment = new System.Windows.Forms.Button();
			this.userTabControl.SuspendLayout();
			this.listParisCompletedTabPage.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.betsHistoryDataGridView)).BeginInit();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.listPaymentTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.paymentUserDataGridView)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// userTabControl
			// 
			this.userTabControl.Controls.Add(this.listParisCompletedTabPage);
			this.userTabControl.Controls.Add(this.listPaymentTabPage);
			this.userTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.userTabControl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.userTabControl.ItemSize = new System.Drawing.Size(81, 18);
			this.userTabControl.Location = new System.Drawing.Point(0, 0);
			this.userTabControl.Name = "userTabControl";
			this.userTabControl.SelectedIndex = 0;
			this.userTabControl.Size = new System.Drawing.Size(717, 434);
			this.userTabControl.TabIndex = 6;
			// 
			// listParisCompletedTabPage
			// 
			this.listParisCompletedTabPage.BackColor = System.Drawing.Color.Transparent;
			this.listParisCompletedTabPage.Controls.Add(this.panel5);
			this.listParisCompletedTabPage.Controls.Add(this.panel4);
			this.listParisCompletedTabPage.Controls.Add(this.label1);
			this.listParisCompletedTabPage.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listParisCompletedTabPage.Location = new System.Drawing.Point(4, 22);
			this.listParisCompletedTabPage.Name = "listParisCompletedTabPage";
			this.listParisCompletedTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.listParisCompletedTabPage.Size = new System.Drawing.Size(709, 408);
			this.listParisCompletedTabPage.TabIndex = 0;
			this.listParisCompletedTabPage.Text = "Historique des paris";
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.White;
			this.panel5.Controls.Add(this.betsHistoryDataGridView);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(3, 93);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(703, 312);
			this.panel5.TabIndex = 4;
			// 
			// betsHistoryDataGridView
			// 
			this.betsHistoryDataGridView.AllowUserToOrderColumns = true;
			this.betsHistoryDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.betsHistoryDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.betsHistoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.betsHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.betsHistoryDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
			this.betsHistoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.betsHistoryDataGridView.GridColor = System.Drawing.SystemColors.Control;
			this.betsHistoryDataGridView.Location = new System.Drawing.Point(0, 0);
			this.betsHistoryDataGridView.Name = "betsHistoryDataGridView";
			this.betsHistoryDataGridView.Size = new System.Drawing.Size(703, 312);
			this.betsHistoryDataGridView.TabIndex = 2;
			this.betsHistoryDataGridView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.BetsHistoryDataGridViewRowPrePaint);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.White;
			this.panel4.Controls.Add(this.pictureBox3);
			this.panel4.Controls.Add(this.buttonPreviewBet);
			this.panel4.Controls.Add(this.pictureBox2);
			this.panel4.Controls.Add(this.printButtonFileBet);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.panel7);
			this.panel4.Controls.Add(this.panel3);
			this.panel4.Controls.Add(this.panel2);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(3, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(703, 90);
			this.panel4.TabIndex = 3;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(425, 54);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(23, 20);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 35;
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
			this.buttonPreviewBet.Location = new System.Drawing.Point(412, 44);
			this.buttonPreviewBet.Name = "buttonPreviewBet";
			this.buttonPreviewBet.Size = new System.Drawing.Size(141, 39);
			this.buttonPreviewBet.TabIndex = 34;
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
			this.pictureBox2.Location = new System.Drawing.Point(572, 54);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(23, 20);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 33;
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
			this.printButtonFileBet.Location = new System.Drawing.Point(559, 44);
			this.printButtonFileBet.Name = "printButtonFileBet";
			this.printButtonFileBet.Size = new System.Drawing.Size(141, 39);
			this.printButtonFileBet.TabIndex = 30;
			this.printButtonFileBet.Text = "Imprimer paris";
			this.printButtonFileBet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.printButtonFileBet.UseVisualStyleBackColor = false;
			this.printButtonFileBet.Click += new System.EventHandler(this.PrintButtonFileBetClick);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(259, 44);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 14);
			this.label5.TabIndex = 11;
			this.label5.Text = "LOST";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(133, 44);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 14);
			this.label4.TabIndex = 10;
			this.label4.Text = "WIN";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 14);
			this.label3.TabIndex = 9;
			this.label3.Text = "CANCELLED";
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.LightCoral;
			this.panel7.Location = new System.Drawing.Point(259, 61);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(94, 22);
			this.panel7.TabIndex = 8;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.LightGreen;
			this.panel3.Location = new System.Drawing.Point(133, 61);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(94, 22);
			this.panel3.TabIndex = 7;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.LightYellow;
			this.panel2.Location = new System.Drawing.Point(5, 61);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(94, 22);
			this.panel2.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.SteelBlue;
			this.label2.Location = new System.Drawing.Point(5, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(282, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "Historiques paris";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// listPaymentTabPage
			// 
			this.listPaymentTabPage.BackColor = System.Drawing.Color.White;
			this.listPaymentTabPage.Controls.Add(this.paymentUserDataGridView);
			this.listPaymentTabPage.Controls.Add(this.panel1);
			this.listPaymentTabPage.Location = new System.Drawing.Point(4, 22);
			this.listPaymentTabPage.Name = "listPaymentTabPage";
			this.listPaymentTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.listPaymentTabPage.Size = new System.Drawing.Size(709, 408);
			this.listPaymentTabPage.TabIndex = 2;
			this.listPaymentTabPage.Text = "Historique des paiement";
			// 
			// paymentUserDataGridView
			// 
			this.paymentUserDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.paymentUserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.paymentUserDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.paymentUserDataGridView.Location = new System.Drawing.Point(3, 72);
			this.paymentUserDataGridView.Name = "paymentUserDataGridView";
			this.paymentUserDataGridView.Size = new System.Drawing.Size(703, 333);
			this.paymentUserDataGridView.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pictureBox4);
			this.panel1.Controls.Add(this.buttonPreviewPay);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.printButtonBetPayment);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(703, 69);
			this.panel1.TabIndex = 1;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(383, 24);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(23, 20);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 37;
			this.pictureBox4.TabStop = false;
			// 
			// buttonPreviewPay
			// 
			this.buttonPreviewPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonPreviewPay.BackColor = System.Drawing.Color.Transparent;
			this.buttonPreviewPay.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.buttonPreviewPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPreviewPay.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonPreviewPay.ForeColor = System.Drawing.Color.SteelBlue;
			this.buttonPreviewPay.Location = new System.Drawing.Point(370, 14);
			this.buttonPreviewPay.Name = "buttonPreviewPay";
			this.buttonPreviewPay.Size = new System.Drawing.Size(141, 39);
			this.buttonPreviewPay.TabIndex = 36;
			this.buttonPreviewPay.Text = "Previsualisaer";
			this.buttonPreviewPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonPreviewPay.UseVisualStyleBackColor = false;
			this.buttonPreviewPay.Click += new System.EventHandler(this.ButtonPreviewPayClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(528, 21);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(23, 20);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 32;
			this.pictureBox1.TabStop = false;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.SteelBlue;
			this.label6.Location = new System.Drawing.Point(0, 21);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(361, 32);
			this.label6.TabIndex = 2;
			this.label6.Text = "Historiques des paiements";
			// 
			// printButtonBetPayment
			// 
			this.printButtonBetPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.printButtonBetPayment.BackColor = System.Drawing.Color.SteelBlue;
			this.printButtonBetPayment.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.printButtonBetPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.printButtonBetPayment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.printButtonBetPayment.ForeColor = System.Drawing.Color.White;
			this.printButtonBetPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.printButtonBetPayment.Location = new System.Drawing.Point(517, 12);
			this.printButtonBetPayment.Name = "printButtonBetPayment";
			this.printButtonBetPayment.Size = new System.Drawing.Size(181, 41);
			this.printButtonBetPayment.TabIndex = 31;
			this.printButtonBetPayment.Text = "Imprimer  paiements";
			this.printButtonBetPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.printButtonBetPayment.UseVisualStyleBackColor = false;
			this.printButtonBetPayment.Click += new System.EventHandler(this.PrintButtonBetPaymentClick);
			// 
			// HistoryAdminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(717, 434);
			this.Controls.Add(this.userTabControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "HistoryAdminForm";
			this.Text = "HistoryAdminForm";
			this.userTabControl.ResumeLayout(false);
			this.listParisCompletedTabPage.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.betsHistoryDataGridView)).EndInit();
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.listPaymentTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.paymentUserDataGridView)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
