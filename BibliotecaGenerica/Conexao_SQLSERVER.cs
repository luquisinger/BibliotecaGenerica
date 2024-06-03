using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGenerica
{
	public class Conexao_SQLSERVER
	{
		static void Main(string[] args)
		{
			string connectionString = "Data Source=LUQUISINGER;Initial Catalog=Biblioteca;User Id=Matheus;Password=123456";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				try
				{
					connection.Open();
					Console.WriteLine("Conexão aberta com sucesso.");

					// Seu código para trabalhar com o banco de dados aqui.
				}
				catch (Exception ex)
				{
					Console.WriteLine("Ocorreu um erro: " + ex.Message);
				}
				finally
				{
					connection.Close();
					Console.WriteLine("Conexão fechada.");
				}
			}
		}
	}
}
