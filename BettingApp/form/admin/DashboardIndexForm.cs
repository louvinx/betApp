/*
 * Created by SharpDevelop.
 * User: 1
 * Date: 11/7/2024
 * Time: 10:22 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using BettingApp.data.repository;
using BettingApp.utils;
using System.Drawing;

namespace BettingApp.form.admin
{
	/// <summary>
	/// Description of DashboardIndexForm.
	/// </summary>
	public partial class DashboardIndexForm : Form
	{
		MatchRepository matchRepository = new MatchRepository();
		BetsRepository betsRepository = new BetsRepository();
		private int lastSplitterPosition;
		public DashboardIndexForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			ConfigureSplitContainer();
			var style = new StyleForm();
			style.StyleDataGridView(matchDataGridView);
			style.StyleDataGridView(betPeddingDataGridView);
			matchRepository.LoadMatch(matchDataGridView);
			betsRepository.LoadPendingBetSummary(betPeddingDataGridView);
			
		}
		
		public void ConfigureSplitContainer()
		{
			
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.BorderStyle = BorderStyle.None;
			splitContainer1.SplitterWidth = 2;
			splitContainer1.SplitterDistance = this.Width / 3;
			splitContainer1.IsSplitterFixed = false;
			splitContainer1.SplitterIncrement = 10;

			splitContainer1.BackColor = Color.SteelBlue;
			splitContainer1.Panel1.BackColor = Color.White;
			splitContainer1.Panel2.BackColor = Color.White;
			
			splitContainer1.Panel1.Padding = new Padding(10);
			splitContainer1.Panel2.Padding = new Padding(10);
			splitContainer1.Panel1MinSize = 400;
			splitContainer1.Panel2MinSize = 100;
			
			lastSplitterPosition = splitContainer1.SplitterDistance;

		}


		
	}
}
