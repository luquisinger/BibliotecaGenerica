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
	public partial class Frm_Estudantes : Form
	{
		public Frm_Estudantes()
		{
			InitializeComponent();
		}
		SqlConnection Con = new SqlConnection(@"Data Source=LUQUISINGER;Initial Catalog=Biblioteca;User Id=Matheus;Password=123456");

		public void popular()
		{
			Con.Open();
			string query = "select * from TableAlunos";
			SqlDataAdapter da = new SqlDataAdapter(query, Con);
			SqlCommandBuilder builder = new SqlCommandBuilder();
			var ds = new DataSet();
			da.Fill(ds);
			AlunoDGV.DataSource = ds.Tables[0];
			Con.Close();

		}
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Hide();
			Frm_Principal main = new Frm_Principal();
			main.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (AlnId.Text == "" || AlnNome.Text == "" || AlnDepartamento.Text == "" || AlnNumero.Text == "" || AlnSemestre.Text == "")
			{
				MessageBox.Show("Informação Faltando.");
			}
			else
			{
				try
				{
					Con.Open();
					string query = "INSERT INTO TableAlunos (AlnId, AlnNome, AlnDepartamento, AlnSemestre ,AlnNumero) VALUES (@AlnId, @AlnNome, @AlnDepartamento, @AlnSemestre, @AlnNumero)";
					SqlCommand cmd = new SqlCommand(query, Con);
					cmd.Parameters.AddWithValue("@AlnId", AlnId.Text);
					cmd.Parameters.AddWithValue("@AlnNome", AlnNome.Text);
					cmd.Parameters.AddWithValue("@AlnDepartamento", AlnDepartamento.Text);
					cmd.Parameters.AddWithValue("@AlnSemestre", AlnSemestre.Text);
					cmd.Parameters.AddWithValue("@AlnNumero", AlnNumero.Text);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Aluno Adicionado com Sucesso");
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

		private void Frm_Estudantes_Load(object sender, EventArgs e)
		{
			popular();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (AlnId.Text == "")
			{
				MessageBox.Show("Digite o Id do Aluno");

			}
			else
			{
				Con.Open();
				string query = "delete from TableAlunos where AlnId = " + AlnId.Text + ";";
				SqlCommand cmd = new SqlCommand(query, Con);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Aluno excluido com sucesso");
				Con.Close();
				popular();
			}
		}

		private void AlunoDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			// Verifica se há linhas selecionadas
			if (AlunoDGV.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = AlunoDGV.SelectedRows[0];

				// Verifica se a linha selecionada tem células suficientes para serem acessadas
				if (selectedRow.Cells.Count >= 4)
				{
					AlnId.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
					AlnNome.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
					AlnDepartamento.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
					AlnSemestre.Text = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;
					AlnNumero.Text = selectedRow.Cells[4].Value?.ToString() ?? string.Empty;
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

		private void button2_Click(object sender, EventArgs e)
		{
			if (AlnId.Text == "" || AlnNome.Text == "" || AlnDepartamento.Text == "" || AlnNumero.Text == "" || AlnSemestre.Text == "")
			{ 
				MessageBox.Show("Informação Faltando.");
			}
			else
			{
				Con.Open();
				string query = "update TableAlunos set AlnNome='" + AlnNome.Text + "',AlnDepartamento='" + AlnDepartamento.Text + "',AlnSemestre='" + AlnSemestre.Text + "',AlnNumero='" + AlnNumero.Text + "' where AlnId = " + AlnId.Text + ";";
				SqlCommand cmd = new SqlCommand(query, Con);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Aluno atualizado com sucesso");
				Con.Close();
				popular();
			}
		}
	}
}
