/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 23/11/2024
 * Heure: 17:02
 *
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BettingApp.data
{
	public class BetDetailsPrinter
	{
		private PrintDocument printDocument;
		private string betId;
		private DataTable betData;
		private DataTable matchesData;

		private DatabaseManager dbManager;

		public BetDetailsPrinter(string betId)
		{
			this.betId = betId;
			this.printDocument = new PrintDocument();
			dbManager = new DatabaseManager();
			printDocument.PrintPage += PrintPage;
			LoadData();
		}

		private void LoadData()
		{
			var connection = dbManager.GetConnection();

			string betQuery = @"
            SELECT
                b.BetId,
                b.BetDate,
                b.TotalAmount,
                b.Status,
                b.WinStatus,
                u.FirstName,
                u.LastName,
                u.Username,
                SUM(p.Amount) as WinningAmount
            FROM Bets b
            JOIN Users u ON b.UserId = u.Code
            LEFT JOIN Payments p ON b.BetId = p.BetId
            WHERE b.BetId = @BetId
			GROUP BY b.BetId";

			string matchesQuery = @"
            SELECT
                m.MatchId,
                m.MatchType,
                m.Country,
                m.MatchDate,
                m.MatchTime,
                m.FinalScore,
                ht.TeamName as HomeTeam,
                at.TeamName as AwayTeam,
                m.HomeWinOdds,
                m.DrawOdds,
                m.AwayWinOdds,
                bd.OddValue,
                pt.TeamName as PredictedTeam,
                bd.WinStatus as PredictionResult
            FROM BetDetails bd
            JOIN Matches m ON bd.MatchId = m.MatchId
            JOIN Teams ht ON m.HomeTeamId = ht.TeamId
            JOIN Teams at ON m.AwayTeamId = at.TeamId
            LEFT JOIN Teams pt ON bd.PredictedTeamWinner = pt.TeamId
            WHERE bd.BetId = @BetId
            ORDER BY m.MatchDate, m.MatchTime";

			using (MySqlCommand betCmd = new MySqlCommand(betQuery, connection)) {
				betCmd.Parameters.AddWithValue("@BetId", betId);
				using (MySqlDataAdapter betAdapter = new MySqlDataAdapter(betCmd)) {
					betData = new DataTable();
					betAdapter.Fill(betData);
				}
			}

			using (MySqlCommand matchesCmd = new MySqlCommand(matchesQuery, connection)) {
				matchesCmd.Parameters.AddWithValue("@BetId", betId);
				using (MySqlDataAdapter matchesAdapter = new MySqlDataAdapter(matchesCmd)) {
					matchesData = new DataTable();
					matchesAdapter.Fill(matchesData);
				}
			}
		}

		private void PrintPage(object sender, PrintPageEventArgs e)
		{
			if (betData.Rows.Count == 0)
				return;

			var row = betData.Rows[0];
			int yPos = 50;
			int leftMargin = 50;
			int rightMargin = e.PageBounds.Width - 50;

			Font titleFont = new Font("Segoe UI", 16, FontStyle.Bold);
			Font headerFont = new Font("Segoe UI", 12, FontStyle.Bold);
			Font normalFont = new Font("Segoe UI", 10);
			Font smallFont = new Font("Segoe UI", 9);

			string title = "FICHE DE PARI GAGNANT";
			e.Graphics.DrawString(title, titleFont, Brushes.Black,
				(e.PageBounds.Width - e.Graphics.MeasureString(title, titleFont).Width) / 2, yPos);
			yPos += 40;

			e.Graphics.DrawString("Date: " + Convert.ToDateTime(row["BetDate"]).ToString("dd/MM/yyyy HH:mm"),
				normalFont, Brushes.Black, leftMargin, yPos);
			e.Graphics.DrawString("N° Pari: " + row["BetId"].ToString(),
				normalFont, Brushes.Black, rightMargin - 200, yPos);
			yPos += 30;

			DrawSection(e, "INFORMATIONS DU PARIEUR", headerFont, ref yPos);
			yPos += 10;
			e.Graphics.DrawString("Nom: " + row["LastName"] + " " + row["FirstName"],
				normalFont, Brushes.Black, leftMargin + 20, yPos);
			yPos += 20;
			e.Graphics.DrawString("Nom d'utilisateur: " + row["Username"],
				normalFont, Brushes.Black, leftMargin + 20, yPos);
			yPos += 30;

			DrawSection(e, "DÉTAILS FINANCIERS", headerFont, ref yPos);
			yPos += 10;
			e.Graphics.DrawString("Montant parié: " + Convert.ToDecimal(row["TotalAmount"]).ToString("C2"),
				normalFont, Brushes.Black, leftMargin + 20, yPos);
			yPos += 20;
			e.Graphics.DrawString("Gains: " + Convert.ToDecimal(row["WinningAmount"]).ToString("C2"),
				normalFont, Brushes.Black, leftMargin + 20, yPos);
			yPos += 30;

			DrawSection(e, "DÉTAILS DES MATCHES", headerFont, ref yPos);
			yPos += 10;

			foreach (DataRow match in matchesData.Rows) {
				Rectangle matchRect = new Rectangle(leftMargin, yPos, rightMargin - leftMargin, 100);
				e.Graphics.DrawRectangle(Pens.Gray, matchRect);

				e.Graphics.DrawString(match["HomeTeam"] + " vs " + match["AwayTeam"],
					normalFont, Brushes.Black, leftMargin + 10, yPos + 10);
				e.Graphics.DrawString("Date: " + Convert.ToDateTime(match["MatchDate"]).ToString("dd/MM/yyyy") + " " + match["MatchTime"],
					smallFont, Brushes.Black, leftMargin + 10, yPos + 30);
				e.Graphics.DrawString("Type: " + match["MatchType"],
					smallFont, Brushes.Black, leftMargin + 10, yPos + 50);
				e.Graphics.DrawString("Pronostic: " + match["PredictedTeam"],
					normalFont, Brushes.Black, leftMargin + 300, yPos + 10);
				e.Graphics.DrawString("Cote: " + match["OddValue"],
					normalFont, Brushes.Black, leftMargin + 300, yPos + 30);

				string result = match["PredictionResult"].ToString();
				Brush resultBrush = result == "WON" ? Brushes.Green : Brushes.Red;
				e.Graphics.DrawString("Résultat: " + result,
					normalFont, resultBrush, leftMargin + 300, yPos + 50);

				yPos += 110;
			}

			string footer = "Imprimé le " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");
			e.Graphics.DrawString(footer, smallFont, Brushes.Gray,
				(e.PageBounds.Width - e.Graphics.MeasureString(footer, smallFont).Width) / 2,
				e.PageBounds.Height - 50);

			e.HasMorePages = false;
		}

		private void DrawSection(PrintPageEventArgs e, string title, Font font, ref int yPos)
		{
			e.Graphics.DrawString(title, font, Brushes.Black, 50, yPos);
			yPos += 25;
			e.Graphics.DrawLine(Pens.Gray, 50, yPos - 5, e.PageBounds.Width - 50, yPos - 5);
		}


		public void Print()
		{
			using (PrintDialog printDialog = new PrintDialog()) {
				printDialog.Document = printDocument;
				if (printDialog.ShowDialog() == DialogResult.OK) {
					try {
						printDocument.Print();
					} catch (Exception ex) {
						MessageBox.Show("Erreur d'impression: " + ex.Message);
					}
				}
			}
		}
	}
}
