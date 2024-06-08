using System;
using System.Windows.Forms;

namespace BibliotecaGenerica
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Conexao_SQLSERVER conexao = new Conexao_SQLSERVER();
			conexao.Conectar();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			ApplicationConfiguration.Initialize();
			Application.Run(new Frm_LivrosRetornados());
		}
	}
}