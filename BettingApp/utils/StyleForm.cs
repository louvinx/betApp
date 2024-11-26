/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 19/11/2024
 * Heure: 20:21
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BettingApp.utils
{
	/// <summary>
	/// Description of StyleForm.
	/// </summary>
	public class StyleForm
	{
		public StyleForm()
		{
		}
		
		
		public void StyleDataGridView(DataGridView dgv)
		{
			
			dgv.BackgroundColor = Color.White;
			dgv.BorderStyle = BorderStyle.None;
			dgv.GridColor = Color.FromArgb(240, 240, 240);
			dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
			Padding padding = new Padding(10);
			dgv.Parent.Padding = padding;
			dgv.AllowUserToAddRows = false;


			dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
//			dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			
			dgv.EnableHeadersVisualStyles = false;
			dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
			dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(70, 70, 70);
			dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic Semibold", 9.75F);
			dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
			dgv.ColumnHeadersHeight = 35;

			
			dgv.DefaultCellStyle.BackColor = Color.White;
			dgv.DefaultCellStyle.ForeColor = Color.FromArgb(80, 80, 80);
			dgv.DefaultCellStyle.Font = new Font("Century Gothic", 9F);
			dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 247, 251);
			dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

			
			dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(252, 252, 252);

			
			dgv.RowHeadersVisible = false;

			
			dgv.RowTemplate.Height = 40;
			dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv.MultiSelect = false;
			

		}
	}
}
