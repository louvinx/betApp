/*
 * Crée par SharpDevelop.
 * Utilisateur: louvinxPIERRE
 * Date: 04/11/2024
 * Heure: 10:34
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Windows.Forms;
using BettingApp.form.authentification;
using BettingApp.form.admin;
using BettingApp.form.user;


namespace BettingApp
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new LoginForm());
//			Application.Run(new AdminDashboard());
//			Application.Run(new UserDashBoard());
		}
		
	}
}
