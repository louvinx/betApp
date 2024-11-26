/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 19/11/2024
 * Heure: 18:16
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using BettingApp.data.repository;
using BettingApp.model;
using BettingApp.utils;
using BettingApp.utils.validation;
using System.Collections.Generic;


namespace BettingApp.form.user
{
	public partial class UserMatchForm : Form
	{
		private List<BetDetail> pendingBets = new List<BetDetail>();
		MatchValidation matchValidation = new MatchValidation();
		TeamRepository teamRepository = new TeamRepository();
		MatchRepository matchRepository = new MatchRepository();
		BetsRepository betsRepository = new BetsRepository();
		UserRepository userRepository = new UserRepository();
		string betId = null;
		decimal betAmount = 0;

		public UserMatchForm()
		{
			InitializeComponent();

			var style = new StyleForm();
			style.StyleDataGridView(matchUsersDataGridView);
			matchRepository.LoadMatchesInDataGridView(matchUsersDataGridView);
		}

		


		private string GenerateUniqueBetId()
		{
			return "BET-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + Guid.NewGuid().ToString().Substring(0, 5);
		}

		void ButtonCreateBetClick(object sender, EventArgs e)
		{
			decimal betAmontToday = userRepository.GetUserTotalBetAmountForToday(AuthenticationRepository.authUser.Code);
			if (betAmontToday < 75000m) {
				Form inputForm = new Form {
					Text = "Confirmation de création de pari",
					Size = new Size(300, 180),
					FormBorderStyle = FormBorderStyle.FixedDialog,
					StartPosition = FormStartPosition.CenterScreen
				};

				Label lblAmount = new Label {
					Text = "Entrez le montant du pari :",
					Location = new Point(20, 20),
					AutoSize = true
				};

				TextBox txtAmount = new TextBox {
					Location = new Point(20, 50),
					Size = new Size(250, 25)
				};

				Button btnConfirm = new Button {
					Text = "Confirmer",
					DialogResult = DialogResult.OK,
					Location = new Point(120, 100)
				};

				Button btnCancel = new Button {
					Text = "Annuler",
					DialogResult = DialogResult.Cancel,
					Location = new Point(195, 100)
				};

				inputForm.Controls.AddRange(new Control[] {
				                            	lblAmount,
				                            	txtAmount,
				                            	btnConfirm,
				                            	btnCancel
				                            });
				inputForm.AcceptButton = btnConfirm;
				inputForm.CancelButton = btnCancel;

				inputForm.FormClosing += (s, ev) => {
					if (inputForm.DialogResult == DialogResult.OK) {
						try {
							betAmount = decimal.Parse(txtAmount.Text.Trim());
							if (betAmount <= 0) {
								throw new Exception("Le montant doit être supérieur à zéro.");
							}
							if (betAmount >= AuthenticationRepository.authUser.Balance) {
								throw new Exception("Le montant du pari est supérieur à la balance de votre compte.");
							}
							if ((betAmount + betAmontToday) > 75000m) {
								throw new Exception("Un client ne peut pas dépasser le total de 75000 gourdes de pari pour une journée!!, vous pouvez parier seulement pour : " + (75000m - betAmontToday));
							}
						} catch (Exception ex) {
							MessageBox.Show("Veuillez entrer un montant valide." + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
							ev.Cancel = true;
						}
					}
				};

				if (inputForm.ShowDialog() == DialogResult.OK) {
					betAmount = decimal.Parse(txtAmount.Text);

					DialogResult result = MessageBox.Show(
						"Êtes-vous sûr de vouloir créer un pari de " + betAmount + " ? Cette action est irréversible.",
						"Confirmation",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question
					);

					if (result == DialogResult.Yes) {
						try {
							betId = GenerateUniqueBetId();
							Bet newBet = new Bet {
								BetId = betId,
								UserId = AuthenticationRepository.authUser.Code,
								TotalAmount = betAmount,
								Status = "PENDING"
							};

							bool success = betsRepository.CreateBet(newBet);
							if (success) {
								labelBetNow.Text = newBet.ToString();
								labelBetNow.Visible = true;
								MessageBox.Show(
									"Le pari de " + betAmount + " a été créé avec succès !",
									"Succès",
									MessageBoxButtons.OK,
									MessageBoxIcon.Information
								);
							} else {
								MessageBox.Show(
									"Une erreur s'est produite lors de la création du pari.",
									"Erreur",
									MessageBoxButtons.OK,
									MessageBoxIcon.Error
								);
							}
						} catch (Exception ex) {
							MessageBox.Show(
								"Une erreur inattendue s'est produite : " + ex.Message,
								"Erreur",
								MessageBoxButtons.OK,
								MessageBoxIcon.Error
							);
						}
					}
				}
			} else {
				MessageBox.Show(
					"Un client ne peut pas dépasser le total de 75000 gourdes de pari pour une journée!! ",
					"Erreur limite atteinte",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
		}

		
		private void MatchUsersDataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			if (e.ColumnIndex == matchUsersDataGridView.Columns["HomeOddsButton"].Index ||
			    e.ColumnIndex == matchUsersDataGridView.Columns["AwayOddsButton"].Index ||
			    e.ColumnIndex == matchUsersDataGridView.Columns["DrawOddsButton"].Index) {
				DataGridViewRow row = matchUsersDataGridView.Rows[e.RowIndex];
				string matchId = row.Cells["MatchId"].Value.ToString();
				int? predictedTeamWinnerId = null;
				decimal oddValue = 0;

				if (e.ColumnIndex == matchUsersDataGridView.Columns["HomeOddsButton"].Index) {
					predictedTeamWinnerId = teamRepository.GetTeam(row.Cells["HomeTeamName"].Value.ToString()).TeamID;
					oddValue = Convert.ToDecimal(row.Cells["HomeOddsButton"].Value);
				} else if (e.ColumnIndex == matchUsersDataGridView.Columns["AwayOddsButton"].Index) {
					predictedTeamWinnerId = teamRepository.GetTeam(row.Cells["AwayTeamName"].Value.ToString()).TeamID;
					oddValue = Convert.ToDecimal(row.Cells["AwayOddsButton"].Value);
				} else if (e.ColumnIndex == matchUsersDataGridView.Columns["DrawOddsButton"].Index) {
					predictedTeamWinnerId = null;
					oddValue = Convert.ToDecimal(row.Cells["DrawOddsButton"].Value);
				}

				if(betId != null){
				BetDetail betDetail = new BetDetail {
					BetId = betId,
					MatchId = matchId,
					PredictedTeamWinner = predictedTeamWinnerId,
					OddValue = oddValue
				};
				if (row.Cells["HomeOddsButton"].Tag != "isBetting") {
					
					pendingBets.Add(betDetail);
					row.DefaultCellStyle.BackColor = Color.SteelBlue;
					row.DefaultCellStyle.ForeColor = Color.White;
					row.ReadOnly = true;
					row.Cells["HomeOddsButton"].Tag = "isBetting";
					row.Cells["DrawOddsButton"].Tag = "isBetting";
					row.Cells["AwayOddsButton"].Tag = "isBetting";

					MessageBox.Show("Pari ajouté dans la liste temporaire.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				} else {
					
					DialogResult result = MessageBox.Show("Voulez-vous annuler ce pari dans la liste ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (result == DialogResult.Yes) {
						
						pendingBets.RemoveAll(b => b.MatchId == matchId);
						row.DefaultCellStyle.BackColor = Color.White;
						row.DefaultCellStyle.ForeColor = Color.DarkRed;
						row.ReadOnly = false;
						row.Cells["HomeOddsButton"].Tag = "";
						row.Cells["DrawOddsButton"].Tag = "";
						row.Cells["AwayOddsButton"].Tag = "";

						MessageBox.Show("Pari retiré de la liste temporaire.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				
				if (pendingBets.Count > 0) {
					buttonValidate.Visible = true;
				}else{
					buttonValidate.Visible = false;
				}
				}else{
						MessageBox.Show("Veullez creer une fiche avant de parier!!!.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		
		
		private void ButtonValidateClick(object sender, EventArgs e)
		{
			if (pendingBets.Count > 0) {
				try {
					BetDetailsRepository betDetailsRepository = new BetDetailsRepository();

					foreach (var bet in pendingBets) {
						betDetailsRepository.CreateBetDetail(bet);
					}

					decimal newBalance = AuthenticationRepository.authUser.Balance - betAmount;
					userRepository.ModifyBalanceUser(AuthenticationRepository.authUser, newBalance);

					pendingBets.Clear();
					betId = null;
					betAmount = 0;
					MessageBox.Show("Pari validé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
				} catch (Exception ex) {
					MessageBox.Show("Erreur lors de la validation : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			} else {
				MessageBox.Show("Aucun pari sélectionné pour validation.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		
		
		void UserMatchFormFormClosing(object sender, FormClosingEventArgs e)
		{
			if (pendingBets.Count > 0) {
				DialogResult result = MessageBox.Show(
					"Vous avez des données non sauvegardées. Si vous fermez cette fenêtre, elles seront perdues.\nVoulez-vous vraiment fermer ?",
					"Confirmation de fermeture",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Warning
				);

				if (result == DialogResult.No) {
					e.Cancel = true;
				}
			}
		}
	}
}

