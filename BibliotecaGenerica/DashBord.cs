﻿using System;
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
	public partial class DashBord : Form
	{
		public DashBord()
		{
			InitializeComponent();
		}
		SqlConnection Con = new SqlConnection(@"Data Source=LUQUISINGER;Initial Catalog=Biblioteca;User Id=Matheus;Password=123456");

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			this.Hide();
			Frm_Principal main = new Frm_Principal();
			main.Show();
		}

		private void DashBord_Load(object sender, EventArgs e)
		{
			Con.Open();

			SqlDataAdapter sda1 = new SqlDataAdapter("select count(*) from TableLivros", Con);
			DataTable dt = new DataTable();
			sda1.Fill(dt);
			Booklbl.Text = dt.Rows[0][0].ToString();

			SqlDataAdapter sda2 = new SqlDataAdapter("select count(*) from TableAlunos", Con);
			DataTable dt2 = new DataTable();
			sda2.Fill(dt2);
			Alnlbl.Text = dt2.Rows[0][0].ToString();

			SqlDataAdapter sda3 = new SqlDataAdapter("select count(*) from TableColaboradores", Con);
			DataTable dt3 = new DataTable();
			sda3.Fill(dt3);
			Collbl.Text = dt3.Rows[0][0].ToString();

			SqlDataAdapter sda4 = new SqlDataAdapter("select count(*) from TableEmprestimo", Con);
			DataTable dt4 = new DataTable();
			sda4.Fill(dt4);
			Emplbl.Text = dt4.Rows[0][0].ToString();

			SqlDataAdapter sda5 = new SqlDataAdapter("select count(*) from TableRetorno", Con);
			DataTable dt5 = new DataTable();
			sda5.Fill(dt5);
			Devlbl.Text = dt5.Rows[0][0].ToString();

			Con.Close();
		}
	}
}
