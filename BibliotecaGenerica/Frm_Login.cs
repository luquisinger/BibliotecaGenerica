using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaGenerica
{
	public partial class Frm_Login : Form
	{
		public Frm_Login()
		{
			InitializeComponent();
		}
		SqlConnection Con = new SqlConnection(@"Data Source=LUQUISINGER;Initial Catalog=Biblioteca;User Id=Matheus;Password=123456");

		private void guna2Button1_Click(object sender, EventArgs e)
		{

			try
			{
				Con.Open();
				// Use parâmetros para prevenir SQL Injection
				string query = "select count(*) from TableColaboradores where ColNome = @ColNome and ColSenha = @ColSenha";
				SqlCommand cmd = new SqlCommand(query, Con);
				cmd.Parameters.AddWithValue("@ColNome", ColNome.Text);
				cmd.Parameters.AddWithValue("@ColSenha", ColSenha.Text);

				int result = (int)cmd.ExecuteScalar(); // ExecuteScalar é mais eficiente para contar resultados

				if (result == 1)
				{
					this.Hide();
					Frm_Principal main = new Frm_Principal();
					main.Show();
				}
				else
				{
					MessageBox.Show("Usuário ou senha inválidos");
				}
			}
			catch (SqlException ex)
			{
				MessageBox.Show("Erro de SQL: " + ex.Message);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro: " + ex.Message);
			}
			finally
			{
				Con.Close();
			}
		}

		private void label2_Click(object sender, EventArgs e)
		{
			ColNome.Text = "";
			ColSenha.Text = "";
		}

		private void materialRaisedButton1_Click(object sender, EventArgs e)
		{

			try
			{
				Con.Open();
				// Use parâmetros para prevenir SQL Injection
				string query = "select count(*) from TableColaboradores where ColNome = @ColNome and ColSenha = @ColSenha";
				SqlCommand cmd = new SqlCommand(query, Con);
				cmd.Parameters.AddWithValue("@ColNome", ColNome.Text);
				cmd.Parameters.AddWithValue("@ColSenha", ColSenha.Text);

				int result = (int)cmd.ExecuteScalar(); // ExecuteScalar é mais eficiente para contar resultados

				if (result == 1)
				{
					this.Hide();
					Frm_Principal main = new Frm_Principal();
					main.Show();
				}
				else
				{
					MessageBox.Show("Usuário ou senha inválidos");
				}
			}
			catch (SqlException ex)
			{
				MessageBox.Show("Erro de SQL: " + ex.Message);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro: " + ex.Message);
			}
			finally
			{
				Con.Close();
			}
		}
	}
}
