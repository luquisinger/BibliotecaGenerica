using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaGenerica
{
	public partial class Frm_Principal : Form
	{
		public Frm_Principal()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Frm_Estudantes student = new Frm_Estudantes();
			student.Show();
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Livros livro = new Livros();
			livro.Show();
			this.Hide();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Frm_Colaboradores colaboradores = new Frm_Colaboradores();
			colaboradores.Show();
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Frm_LivrosEmprestados livrosAtrasados = new Frm_LivrosEmprestados();
			livrosAtrasados.Show();
			this.Hide();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Frm_LivrosDevolvidos livrosR = new Frm_LivrosDevolvidos();
			livrosR.Show();
			this.Hide();
		}
	}
}
