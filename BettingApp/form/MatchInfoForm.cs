/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 22/11/2024
 * Heure: 07:55
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using BettingApp.data.repository;
using BettingApp.utils;


namespace BettingApp.form
{
	/// <summary>
	/// Description of MatchInfoForm.
	/// </summary>
	public partial class MatchInfoForm : Form
	{
		BetsRepository betsRepository = new BetsRepository();
		public MatchInfoForm(string betId)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			labelIdFiche.Text = betId;
			var style = new StyleForm();
			style.StyleDataGridView(matchBetSummaryDataGridView);
			matchBetSummaryDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			betsRepository.LoadBetMatchSummary(matchBetSummaryDataGridView, betId);
		}
		void MatchBetSummaryDataGridViewRowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
	
			var row = matchBetSummaryDataGridView.Rows[e.RowIndex];

			if (row.Cells["StatutResultatPari"].Value != null) {
				string status = row.Cells["StatutResultatPari"].Value.ToString();

				
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
