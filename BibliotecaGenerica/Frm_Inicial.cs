
namespace BibliotecaGenerica
{
    public partial class Frm_Inicial : Form
    {
        public Frm_Inicial()
        {
            InitializeComponent();
           
        }
        int startpoint = 0;
        private void label2_Click(object sender, EventArgs e)
        {
          
        }
        private void timer1_Tick_2(object sender, EventArgs e)
        {
            startpoint += 1;
            Myprogress.Value = startpoint;
            Porcentagem.Text = ""+startpoint;
            if(Myprogress.Value == 100)
            {
                Myprogress.Value = 0;
                timer1.Stop();
                Frm_Login log = new Frm_Login();
                log.Show();
                this.Hide();
            }
        }
        private void Frm_Inicial_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        
    }
}
