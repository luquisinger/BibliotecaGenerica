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
    }
}
