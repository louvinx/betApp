/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 22/11/2024
 * Heure: 09:28
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using BettingApp.data;
using System.Windows.Forms;
using BettingApp.data.repository;
using BettingApp.utils;
using System.Drawing;


namespace BettingApp.form.user
{
	/// <summary>
	/// Description of HistoryForm.
	/// </summary>
	public partial class HistoryForm : Form
	{
		BetsRepository betsRepository = new BetsRepository();
		
		public HistoryForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			var style = new StyleForm();
			style.StyleDataGridView(betsHistoryDataGridView);
			style.StyleDataGridView(paymentUserDataGridView);
			betsRepository.LoadBetSummary(betsHistoryDataGridView,"COMPLETED,CANCELLED", AuthenticationRepository.authUser.Code);
			betsRepository.LoadPaymentsDataGridView(paymentUserDataGridView, AuthenticationRepository.authUser.Code);
		}
		

		void BetsHistoryDataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			DataGridViewRow row = betsHistoryDataGridView.Rows[e.RowIndex];
			
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
			if (betsHistoryDataGridView.Rows.Count > 0) {
				DataGridPrinter printer = new DataGridPrinter(betsHistoryDataGridView);
				printer.Print();
			} else {
				MessageBox.Show(
					"Aucune donnée à imprimer !",
					"Information",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);
			}
		}
		
		void PrintButtonBetPaymentClick(object sender, EventArgs e)
		{
			if (paymentUserDataGridView.Rows.Count > 0) {
				DataGridPrinter printer = new DataGridPrinter(paymentUserDataGridView);
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
			if (betsHistoryDataGridView.Rows.Count > 0) {
				DataGridPrinter printer = new DataGridPrinter(betsHistoryDataGridView);
				printer.PrintPreview();
			} else {
				MessageBox.Show(
					"Aucune donnée à afficher !",
					"Information",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);
				
			}
		}
		
		
		void ButtonPreviewPayClick(object sender, EventArgs e)
		{
			if (paymentUserDataGridView.Rows.Count > 0) {
				DataGridPrinter printer = new DataGridPrinter(paymentUserDataGridView);
				printer.PrintPreview();
			} else {
				MessageBox.Show(
					"Aucune donnée à afficher !",
					"Information",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);
				
			}
		}
		
		
		void BetsHistoryDataGridViewRowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			var row = betsHistoryDataGridView.Rows[e.RowIndex];

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
