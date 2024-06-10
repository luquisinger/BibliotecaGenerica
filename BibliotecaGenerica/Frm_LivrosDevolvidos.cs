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
	public partial class Frm_LivrosDevolvidos : Form
	{
		public Frm_LivrosDevolvidos()
		{
			InitializeComponent();
			button1.Click += new EventHandler(button1_Click);
		}

		SqlConnection Con = new SqlConnection(@"Data Source=LUQUISINGER;Initial Catalog=Biblioteca;User Id=Matheus;Password=123456");

		public void Popular()
		{
			Con.Open();
			string query = "SELECT * FROM TableEmprestimo";
			SqlDataAdapter da = new SqlDataAdapter(query, Con);
			SqlCommandBuilder builder = new SqlCommandBuilder();
			var ds = new DataSet();
			da.Fill(ds);
			LivrosEmprestadosDGV.DataSource = ds.Tables[0];
			Con.Close();
		}

		public void PopularDevolucao()
		{
			Con.Open();
			string query = "SELECT * FROM TableDevolucao";
			SqlDataAdapter da = new SqlDataAdapter(query, Con);
			SqlCommandBuilder builder = new SqlCommandBuilder();
			var ds = new DataSet();
			da.Fill(ds);
			LivrosDevolvidosDGV.DataSource = ds.Tables[0];
			Con.Close();
		}
		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}
		private void PreencherLivro()
		{
			Con.Open();
			SqlCommand cmd = new SqlCommand("SELECT NomeLivro FROM TableLivros WHERE Quantidade > 0", Con);
			SqlDataReader rdr = cmd.ExecuteReader();
			DataTable dt = new DataTable();
			dt.Columns.Add("NomeLivro", typeof(string));
			dt.Load(rdr);
			LivroCb.DisplayMember = "NomeLivro";
			LivroCb.ValueMember = "NomeLivro";
			LivroCb.DataSource = dt;
			Con.Close();
		}

		private void Frm_LivrosRetornados_Load(object sender, EventArgs e)
		{
			PopularDevolucao();
			PreencherLivro();
			Popular();
		}

		private void LivrosEmprestadosDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (LivrosEmprestadosDGV.SelectedRows.Count > 0)
			{
				var selectedRow = LivrosEmprestadosDGV.SelectedRows[0];
				if (selectedRow.Cells[0].Value != null)
					DevNumTb.Text = selectedRow.Cells[0].Value.ToString();
				if (selectedRow.Cells[1].Value != null)
					AlnIdTb.SelectedItem = selectedRow.Cells[1].Value.ToString();
				if (selectedRow.Cells[2].Value != null)
					AlnNomeTb.Text = selectedRow.Cells[2].Value.ToString();
				if (selectedRow.Cells[3].Value != null)
					AlnDepTb.Text = selectedRow.Cells[3].Value.ToString();
				if (selectedRow.Cells[4].Value != null)
					AlnTelTb.Text = selectedRow.Cells[4].Value.ToString();
				if (selectedRow.Cells[5].Value != null)
					LivroCb.Text = selectedRow.Cells[5].Value.ToString();
			}
			else
			{
				MessageBox.Show("Nenhuma linha selecionada.");
			}
		}
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void AtualizarLivros()
		{
			if (LivroCb.SelectedValue == null)
			{
				MessageBox.Show("Nenhum livro selecionado.");
				return;
			}

			int Quantidade, newQuantidade;
			Con.Open();
			string query = "SELECT * FROM TableLivros WHERE NomeLivro = @NomeLivro";
			SqlCommand cmd = new SqlCommand(query, Con);
			cmd.Parameters.AddWithValue("@NomeLivro", LivroCb.SelectedValue.ToString());
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(dt);
			foreach (DataRow dr in dt.Rows)
			{
				Quantidade = Convert.ToInt32(dr["Quantidade"].ToString());
				newQuantidade = Quantidade + 1;
				string query1 = "UPDATE TableLivros SET Quantidade = @Quantidade WHERE NomeLivro = @NomeLivro";
				SqlCommand cmd1 = new SqlCommand(query1, Con);
				cmd1.Parameters.AddWithValue("@Quantidade", newQuantidade);
				cmd1.Parameters.AddWithValue("@NomeLivro", LivroCb.SelectedValue.ToString());
				cmd1.ExecuteNonQuery();
			}
			Con.Close();
		}
		private void button4_Click(object sender, EventArgs e)
		{
			this.Hide();
			Frm_Principal main = new Frm_Principal();
			main.Show();
		}
			private void button1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(DevNumTb.Text) || string.IsNullOrEmpty(AlnNomeTb.Text))
			{
				MessageBox.Show("Informação Faltando.");
				return;
			}

			try
			{
				if (DataEmprestada == null || DevData == null)
				{
					MessageBox.Show("Datas não foram selecionadas corretamente.");
					return;
				}

				string dataEmprestimo = DataEmprestada.Value.ToString("yyyy-MM-dd");
				string dataDevolucao = DevData.Value.ToString("yyyy-MM-dd");

				if (Con == null)
				{
					MessageBox.Show("Conexão com o banco de dados não foi inicializada.");
					return;
				}

				Con.Open();
				string query = "INSERT INTO TableDevolucao (EmprestimoNum, AlnId, AlnNome, AlnDepartamento, AlnTelefone, NomeLivro, DataEmprestimo, DataDevolucao) " +
							   "VALUES (@EmprestimoNum, @AlnId, @AlnNome, @AlnDepartamento, @AlnTelefone, @NomeLivro, @DataEmprestimo, @DataDevolucao)";
				SqlCommand cmd = new SqlCommand(query, Con);
				cmd.Parameters.AddWithValue("@EmprestimoNum", DevNumTb.Text);

				if (AlnIdTb.SelectedValue == null)
				{
					MessageBox.Show("ID do aluno não selecionado.");
					return;
				}

				cmd.Parameters.AddWithValue("@AlnId", AlnIdTb.SelectedValue);
				cmd.Parameters.AddWithValue("@AlnNome", AlnNomeTb.Text);
				cmd.Parameters.AddWithValue("@AlnDepartamento", AlnDepTb.Text);
				cmd.Parameters.AddWithValue("@AlnTelefone", AlnTelTb.Text);
				cmd.Parameters.AddWithValue("@NomeLivro", LivroCb.SelectedValue.ToString());
				cmd.Parameters.AddWithValue("@DataEmprestimo", dataEmprestimo);
				cmd.Parameters.AddWithValue("@DataDevolucao", dataDevolucao);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Livro Devolvido com Sucesso");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocorreu um erro: " + ex.Message);
			}
			finally
			{
				Con.Close();
				AtualizarLivros();
				PopularDevolucao();
				Popular();
			}
		}
	}
}
