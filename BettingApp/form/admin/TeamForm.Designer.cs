/*
 * Created by SharpDevelop.
 * User: 1
 * Date: 11/7/2024
 * Time: 7:21 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BettingApp.form.admin
{
	partial class TeamForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.registerTeamTabPage = new System.Windows.Forms.TabPage();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.logoPictureBox = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.typeTeamComboBox = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.UploadImageButton = new System.Windows.Forms.Button();
			this.panel10 = new System.Windows.Forms.Panel();
			this.countryTeamComboBox = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.label10 = new System.Windows.Forms.Label();
			this.addTeamButton = new System.Windows.Forms.Button();
			this.inputEmailPanel = new System.Windows.Forms.Panel();
			this.label11 = new System.Windows.Forms.Label();
			this.nameTeamTextBox = new System.Windows.Forms.TextBox();
			this.personPictureBox = new System.Windows.Forms.PictureBox();
			this.loginLabel = new System.Windows.Forms.Label();
			this.panel14 = new System.Windows.Forms.Panel();
			this.logoTeamPictureBox = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.userTabControl = new System.Windows.Forms.TabControl();
			this.listTeam = new System.Windows.Forms.TabPage();
			this.listTeamPanel = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.teamLogopPictureBox = new System.Windows.Forms.PictureBox();
			this.teamCountryTextBox = new System.Windows.Forms.TextBox();
			this.teamNameTextBox = new System.Windows.Forms.TextBox();
			this.idTeamTextBox = new System.Windows.Forms.TextBox();
			this.teamsDataGridView = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.registerTeamTabPage.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			this.inputEmailPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.personPictureBox)).BeginInit();
			this.panel14.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoTeamPictureBox)).BeginInit();
			this.userTabControl.SuspendLayout();
			this.listTeam.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.teamLogopPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.teamsDataGridView)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// registerTeamTabPage
			// 
			this.registerTeamTabPage.Controls.Add(this.panel7);
			this.registerTeamTabPage.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.registerTeamTabPage.Location = new System.Drawing.Point(4, 22);
			this.registerTeamTabPage.Name = "registerTeamTabPage";
			this.registerTeamTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.registerTeamTabPage.Size = new System.Drawing.Size(773, 480);
			this.registerTeamTabPage.TabIndex = 1;
			this.registerTeamTabPage.Text = "Enregistrer equipe";
			this.registerTeamTabPage.UseVisualStyleBackColor = true;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.White;
			this.panel7.Controls.Add(this.panel3);
			this.panel7.Controls.Add(this.panel2);
			this.panel7.Controls.Add(this.UploadImageButton);
			this.panel7.Controls.Add(this.panel10);
			this.panel7.Controls.Add(this.label10);
			this.panel7.Controls.Add(this.addTeamButton);
			this.panel7.Controls.Add(this.inputEmailPanel);
			this.panel7.Controls.Add(this.loginLabel);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(3, 3);
			this.panel7.MinimumSize = new System.Drawing.Size(759, 400);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(767, 474);
			this.panel7.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.White;
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.logoPictureBox);
			this.panel3.Location = new System.Drawing.Point(12, 222);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(191, 165);
			this.panel3.TabIndex = 31;
			// 
			// logoPictureBox
			// 
			this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
			this.logoPictureBox.Location = new System.Drawing.Point(16, 19);
			this.logoPictureBox.Name = "logoPictureBox";
			this.logoPictureBox.Size = new System.Drawing.Size(159, 130);
			this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.logoPictureBox.TabIndex = 0;
			this.logoPictureBox.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.typeTeamComboBox);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Location = new System.Drawing.Point(12, 141);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(359, 60);
			this.panel2.TabIndex = 30;
			// 
			// typeTeamComboBox
			// 
			this.typeTeamComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.typeTeamComboBox.FormattingEnabled = true;
			this.typeTeamComboBox.Items.AddRange(new object[] {
			"National",
			"Club"});
			this.typeTeamComboBox.Location = new System.Drawing.Point(46, 30);
			this.typeTeamComboBox.Name = "typeTeamComboBox";
			this.typeTeamComboBox.Size = new System.Drawing.Size(308, 24);
			this.typeTeamComboBox.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(15, 4);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(150, 23);
			this.label4.TabIndex = 2;
			this.label4.Text = "Type equipe  :";
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
			// UploadImageButton
			// 
			this.UploadImageButton.BackColor = System.Drawing.Color.Black;
			this.UploadImageButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.UploadImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.UploadImageButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UploadImageButton.ForeColor = System.Drawing.Color.White;
			this.UploadImageButton.Location = new System.Drawing.Point(209, 347);
			this.UploadImageButton.Name = "UploadImageButton";
			this.UploadImageButton.Size = new System.Drawing.Size(139, 40);
			this.UploadImageButton.TabIndex = 29;
			this.UploadImageButton.Text = "Telecharger logo";
			this.UploadImageButton.UseVisualStyleBackColor = false;
			this.UploadImageButton.Click += new System.EventHandler(this.UploadImageButtonClick);
			// 
			// panel10
			// 
			this.panel10.BackColor = System.Drawing.Color.White;
			this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel10.Controls.Add(this.countryTeamComboBox);
			this.panel10.Controls.Add(this.label6);
			this.panel10.Controls.Add(this.pictureBox7);
			this.panel10.Location = new System.Drawing.Point(377, 71);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(359, 60);
			this.panel10.TabIndex = 28;
			// 
			// countryTeamComboBox
			// 
			this.countryTeamComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.countryTeamComboBox.FormattingEnabled = true;
			this.countryTeamComboBox.Items.AddRange(new object[] {
			"Afghanistan",
			"Albania",
			"Algeria",
			"Andorra",
			"Angola",
			"Antigua and Barbuda",
			"Argentina",
			"Armenia",
			"Australia",
			"Austria",
			"Azerbaijan",
			"Bahamas",
			"Bahrain",
			"Bangladesh",
			"Barbados",
			"Belarus",
			"Belgium",
			"Belize",
			"Benin",
			"Bhutan",
			"Bolivia",
			"Bosnia and Herzegovina",
			"Botswana",
			"Brazil",
			"Brunei",
			"Bulgaria",
			"Burkina Faso",
			"Burundi",
			"Cabo Verde",
			"Cambodia",
			"Cameroon",
			"Canada",
			"Central African Republic",
			"Chad",
			"Chile",
			"China",
			"Colombia",
			"Comoros",
			"Costa Rica",
			"Croatia",
			"Cuba",
			"Cyprus",
			"Czech Republic",
			"Democratic Republic of the Congo",
			"Denmark",
			"Djibouti",
			"Dominica",
			"Dominican Republic",
			"Ecuador",
			"Egypt",
			"El Salvador",
			"Equatorial Guinea",
			"Eritrea",
			"Estonia",
			"Eswatini",
			"Ethiopia",
			"Fiji",
			"Finland",
			"France",
			"Gabon",
			"Gambia",
			"Georgia",
			"Germany",
			"Ghana",
			"Greece",
			"Grenada",
			"Guatemala",
			"Guinea",
			"Guinea-Bissau",
			"Guyana",
			"Haiti",
			"Honduras",
			"Hungary",
			"Iceland",
			"India",
			"Indonesia",
			"Iran",
			"Iraq",
			"Ireland",
			"Israel",
			"Italy",
			"Jamaica",
			"Japan",
			"Jordan",
			"Kazakhstan",
			"Kenya",
			"Kiribati",
			"Kuwait",
			"Kyrgyzstan",
			"Laos",
			"Latvia",
			"Lebanon",
			"Lesotho",
			"Liberia",
			"Libya",
			"Liechtenstein",
			"Lithuania",
			"Luxembourg",
			"Madagascar",
			"Malawi",
			"Malaysia",
			"Maldives",
			"Mali",
			"Malta",
			"Marshall Islands",
			"Mauritania",
			"Mauritius",
			"Mexico",
			"Micronesia",
			"Moldova",
			"Monaco",
			"Mongolia",
			"Montenegro",
			"Morocco",
			"Mozambique",
			"Myanmar",
			"Namibia",
			"Nauru",
			"Nepal",
			"Netherlands",
			"New Zealand",
			"Nicaragua",
			"Niger",
			"Nigeria",
			"North Macedonia",
			"Norway",
			"Oman",
			"Pakistan",
			"Palau",
			"Panama",
			"Papua New Guinea",
			"Paraguay",
			"Peru",
			"Philippines",
			"Poland",
			"Portugal",
			"Qatar",
			"Romania",
			"Russia",
			"Rwanda",
			"Saint Kitts and Nevis",
			"Saint Lucia",
			"Saint Vincent and the Grenadines",
			"Samoa",
			"San Marino",
			"Sao Tome and Principe",
			"Saudi Arabia",
			"Senegal",
			"Serbia",
			"Seychelles",
			"Sierra Leone",
			"Singapore",
			"Slovakia",
			"Slovenia",
			"Solomon Islands",
			"Somalia",
			"South Africa",
			"South Korea",
			"South Sudan",
			"Spain",
			"Sri Lanka",
			"Sudan",
			"Suriname",
			"Sweden",
			"Switzerland",
			"Syria",
			"Taiwan",
			"Tajikistan",
			"Tanzania",
			"Thailand",
			"Timor-Leste",
			"Togo",
			"Tonga",
			"Trinidad and Tobago",
			"Tunisia",
			"Turkey",
			"Turkmenistan",
			"Tuvalu",
			"Uganda",
			"Ukraine",
			"United Arab Emirates",
			"United Kingdom",
			"United States",
			"Uruguay",
			"Uzbekistan",
			"Vanuatu",
			"Vatican City",
			"Venezuela",
			"Vietnam",
			"Yemen",
			"Zambia",
			"Zimbabwe"});
			this.countryTeamComboBox.Location = new System.Drawing.Point(45, 26);
			this.countryTeamComboBox.Name = "countryTeamComboBox";
			this.countryTeamComboBox.Size = new System.Drawing.Size(308, 24);
			this.countryTeamComboBox.TabIndex = 32;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(15, 4);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 2;
			this.label6.Text = "pays :";
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(15, 26);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(24, 24);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox7.TabIndex = 0;
			this.pictureBox7.TabStop = false;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Scandia Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.label10.Location = new System.Drawing.Point(144, 13);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(114, 37);
			this.label10.TabIndex = 23;
			this.label10.Text = "Equipe";
			// 
			// addTeamButton
			// 
			this.addTeamButton.BackColor = System.Drawing.Color.SteelBlue;
			this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addTeamButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addTeamButton.ForeColor = System.Drawing.Color.White;
			this.addTeamButton.Location = new System.Drawing.Point(12, 413);
			this.addTeamButton.Name = "addTeamButton";
			this.addTeamButton.Size = new System.Drawing.Size(90, 40);
			this.addTeamButton.TabIndex = 22;
			this.addTeamButton.Text = "Enregistrer";
			this.addTeamButton.UseVisualStyleBackColor = false;
			this.addTeamButton.Click += new System.EventHandler(this.AddTeamButtonClick);
			// 
			// inputEmailPanel
			// 
			this.inputEmailPanel.BackColor = System.Drawing.Color.White;
			this.inputEmailPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.inputEmailPanel.Controls.Add(this.label11);
			this.inputEmailPanel.Controls.Add(this.nameTeamTextBox);
			this.inputEmailPanel.Controls.Add(this.personPictureBox);
			this.inputEmailPanel.Location = new System.Drawing.Point(12, 71);
			this.inputEmailPanel.Name = "inputEmailPanel";
			this.inputEmailPanel.Size = new System.Drawing.Size(359, 60);
			this.inputEmailPanel.TabIndex = 21;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(15, 4);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 23);
			this.label11.TabIndex = 2;
			this.label11.Text = "Nom equipe :";
			// 
			// nameTeamTextBox
			// 
			this.nameTeamTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.nameTeamTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameTeamTextBox.ForeColor = System.Drawing.Color.Black;
			this.nameTeamTextBox.Location = new System.Drawing.Point(46, 30);
			this.nameTeamTextBox.Name = "nameTeamTextBox";
			this.nameTeamTextBox.Size = new System.Drawing.Size(289, 20);
			this.nameTeamTextBox.TabIndex = 1;
			// 
			// personPictureBox
			// 
			this.personPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("personPictureBox.Image")));
			this.personPictureBox.Location = new System.Drawing.Point(15, 30);
			this.personPictureBox.Name = "personPictureBox";
			this.personPictureBox.Size = new System.Drawing.Size(24, 20);
			this.personPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.personPictureBox.TabIndex = 0;
			this.personPictureBox.TabStop = false;
			// 
			// loginLabel
			// 
			this.loginLabel.BackColor = System.Drawing.Color.Transparent;
			this.loginLabel.Font = new System.Drawing.Font("Scandia Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginLabel.ForeColor = System.Drawing.Color.SteelBlue;
			this.loginLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.loginLabel.Location = new System.Drawing.Point(3, 13);
			this.loginLabel.Name = "loginLabel";
			this.loginLabel.Size = new System.Drawing.Size(175, 37);
			this.loginLabel.TabIndex = 20;
			this.loginLabel.Text = "Enregister";
			// 
			// panel14
			// 
			this.panel14.BackColor = System.Drawing.Color.White;
			this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel14.Controls.Add(this.logoTeamPictureBox);
			this.panel14.Controls.Add(this.label3);
			this.panel14.Location = new System.Drawing.Point(12, 207);
			this.panel14.Name = "panel14";
			this.panel14.Size = new System.Drawing.Size(180, 180);
			this.panel14.TabIndex = 24;
			// 
			// logoTeamPictureBox
			// 
			this.logoTeamPictureBox.Location = new System.Drawing.Point(15, 30);
			this.logoTeamPictureBox.Name = "logoTeamPictureBox";
			this.logoTeamPictureBox.Size = new System.Drawing.Size(150, 130);
			this.logoTeamPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.logoTeamPictureBox.TabIndex = 3;
			this.logoTeamPictureBox.TabStop = false;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(15, 4);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Logo :";
			// 
			// userTabControl
			// 
			this.userTabControl.Controls.Add(this.listTeam);
			this.userTabControl.Controls.Add(this.registerTeamTabPage);
			this.userTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.userTabControl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.userTabControl.ItemSize = new System.Drawing.Size(81, 18);
			this.userTabControl.Location = new System.Drawing.Point(0, 0);
			this.userTabControl.Name = "userTabControl";
			this.userTabControl.SelectedIndex = 0;
			this.userTabControl.Size = new System.Drawing.Size(781, 506);
			this.userTabControl.TabIndex = 4;
			// 
			// listTeam
			// 
			this.listTeam.Controls.Add(this.listTeamPanel);
			this.listTeam.Controls.Add(this.panel4);
			this.listTeam.Location = new System.Drawing.Point(4, 22);
			this.listTeam.Name = "listTeam";
			this.listTeam.Padding = new System.Windows.Forms.Padding(3);
			this.listTeam.Size = new System.Drawing.Size(773, 480);
			this.listTeam.TabIndex = 2;
			this.listTeam.Text = "Listes equipes";
			this.listTeam.UseVisualStyleBackColor = true;
			// 
			// listTeamPanel
			// 
			this.listTeamPanel.AutoScroll = true;
			this.listTeamPanel.BackColor = System.Drawing.Color.White;
			this.listTeamPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listTeamPanel.Location = new System.Drawing.Point(3, 68);
			this.listTeamPanel.Name = "listTeamPanel";
			this.listTeamPanel.Size = new System.Drawing.Size(767, 409);
			this.listTeamPanel.TabIndex = 1;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.White;
			this.panel4.Controls.Add(this.label1);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(3, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(767, 65);
			this.panel4.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Scandia Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.label1.Location = new System.Drawing.Point(76, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 37);
			this.label1.TabIndex = 25;
			this.label1.Text = "Equipe";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Scandia Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.SteelBlue;
			this.label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.label5.Location = new System.Drawing.Point(5, 11);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 37);
			this.label5.TabIndex = 24;
			this.label5.Text = "Liste";
			// 
			// teamLogopPictureBox
			// 
			this.teamLogopPictureBox.Location = new System.Drawing.Point(0, 0);
			this.teamLogopPictureBox.Name = "teamLogopPictureBox";
			this.teamLogopPictureBox.Size = new System.Drawing.Size(100, 50);
			this.teamLogopPictureBox.TabIndex = 0;
			this.teamLogopPictureBox.TabStop = false;
			// 
			// teamCountryTextBox
			// 
			this.teamCountryTextBox.Location = new System.Drawing.Point(0, 0);
			this.teamCountryTextBox.Name = "teamCountryTextBox";
			this.teamCountryTextBox.Size = new System.Drawing.Size(100, 20);
			this.teamCountryTextBox.TabIndex = 0;
			// 
			// teamNameTextBox
			// 
			this.teamNameTextBox.Location = new System.Drawing.Point(0, 0);
			this.teamNameTextBox.Name = "teamNameTextBox";
			this.teamNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.teamNameTextBox.TabIndex = 0;
			// 
			// idTeamTextBox
			// 
			this.idTeamTextBox.Location = new System.Drawing.Point(0, 0);
			this.idTeamTextBox.Name = "idTeamTextBox";
			this.idTeamTextBox.Size = new System.Drawing.Size(100, 20);
			this.idTeamTextBox.TabIndex = 0;
			// 
			// teamsDataGridView
			// 
			this.teamsDataGridView.AllowUserToOrderColumns = true;
			this.teamsDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.teamsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.teamsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.teamsDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
			this.teamsDataGridView.GridColor = System.Drawing.SystemColors.Control;
			this.teamsDataGridView.Location = new System.Drawing.Point(3, 71);
			this.teamsDataGridView.Name = "teamsDataGridView";
			this.teamsDataGridView.Size = new System.Drawing.Size(767, 406);
			this.teamsDataGridView.TabIndex = 27;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(767, 68);
			this.panel1.TabIndex = 26;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Scandia Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.SteelBlue;
			this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.label2.Location = new System.Drawing.Point(5, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 37);
			this.label2.TabIndex = 24;
			this.label2.Text = "Listes";
			// 
			// TeamForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(781, 506);
			this.Controls.Add(this.userTabControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "TeamForm";
			this.Text = "TeamForm";
			this.registerTeamTabPage.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel10.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			this.inputEmailPanel.ResumeLayout(false);
			this.inputEmailPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.personPictureBox)).EndInit();
			this.panel14.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.logoTeamPictureBox)).EndInit();
			this.userTabControl.ResumeLayout(false);
			this.listTeam.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.teamLogopPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.teamsDataGridView)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.ComboBox countryTeamComboBox;
		private System.Windows.Forms.TextBox idTeamTextBox;
		private System.Windows.Forms.TextBox teamNameTextBox;
		private System.Windows.Forms.TextBox teamCountryTextBox;
		private System.Windows.Forms.PictureBox teamLogopPictureBox;
		private System.Windows.Forms.Panel listTeamPanel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TabPage listTeam;
		private System.Windows.Forms.PictureBox logoPictureBox;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox typeTeamComboBox;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView teamsDataGridView;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button UploadImageButton;
	    private System.Windows.Forms.PictureBox logoTeamPictureBox;
		private System.Windows.Forms.Label loginLabel;
		private System.Windows.Forms.PictureBox personPictureBox;
		private System.Windows.Forms.TextBox nameTeamTextBox;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Panel inputEmailPanel;
		private System.Windows.Forms.Button addTeamButton;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel14;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.TabPage registerTeamTabPage;
		private System.Windows.Forms.TabControl userTabControl;
	}
}
