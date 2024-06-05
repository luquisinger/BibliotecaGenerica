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
	public partial class Livros : Form
	{
		public Livros()
		{
			InitializeComponent();

		}
		SqlConnection Con = new SqlConnection(@"Data Source=LUQUISINGER;Initial Catalog=Biblioteca;User Id=Matheus;Password=123456");

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		public void popular()
		{
			Con.Open();
			string query = "select * from TableLivros";
			SqlDataAdapter da = new SqlDataAdapter(query, Con);
			SqlCommandBuilder builder = new SqlCommandBuilder();
			var ds = new DataSet();
			da.Fill(ds);
			LivrosDGV.DataSource = ds.Tables[0];
			Con.Close();

		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (NomeLivro.Text == "" || Autor.Text == "" || Editora.Text == "" || Preco.Text == "" || Quantidade.Text == "")
			{
				MessageBox.Show("Informação Faltando.");
			}
			else
			{
				try
				{
					Con.Open();
					SqlCommand cmd = new SqlCommand("Insert into TableLivros values('" + NomeLivro.Text + "','" + Autor.Text + "','" + Editora.Text + "'," + Preco.Text + "," + Quantidade.Text + ")", Con);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Livro Adicionado com Sucesso");
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

		private void Livros_Load(object sender, EventArgs e)
		{
			popular();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (NomeLivro.Text == "")
			{
				MessageBox.Show("Digite o Nome do Livro");

			}
			else
			{
				Con.Open();
				string query = "delete from TableLivros where NomeLivro = '" + NomeLivro.Text + "';";
				SqlCommand cmd = new SqlCommand(query, Con);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Livro excluido com sucesso");
				Con.Close();
				popular();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (NomeLivro.Text == "" || Autor.Text == "" || Editora.Text == "" || Preco.Text == "" || Quantidade.Text == "")
			{
				MessageBox.Show("Informação Faltando.");
			}
			else
			{
				Con.Open();
				string query = "update TableLivros set Autor='" + Autor.Text + "',Editora='" + Editora.Text + "',Preco=" + Preco.Text + ",Quantidade=" + Quantidade.Text + " where NomeLivro = '" + NomeLivro.Text + "';";
				SqlCommand cmd = new SqlCommand(query, Con);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Livro atualizado com sucesso");
				Con.Close();
				popular();
			}
		}

		private void LivrosDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			// Verifica se há linhas selecionadas
			if (LivrosDGV.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = LivrosDGV.SelectedRows[0];

				// Verifica se a linha selecionada tem células suficientes para serem acessadas
				if (selectedRow.Cells.Count >= 4)
				{
					NomeLivro.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
					Autor.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
					Editora.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
					Preco.Text = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;
					Quantidade.Text = selectedRow.Cells[4].Value?.ToString() ?? string.Empty;
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

		private void button4_Click(object sender, EventArgs e)
		{
			this.Hide();
			Frm_Principal main = new Frm_Principal();
			main.Show();
		}
	}
}
