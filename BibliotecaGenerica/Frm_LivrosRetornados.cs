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
	public partial class Frm_LivrosRetornados : Form
	{
		public Frm_LivrosRetornados()
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
		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void Frm_LivrosRetornados_Load(object sender, EventArgs e)
		{
			popular();
		}

		private void LivrosEmprestadosDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

			AtrasoNumTb.Text = LivrosEmprestadosDGV.SelectedRows[0].Cells[0].Value.ToString();
			AlnIdTb.SelectedItem = LivrosEmprestadosDGV.SelectedRows[0].Cells[1].Value.ToString();
			AlnNomeTb.Text = LivrosEmprestadosDGV.SelectedRows[0].Cells[2].Value.ToString();
			AlnDepTb.Text = LivrosEmprestadosDGV.SelectedRows[0].Cells[3].Value.ToString();
			AlnTelTb.Text = LivrosEmprestadosDGV.SelectedRows[0].Cells[4].Value.ToString();
			LivroCb.Text = LivrosEmprestadosDGV.SelectedRows[0].Cells[5].Value.ToString();

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
	}
}
