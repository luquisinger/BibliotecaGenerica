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
	public partial class Frm_LivrosAtrasados : Form
	{
		public Frm_LivrosAtrasados()
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
		private void PreencherLivro()
		{
			Con.Open();
			SqlCommand cmd = new SqlCommand("select NomeLivro from TableLivros", Con);
			SqlDataReader rdr = cmd.ExecuteReader();
			DataTable dt = new DataTable();
			dt.Columns.Add("NomeLivro", typeof(string));
			dt.Load(rdr);
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
		private void Frm_LivrosAtrasados_Load(object sender, EventArgs e)
		{
			PreencherEstudante();
			PreencherLivro();
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
	}
}
