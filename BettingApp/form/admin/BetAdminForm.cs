/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 21/11/2024
 * Heure: 15:13
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Windows.Forms;
using BettingApp.data.repository;
using BettingApp.form;
using BettingApp.utils;
using BettingApp.utils.validation;
using System.Drawing;

namespace BettingApp.form.admin
{
	/// <summary>
	/// Description of ParisForm.
	/// </summary>
	public partial class BetAdminForm : Form
	{
		MatchValidation matchValidation = new MatchValidation();
		TeamRepository teamRepository = new TeamRepository();
		MatchRepository matchRepository = new MatchRepository();
		BetsRepository betsRepository = new BetsRepository();
		public BetAdminForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			var style = new StyleForm();
			style.StyleDataGridView(betsDataGridView);
			style.StyleDataGridView(betsPendingDataGridView);
			betsRepository.LoadPendingBetSummary(betsPendingDataGridView);
			betsRepository.LoadAllBetSummary(betsDataGridView);
			
		}
		
	
		
		void BetsPendingDataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
		{
			
			if (e.RowIndex < 0)
				return;

			DataGridViewRow row = betsPendingDataGridView.Rows[e.RowIndex];
			
			if (row.Cells["BetId"].Value != null) {
				Form existingForm = Application.OpenForms["MatchInfoForm"];
				if (existingForm != null) {
					existingForm.Close();
				}
				string betId = row.Cells["BetId"].Value.ToString();
				MatchInfoForm matchInfoForm = new MatchInfoForm(betId);
				matchInfoForm.Show();
			}
		}

		void BetsDataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
		{
			
			if (e.RowIndex < 0)
				return;

			DataGridViewRow row = betsDataGridView.Rows[e.RowIndex];
			
			if (row.Cells["BetId"].Value != null) {
				Form existingForm = Application.OpenForms["MatchInfoForm"];
				if (existingForm != null) {
					existingForm.Close();
				}
				string betId = row.Cells["BetId"].Value.ToString();
				MatchInfoForm matchInfoForm = new MatchInfoForm(betId);
				matchInfoForm.Show();
			}
		}
		
		
				
		void BetsDataGridViewRowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			var row = betsDataGridView.Rows[e.RowIndex];
			if (row.Cells["WinStatus"].Value != null) {
				string status = row.Cells["WinStatus"].Value.ToString();

				
				switch (status) {
					case "PENDING":
						row.DefaultCellStyle.BackColor = Color.LightYellow;
						break;

					case "WON":
						row.DefaultCellStyle.BackColor = Color.LightGreen;
						break;

					case "LOST":
						row.DefaultCellStyle.BackColor = Color.LightCoral;
						break;

					default:
						row.DefaultCellStyle.BackColor = Color.White;
						break;
				}
			}
		}

		
	}
}
