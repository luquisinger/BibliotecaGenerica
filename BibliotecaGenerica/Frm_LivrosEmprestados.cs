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
using static MaterialSkin.Controls.MaterialForm;

namespace BibliotecaGenerica
{
	public partial class Frm_LivrosEmprestados : Form
	{
		public Frm_LivrosEmprestados()
		{
			InitializeComponent();
		}
		SqlConnection Con = new SqlConnection(@"Data Source=LUQUISINGER;Initial Catalog=Biblioteca;User Id=Matheus;Password=123456");
		private void PreencherEstudante()
		{
			Con.Open();
			SqlCommand cmd = new SqlCommand("select AlnId from TableAlunos", Con);
			SqlDataReader rdr = cmd.ExecuteReader();
			DataTable dt = new DataTable();
			dt.Columns.Add("AlnId", typeof(int));
			dt.Load(rdr);
			AlnIdTb.ValueMember = "AlnId";
			AlnIdTb.DataSource = dt;
			Con.Close();
		}
		public void popular()
		{
			Con.Open();
			string query = "select * from TableEmprestimo";
			SqlDataAdapter da = new SqlDataAdapter(query, Con);
			SqlCommandBuilder builder = new SqlCommandBuilder();
			var ds = new DataSet();
			da.Fill(ds);
			LivrosEmprestadosDGV.DataSource = ds.Tables[0];
			Con.Close();

		}
		private void PreencherLivro()
		{
			Con.Open();
			SqlCommand cmd = new SqlCommand("select NomeLivro from TableLivros where Quantidade > 0", Con);
			SqlDataReader rdr = cmd.ExecuteReader();
			DataTable dt = new DataTable();
			dt.Columns.Add("NomeLivro", typeof(string));
			dt.Load(rdr);
			LivroCb.DisplayMember = "NomeLivro";
			LivroCb.ValueMember = "NomeLivro";
			LivroCb.DataSource = dt;
			Con.Close();
		}

