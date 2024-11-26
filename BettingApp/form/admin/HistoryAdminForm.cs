/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 22/11/2024
 * Heure: 11:20
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using BettingApp.data;
using System.Windows.Forms;
using BettingApp.data.repository;
using BettingApp.utils;
using System.Drawing;

namespace BettingApp.form.admin
{
	/// <summary>
	/// Description of HistoryAdminForm.
	/// </summary>
	public partial class HistoryAdminForm : Form
	{
		BetsRepository betsRepository = new BetsRepository();
		public HistoryAdminForm()
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
			betsRepository.LoadBetSummary(betsHistoryDataGridView, "COMPLETED,CANCELLED");
			betsRepository.LoadPaymentsDataGridView(paymentUserDataGridView);
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
