/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 19/11/2024
 * Heure: 18:18
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Windows.Forms;
using System.Drawing;
using BettingApp.data.repository;
using BettingApp.utils;

namespace BettingApp.form.user
{
	/// <summary>
	/// Description of DashboardUserIndexForm.
	/// </summary>
	public partial class DashboardUserIndexForm : Form
	{
		TeamRepository teamRepository = new TeamRepository();
		MatchRepository matchRepository = new MatchRepository();
		BetsRepository betsRepository = new BetsRepository();
		
		public DashboardUserIndexForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			var style = new StyleForm();
			style.StyleDataGridView(matchPendingdataGridView);
			labelName.Text = "Bienvenue " + AuthenticationRepository.authUser.FirstName + " " + AuthenticationRepository.authUser.LastName;
			soldeLabel.Text = "Solde : " + AuthenticationRepository.authUser.Balance + "HTG";
			label.Text = DateTime.Now.ToString("dddd dd MMMM yyyy");
			matchRepository.LoadMatchDetailsInDataGridView(matchPendingdataGridView);
			matchPendingdataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
			matchPendingdataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
			matchPendingdataGridView.GridColor = Color.White;	
			matchPendingdataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic Semibold", 10.75F);
			matchPendingdataGridView.DefaultCellStyle.Font = new Font("Century Gothic", 10F);
		}

	}
}