		private void PegarDados()
		{
			Con.Open();
			string query = "select * from TableAlunos where AlnId=" + AlnIdTb.SelectedValue.ToString() + "";
			SqlCommand cmd = new SqlCommand(query, Con);
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(dt);
			foreach (DataRow dr in dt.Rows)
			{
				AlnNomeTb.Text = dr["AlnNome"].ToString();
				AlnDepTb.Text = dr["AlnDepartamento"].ToString();
				AlnTelTb.Text = dr["AlnNumero"].ToString();
			}
			Con.Close();

		}
		private void AtualizarLivros()
		{
			int Quantidade, newQuantidade;
			Con.Open();
			string query = "select * from TableLivros where NomeLivro='" + LivroCb.SelectedValue.ToString() + "'";
			SqlCommand cmd = new SqlCommand(query, Con);
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(dt);
			foreach (DataRow dr in dt.Rows)
			{
				Quantidade = Convert.ToInt32(dr["Quantidade"].ToString());
				newQuantidade = Quantidade - 1;
				string query1 = "update TableLivros set Quantidade= " + newQuantidade + "where NomeLivro= '" + LivroCb.SelectedValue.ToString() + "';";
				SqlCommand cmd1 = new SqlCommand(query1, Con);
				cmd1.ExecuteNonQuery();
			}

			Con.Close();
		}
		private void AtualizarLivrosCancelados()
		{
			if (LivroCb.SelectedValue == null)
			{
				MessageBox.Show("Nenhum livro selecionado.");
				return;
			}

			string livroSelecionado = LivroCb.SelectedValue.ToString().Trim(); // Remover espaços extras
			MessageBox.Show("Livro selecionado: " + livroSelecionado); // Verificar o valor selecionado
			int quantidade, newQuantidade;

			try
			{
				Con.Open();

				string query = "SELECT Quantidade FROM TableLivros WHERE NomeLivro = @NomeLivro";
				SqlCommand cmd = new SqlCommand(query, Con);
				cmd.Parameters.AddWithValue("@NomeLivro", livroSelecionado);

				DataTable dt = new DataTable();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);

				MessageBox.Show("Linhas retornadas: " + dt.Rows.Count); // Verificar o número de linhas retornadas

				if (dt.Rows.Count > 0)
				{
					DataRow dr = dt.Rows[0];
					quantidade = Convert.ToInt32(dr["Quantidade"]);
					newQuantidade = quantidade + 1;

					string query1 = "UPDATE TableLivros SET Quantidade = @Quantidade WHERE NomeLivro = @NomeLivro";
					SqlCommand cmd1 = new SqlCommand(query1, Con);
					cmd1.Parameters.AddWithValue("@Quantidade", newQuantidade);
					cmd1.Parameters.AddWithValue("@NomeLivro", livroSelecionado);

					cmd1.ExecuteNonQuery();

					MessageBox.Show("Quantidade atualizada com sucesso!");
				}
				else
				{
					MessageBox.Show($"Livro '{livroSelecionado}' não encontrado na tabela.");
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

		private void Frm_LivrosAtrasados_Load(object sender, EventArgs e)
		{
			PreencherEstudante();
			PreencherLivro();
			popular();
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

		private void AlunoId_SelectedValueChanged(object sender, EventArgs e)
		{

		}

		private void AlunoId_SelectionChangeCommitted(object sender, EventArgs e)
		{
			PegarDados();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (AtrasoNumTb.Text == "" || AlnNomeTb.Text == "")
			{
				MessageBox.Show("Informação Faltando.");
			}
			else
			{
				try
				{
					string dataEmprestimo = DataEmprestada.Value.Day.ToString() + "/" + DataEmprestada.Value.Month.ToString() + "/" + DataEmprestada.Value.Year.ToString();
					Con.Open();
					SqlCommand cmd = new SqlCommand("Insert into TableEmprestimo values(" + AtrasoNumTb.Text + "," + AlnIdTb.SelectedValue.ToString() + ",'" + AlnNomeTb.Text + "','" + AlnDepTb.Text + "','" + AlnTelTb.Text + "','" + LivroCb.SelectedValue.ToString() + "','" + dataEmprestimo + "')", Con);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Livro Emprestado com Sucesso");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Ocorreu um erro: " + ex.Message);
				}
				finally
				{
					Con.Close();
					AtualizarLivros();
					popular();
				}
			}
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (AtrasoNumTb.Text == "")
			{
				MessageBox.Show("Digite o Id do Emprestimo");
			}
			else
			{
				try
				{
					Con.Open();
					string query = "delete from TableEmprestimo where EmprestimoNum = @EmprestimoNum";
					SqlCommand cmd = new SqlCommand(query, Con);
					cmd.Parameters.AddWithValue("@EmprestimoNum", AtrasoNumTb.Text);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Emprestimo excluido com sucesso");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro ao excluir empréstimo: " + ex.Message);
				}
				finally
				{
					Con.Close();
					AtualizarLivrosCancelados();
					popular();
				}
			}
		}


		private void LivrosDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			/*
			// Verifica se há linhas selecionadas
			if (LivrosEmprestadosDGV.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = LivrosEmprestadosDGV.SelectedRows[0];

				// Verifica se a linha selecionada tem células suficientes para serem acessadas
				if (selectedRow.Cells.Count >= 6)
				{
					AtrasoNumTb.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
					AlnIdTb.SelectedItem = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
					AlnNomeTb.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
					AlnDepTb.Text = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;
					AlnTelTb.Text = selectedRow.Cells[4].Value?.ToString() ?? string.Empty;
					LivroCb.SelectedItem = selectedRow.Cells[5].Value?.ToString() ?? string.Empty;
				}
				else
				{
					MessageBox.Show("A linha selecionada não possui todas as células esperadas.");
				}

			}*/
			AtrasoNumTb.Text = LivrosEmprestadosDGV.SelectedRows[0].Cells[0].Value.ToString();
			AlnIdTb.SelectedItem = LivrosEmprestadosDGV.SelectedRows[0].Cells[1].Value.ToString();
			AlnNomeTb.Text = LivrosEmprestadosDGV.SelectedRows[0].Cells[2].Value.ToString();
			AlnDepTb.Text = LivrosEmprestadosDGV.SelectedRows[0].Cells[3].Value.ToString();
			AlnTelTb.Text = LivrosEmprestadosDGV.SelectedRows[0].Cells[4].Value.ToString();
			LivroCb.Text = LivrosEmprestadosDGV.SelectedRows[0].Cells[5].Value.ToString();
		}
	}
}
