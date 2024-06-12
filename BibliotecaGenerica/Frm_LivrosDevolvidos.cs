using BibliotecaGenerica;
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
		}
		SqlConnection Con = new SqlConnection(@"Data Source=LUQUISINGER;Initial Catalog=Biblioteca;User Id=Matheus;Password=123456");

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
		public void popularDevolucao()
		{
			Con.Open();
			string query = "select * from TableRetorno";
			SqlDataAdapter da = new SqlDataAdapter(query, Con);
			SqlCommandBuilder builder = new SqlCommandBuilder();
			var ds = new DataSet();
			da.Fill(ds);
			LivrosDevolvidosDGV.DataSource = ds.Tables[0];
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
		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void Frm_LivrosRetornados_Load(object sender, EventArgs e)
		{
			popular();
			popularDevolucao();
			PreencherLivro();
		}

		private void LivrosEmprestadosDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

			DevNumTb.Text = LivrosEmprestadosDGV.SelectedRows[0].Cells[0].Value.ToString();
			AlnIdTb.Text = LivrosEmprestadosDGV.SelectedRows[0].Cells[1].Value.ToString();
			AlnNomeTb.Text = LivrosEmprestadosDGV.SelectedRows[0].Cells[2].Value.ToString();
			AlnDepTb.Text = LivrosEmprestadosDGV.SelectedRows[0].Cells[3].Value.ToString();
			AlnTelTb.Text = LivrosEmprestadosDGV.SelectedRows[0].Cells[4].Value.ToString();
			LivroCb.Text = LivrosEmprestadosDGV.SelectedRows[0].Cells[5].Value.ToString();
			DataEmprestada.Text = LivrosEmprestadosDGV.SelectedRows[0].Cells[6].Value.ToString();

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Hide();
			Frm_Principal main = new Frm_Principal();
			main.Show();
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
				newQuantidade = Quantidade + 1;
				string query1 = "update TableLivros set Quantidade= " + newQuantidade + "where NomeLivro= '" + LivroCb.SelectedValue.ToString() + "';";
				SqlCommand cmd1 = new SqlCommand(query1, Con);
				cmd1.ExecuteNonQuery();
			}

			Con.Close();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (DevNumTb.Text == "" || AlnNomeTb.Text == "")
			{

				MessageBox.Show("Informação Faltando.");
			}
			if (AlnIdTb.Text == null)
			{

				MessageBox.Show("Id Faltando.");
			}
			else
			{
				try
				{

					string dataEmprestimo = DataEmprestada.Value.ToString("yyyy-MM-dd");
					string dataDevolucao = DevData.Value.ToString("yyyy-MM-dd");
					Con.Open();
					SqlCommand cmd = new SqlCommand("Insert into TableRetorno values(" + DevNumTb.Text + "," + AlnIdTb.Text.ToString() + ",'" + AlnNomeTb.Text + "','" + AlnDepTb.Text + "','" + AlnTelTb.Text + "','" + LivroCb.SelectedValue.ToString() + "','" + dataEmprestimo + "','" + dataDevolucao + "')", Con);
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
					popular();
					popularDevolucao();
				}
			}
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.DrawImage(bitmap, 0 , 0);
		}
		Bitmap bitmap;
		private void button2_Click(object sender, EventArgs e)
		{
			Panel panel = new Panel();
			this.Controls.Add(panel);
			Graphics graphics = panel.CreateGraphics();
			Size size = this.ClientSize;
			bitmap = new Bitmap(size.Width, size.Height, graphics);
			graphics = Graphics.FromImage(bitmap);
			Point point = PointToScreen(panel.Location);
			graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);
			printPreviewDialog1.Document = printDocument1;
			printPreviewDialog1.ShowDialog();  
		}
	}
}


