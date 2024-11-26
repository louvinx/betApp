/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 20/11/2024
 * Heure: 14:22
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Windows.Forms;
using BettingApp.data.repository;
using BettingApp.data;
using BettingApp.utils;
using BettingApp.utils.validation;

namespace BettingApp.form.user
{
	/// <summary>
	/// Description of BetForm.
	/// </summary>
	public partial class BetForm : Form
	{
		MatchValidation matchValidation = new MatchValidation();
		TeamRepository teamRepository = new TeamRepository();
		MatchRepository matchRepository = new MatchRepository();
		BetsRepository betsRepository = new BetsRepository();
		public BetForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			var style = new StyleForm();
			style.StyleDataGridView(betDataGridView);
			betsRepository.LoadBetSummary(betDataGridView,"PENDING", AuthenticationRepository.authUser.Code);
		}
		
		void BetDataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			DataGridViewRow row = betDataGridView.Rows[e.RowIndex];
			
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

		
		void PrintButtonFileBetClick(object sender, EventArgs e)
		{
			if (betDataGridView.Rows.Count > 0) {
				DataGridPrinter printer = new DataGridPrinter(betDataGridView);
				printer.Print();
			} else {
				MessageBox.Show(
					"Aucune donnée à imprimer !",
					"Information",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);
			}
		}
				
		void ButtonPreviewBetClick(object sender, EventArgs e)
		{
			if (betDataGridView.Rows.Count > 0) {
				DataGridPrinter printer = new DataGridPrinter(betDataGridView);
				printer.PrintPreview();
			} else {
				MessageBox.Show(
					"Aucune donnée à afficher !",
					"Information",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);
				
			}
		}
		
	}
}
