using System;
using System.Windows.Forms;

namespace BettingApp.form.user
{
    public partial class DashboardUserIndexForm : Form
    {
//        public DashboardUserIndexForm()
//        {
//            InitializeComponent();
//        }

        private void InitializeComponent()
        {
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardUserIndexForm));
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.panel3 = new System.Windows.Forms.Panel();
        	this.pictureBox1 = new System.Windows.Forms.PictureBox();
        	this.label = new System.Windows.Forms.Label();
        	this.labelName = new System.Windows.Forms.Label();
        	this.panel4 = new System.Windows.Forms.Panel();
        	this.pictureBox5 = new System.Windows.Forms.PictureBox();
        	this.soldeLabel = new System.Windows.Forms.Label();
        	this.matchPendingdataGridView = new System.Windows.Forms.DataGridView();
        	this.panel6 = new System.Windows.Forms.Panel();
        	this.panel7 = new System.Windows.Forms.Panel();
        	this.panel8 = new System.Windows.Forms.Panel();
        	this.pictureBox6 = new System.Windows.Forms.PictureBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.panel1.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        	this.panel4.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.matchPendingdataGridView)).BeginInit();
        	this.panel6.SuspendLayout();
        	this.panel7.SuspendLayout();
        	this.panel8.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// panel1
        	// 
        	this.panel1.BackColor = System.Drawing.Color.Transparent;
        	this.panel1.Controls.Add(this.panel3);
        	this.panel1.Controls.Add(this.pictureBox1);
        	this.panel1.Controls.Add(this.label);
        	this.panel1.Controls.Add(this.labelName);
        	this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
        	this.panel1.Location = new System.Drawing.Point(0, 0);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(803, 46);
        	this.panel1.TabIndex = 0;
        	// 
        	// panel3
        	// 
        	this.panel3.BackColor = System.Drawing.Color.Black;
        	this.panel3.Location = new System.Drawing.Point(12, 2);
        	this.panel3.Name = "panel3";
        	this.panel3.Size = new System.Drawing.Size(5, 38);
        	this.panel3.TabIndex = 3;
        	// 
        	// pictureBox1
        	// 
        	this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        	this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
        	this.pictureBox1.Location = new System.Drawing.Point(477, 15);
        	this.pictureBox1.Name = "pictureBox1";
        	this.pictureBox1.Size = new System.Drawing.Size(24, 23);
        	this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        	this.pictureBox1.TabIndex = 2;
        	this.pictureBox1.TabStop = false;
        	// 
        	// label
        	// 
        	this.label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        	this.label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label.ForeColor = System.Drawing.Color.Black;
        	this.label.Location = new System.Drawing.Point(507, 16);
        	this.label.Name = "label";
        	this.label.Size = new System.Drawing.Size(284, 23);
        	this.label.TabIndex = 1;
        	this.label.Text = "Date";
        	// 
        	// labelName
        	// 
        	this.labelName.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.labelName.ForeColor = System.Drawing.Color.Black;
        	this.labelName.Location = new System.Drawing.Point(22, 2);
        	this.labelName.Name = "labelName";
        	this.labelName.Size = new System.Drawing.Size(435, 37);
        	this.labelName.TabIndex = 0;
        	this.labelName.Text = "Nom de l\'utilisateur";
        	// 
        	// panel4
        	// 
        	this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
        	this.panel4.Controls.Add(this.pictureBox5);
        	this.panel4.Controls.Add(this.soldeLabel);
        	this.panel4.Location = new System.Drawing.Point(22, 15);
        	this.panel4.Name = "panel4";
        	this.panel4.Size = new System.Drawing.Size(769, 283);
        	this.panel4.TabIndex = 3;
        	// 
        	// pictureBox5
        	// 
        	this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
        	this.pictureBox5.Location = new System.Drawing.Point(3, 3);
        	this.pictureBox5.Name = "pictureBox5";
        	this.pictureBox5.Size = new System.Drawing.Size(136, 128);
        	this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        	this.pictureBox5.TabIndex = 5;
        	this.pictureBox5.TabStop = false;
        	// 
        	// soldeLabel
        	// 
        	this.soldeLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.soldeLabel.Location = new System.Drawing.Point(145, 93);
        	this.soldeLabel.Name = "soldeLabel";
        	this.soldeLabel.Size = new System.Drawing.Size(255, 23);
        	this.soldeLabel.TabIndex = 3;
        	this.soldeLabel.Text = "Solde : 0.00 ";
        	// 
        	// matchPendingdataGridView
        	// 
        	this.matchPendingdataGridView.BackgroundColor = System.Drawing.Color.White;
        	this.matchPendingdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.matchPendingdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.matchPendingdataGridView.Location = new System.Drawing.Point(0, 58);
        	this.matchPendingdataGridView.Name = "matchPendingdataGridView";
        	this.matchPendingdataGridView.Size = new System.Drawing.Size(803, 14);
        	this.matchPendingdataGridView.TabIndex = 5;
        	// 
        	// panel6
        	// 
        	this.panel6.Controls.Add(this.panel4);
        	this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
        	this.panel6.Location = new System.Drawing.Point(0, 46);
        	this.panel6.Name = "panel6";
        	this.panel6.Size = new System.Drawing.Size(803, 318);
        	this.panel6.TabIndex = 6;
        	// 
        	// panel7
        	// 
        	this.panel7.Controls.Add(this.matchPendingdataGridView);
        	this.panel7.Controls.Add(this.panel8);
        	this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.panel7.Location = new System.Drawing.Point(0, 364);
        	this.panel7.Name = "panel7";
        	this.panel7.Size = new System.Drawing.Size(803, 72);
        	this.panel7.TabIndex = 7;
        	// 
        	// panel8
        	// 
        	this.panel8.Controls.Add(this.pictureBox6);
        	this.panel8.Controls.Add(this.label1);
        	this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
        	this.panel8.Location = new System.Drawing.Point(0, 0);
        	this.panel8.Name = "panel8";
        	this.panel8.Size = new System.Drawing.Size(803, 58);
        	this.panel8.TabIndex = 6;
        	// 
        	// pictureBox6
        	// 
        	this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
        	this.pictureBox6.Location = new System.Drawing.Point(12, 6);
        	this.pictureBox6.Name = "pictureBox6";
        	this.pictureBox6.Size = new System.Drawing.Size(22, 20);
        	this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        	this.pictureBox6.TabIndex = 7;
        	this.pictureBox6.TabStop = false;
        	// 
        	// label1
        	// 
        	this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.ForeColor = System.Drawing.Color.Black;
        	this.label1.Location = new System.Drawing.Point(34, 3);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(313, 31);
        	this.label1.TabIndex = 1;
        	this.label1.Text = "Listes des match en cours";
        	// 
        	// DashboardUserIndexForm
        	// 
        	this.BackColor = System.Drawing.Color.White;
        	this.ClientSize = new System.Drawing.Size(803, 436);
        	this.Controls.Add(this.panel7);
        	this.Controls.Add(this.panel6);
        	this.Controls.Add(this.panel1);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        	this.Name = "DashboardUserIndexForm";
        	this.Text = "Dashboard";
        	this.panel1.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        	this.panel4.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.matchPendingdataGridView)).EndInit();
        	this.panel6.ResumeLayout(false);
        	this.panel7.ResumeLayout(false);
        	this.panel8.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
        	this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label soldeLabel;
        private System.Windows.Forms.DataGridView matchPendingdataGridView;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}
