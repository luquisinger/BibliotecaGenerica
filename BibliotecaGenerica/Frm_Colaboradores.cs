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
	public partial class Frm_Colaboradores : Form
	{
		SqlConnection Con = new SqlConnection(@"Data Source=LUQUISINGER;Initial Catalog=Biblioteca;User Id=Matheus;Password=123456");


		public Frm_Colaboradores()
		{
			InitializeComponent();
		}

		private void label6_Click(object sender, EventArgs e)
		{

		}
		public void popular()
		{
			Con.Open();
			string query = "select * from TableColaboradores";
			SqlDataAdapter da = new SqlDataAdapter(query, Con);
			SqlCommandBuilder builder = new SqlCommandBuilder();
			var ds = new DataSet();
			da.Fill(ds);
			ColaboradorDGV.DataSource = ds.Tables[0];
			Con.Close();

		}

		private void button1_Click(object sender, EventArgs e)
		{


			if (ColId.Text == "" || ColNome.Text == "" || ColSenha.Text == "" || ColTelefone.Text == "")
			{
				MessageBox.Show("Informação Faltando.");
			}
			else
			{
				try
				{
					Con.Open();
					string query = "INSERT INTO TableColaboradores (ColId, ColNome, ColSenha, ColTelefone) VALUES (@ColId, @ColNome, @ColSenha, @ColTelefone)";
					SqlCommand cmd = new SqlCommand(query, Con);
					cmd.Parameters.AddWithValue("@ColId", ColId.Text);
					cmd.Parameters.AddWithValue("@ColNome", ColNome.Text);
					cmd.Parameters.AddWithValue("@ColSenha", ColSenha.Text);
					cmd.Parameters.AddWithValue("@ColTelefone", ColTelefone.Text);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Colaborador Adicionado com Sucesso");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Ocorreu um erro: " + ex.Message);
				}
				finally
				{
					Con.Close();
					popular();
				}
			}
		}

		private void materialSingleLineTextField2_Click(object sender, EventArgs e)
		{

		}

		private void Frm_Colaboradores_Load(object sender, EventArgs e)
		{
			popular();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (ColId.Text == "")
			{
				MessageBox.Show("Digite o Id do Colaborador");

			}
			else
			{
				Con.Open();
				string query = "delete from TableColaboradores where ColId = " + ColId.Text + ";";
				SqlCommand cmd = new SqlCommand(query, Con);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Colaborador excluido com sucesso");
				Con.Close();
				popular();
			}
		}

		private void ColaboradorDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			// Verifica se há linhas selecionadas
			if (ColaboradorDGV.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = ColaboradorDGV.SelectedRows[0];

				// Verifica se a linha selecionada tem células suficientes para serem acessadas
				if (selectedRow.Cells.Count >= 4)
				{
					ColId.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
					ColNome.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
					ColSenha.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
					ColTelefone.Text = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;
				}
				else
				{
					MessageBox.Show("A linha selecionada não possui todas as células esperadas.");
				}
			}
			else
			{
				MessageBox.Show("Nenhuma linha foi selecionada.");
			}
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (ColId.Text == "" || ColNome.Text == "" || ColSenha.Text == "" || ColTelefone.Text == "")
			{
				MessageBox.Show("Informação Faltando.");
			}
			else
			{
				Con.Open();
				string query = "update TableColaboradores set ColNome='" + ColNome.Text + "',ColSenha='" + ColSenha.Text + "',ColTelefone='" + ColTelefone.Text + "' where ColId = " + ColId.Text + ";";
				SqlCommand cmd = new SqlCommand(query, Con);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Colaborador atualizado com sucesso");
				Con.Close();
				popular();
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Hide();
			Frm_Principal main = new Frm_Principal();
			main.Show();
		}
	}
}
