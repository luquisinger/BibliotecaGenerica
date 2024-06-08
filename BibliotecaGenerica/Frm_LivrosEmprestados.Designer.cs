namespace BibliotecaGenerica
{
    partial class Frm_LivrosEmprestados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			panel1 = new Panel();
			pictureBox2 = new PictureBox();
			label2 = new Label();
			label1 = new Label();
			AlnTelTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
			label7 = new Label();
			Usn = new Label();
			AlnIdTb = new ComboBox();
			label5 = new Label();
			AlnDepTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
			label4 = new Label();
			AlnNomeTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
			label3 = new Label();
			AtrasoNumTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
			label8 = new Label();
			LivroCb = new ComboBox();
			DataEmprestada = new DateTimePicker();
			label9 = new Label();
			button4 = new Button();
			button3 = new Button();
			button2 = new Button();
			button1 = new Button();
			panel2 = new Panel();
			LivrosEmprestadosDGV = new DataGridView();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)LivrosEmprestadosDGV).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(128, 64, 0);
			panel1.Controls.Add(pictureBox2);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Margin = new Padding(4, 3, 4, 3);
			panel1.Name = "panel1";
			panel1.Size = new Size(976, 82);
			panel1.TabIndex = 3;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = Properties.Resources.icons8_excluir_120;
			pictureBox2.Location = new Point(902, 3);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(42, 26);
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 20;
			pictureBox2.TabStop = false;
			pictureBox2.Click += pictureBox2_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			label2.ForeColor = SystemColors.ButtonHighlight;
			label2.Location = new Point(308, 42);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(262, 33);
			label2.TabIndex = 5;
			label2.Text = "Livros Emprestados";
			label2.Click += label2_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.ButtonHighlight;
			label1.Location = new Point(108, 9);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(564, 33);
			label1.TabIndex = 4;
			label1.Text = "Sistema de Gerenciamento da Biblioteca";
			// 
			// AlnTelTb
			// 
			AlnTelTb.Depth = 0;
			AlnTelTb.Hint = "";
			AlnTelTb.Location = new Point(114, 269);
			AlnTelTb.MaxLength = 32767;
			AlnTelTb.MouseState = MaterialSkin.MouseState.HOVER;
			AlnTelTb.Name = "AlnTelTb";
			AlnTelTb.PasswordChar = '\0';
			AlnTelTb.SelectedText = "";
			AlnTelTb.SelectionLength = 0;
			AlnTelTb.SelectionStart = 0;
			AlnTelTb.Size = new Size(185, 23);
			AlnTelTb.TabIndex = 25;
			AlnTelTb.TabStop = false;
			AlnTelTb.UseSystemPasswordChar = false;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label7.ForeColor = SystemColors.ActiveCaptionText;
			label7.Location = new Point(13, 275);
			label7.Margin = new Padding(4, 0, 4, 0);
			label7.Name = "label7";
			label7.Size = new Size(59, 17);
			label7.TabIndex = 24;
			label7.Text = "Telefone";
			// 
			// Usn
			// 
			Usn.AutoSize = true;
			Usn.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
			Usn.ForeColor = SystemColors.ActiveCaptionText;
			Usn.Location = new Point(13, 246);
			Usn.Margin = new Padding(4, 0, 4, 0);
			Usn.Name = "Usn";
			Usn.Size = new Size(57, 17);
			Usn.TabIndex = 23;
			Usn.Text = "Aluno ID";
			// 
			// AlnIdTb
			// 
			AlnIdTb.FormattingEnabled = true;
			AlnIdTb.Items.AddRange(new object[] { "1\t", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
			AlnIdTb.Location = new Point(114, 240);
			AlnIdTb.Name = "AlnIdTb";
			AlnIdTb.Size = new Size(185, 23);
			AlnIdTb.TabIndex = 22;
			AlnIdTb.SelectionChangeCommitted += AlunoId_SelectionChangeCommitted;
			AlnIdTb.SelectedValueChanged += AlunoId_SelectedValueChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label5.ForeColor = SystemColors.ActiveCaptionText;
			label5.Location = new Point(13, 211);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(97, 17);
			label5.TabIndex = 21;
			label5.Text = "Departamento";
			// 
			// AlnDepTb
			// 
			AlnDepTb.Depth = 0;
			AlnDepTb.Hint = "";
			AlnDepTb.Location = new Point(114, 211);
			AlnDepTb.MaxLength = 32767;
			AlnDepTb.MouseState = MaterialSkin.MouseState.HOVER;
			AlnDepTb.Name = "AlnDepTb";
			AlnDepTb.PasswordChar = '\0';
			AlnDepTb.SelectedText = "";
			AlnDepTb.SelectionLength = 0;
			AlnDepTb.SelectionStart = 0;
			AlnDepTb.Size = new Size(185, 23);
			AlnDepTb.TabIndex = 20;
			AlnDepTb.TabStop = false;
			AlnDepTb.UseSystemPasswordChar = false;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label4.ForeColor = SystemColors.ActiveCaptionText;
			label4.Location = new Point(13, 182);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(44, 17);
			label4.TabIndex = 19;
			label4.Text = "Nome";
			// 
			// AlnNomeTb
			// 
			AlnNomeTb.Depth = 0;
			AlnNomeTb.Hint = "";
			AlnNomeTb.Location = new Point(114, 182);
			AlnNomeTb.MaxLength = 32767;
			AlnNomeTb.MouseState = MaterialSkin.MouseState.HOVER;
			AlnNomeTb.Name = "AlnNomeTb";
			AlnNomeTb.PasswordChar = '\0';
			AlnNomeTb.SelectedText = "";
			AlnNomeTb.SelectionLength = 0;
			AlnNomeTb.SelectionStart = 0;
			AlnNomeTb.Size = new Size(185, 23);
			AlnNomeTb.TabIndex = 18;
			AlnNomeTb.TabStop = false;
			AlnNomeTb.UseSystemPasswordChar = false;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label3.ForeColor = SystemColors.ActiveCaptionText;
			label3.Location = new Point(13, 159);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(55, 17);
			label3.TabIndex = 17;
			label3.Text = "Número";
			// 
			// AtrasoNumTb
			// 
			AtrasoNumTb.Depth = 0;
			AtrasoNumTb.Hint = "";
			AtrasoNumTb.Location = new Point(114, 153);
			AtrasoNumTb.MaxLength = 32767;
			AtrasoNumTb.MouseState = MaterialSkin.MouseState.HOVER;
			AtrasoNumTb.Name = "AtrasoNumTb";
			AtrasoNumTb.PasswordChar = '\0';
			AtrasoNumTb.SelectedText = "";
			AtrasoNumTb.SelectionLength = 0;
			AtrasoNumTb.SelectionStart = 0;
			AtrasoNumTb.Size = new Size(185, 23);
			AtrasoNumTb.TabIndex = 16;
			AtrasoNumTb.TabStop = false;
			AtrasoNumTb.UseSystemPasswordChar = false;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label8.ForeColor = SystemColors.ActiveCaptionText;
			label8.Location = new Point(13, 316);
			label8.Margin = new Padding(4, 0, 4, 0);
			label8.Name = "label8";
			label8.Size = new Size(37, 17);
			label8.TabIndex = 27;
			label8.Text = "Livro";
			// 
			// LivroCb
			// 
			LivroCb.FormattingEnabled = true;
			LivroCb.Items.AddRange(new object[] { "1\t", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
			LivroCb.Location = new Point(118, 310);
			LivroCb.Name = "LivroCb";
			LivroCb.Size = new Size(181, 23);
			LivroCb.TabIndex = 26;
			// 
			// DataEmprestada
			// 
			DataEmprestada.Location = new Point(118, 344);
			DataEmprestada.Name = "DataEmprestada";
			DataEmprestada.Size = new Size(181, 23);
			DataEmprestada.TabIndex = 28;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label9.ForeColor = SystemColors.ActiveCaptionText;
			label9.Location = new Point(12, 350);
			label9.Margin = new Padding(4, 0, 4, 0);
			label9.Name = "label9";
			label9.Size = new Size(38, 17);
			label9.TabIndex = 29;
			label9.Text = "Data";
			// 
			// button4
			// 
			button4.BackColor = Color.Yellow;
			button4.FlatAppearance.BorderSize = 0;
			button4.FlatStyle = FlatStyle.Flat;
			button4.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
			button4.Location = new Point(114, 475);
			button4.Name = "button4";
			button4.Size = new Size(83, 28);
			button4.TabIndex = 36;
			button4.Text = "Início";
			button4.UseVisualStyleBackColor = false;
			button4.Click += button4_Click;
			// 
			// button3
			// 
			button3.BackColor = Color.Red;
			button3.FlatAppearance.BorderSize = 0;
			button3.FlatStyle = FlatStyle.Flat;
			button3.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
			button3.Location = new Point(732, 588);
			button3.Name = "button3";
			button3.Size = new Size(94, 28);
			button3.TabIndex = 35;
			button3.Text = "Excluir";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			// 
			// button2
			// 
			button2.BackColor = SystemColors.AppWorkspace;
			button2.FlatAppearance.BorderSize = 0;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
			button2.Location = new Point(447, 588);
			button2.Name = "button2";
			button2.Size = new Size(94, 28);
			button2.TabIndex = 34;
			button2.Text = "Editar";
			button2.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			button1.BackColor = SystemColors.ActiveCaption;
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
			button1.Location = new Point(30, 395);
			button1.Name = "button1";
			button1.Size = new Size(257, 47);
			button1.TabIndex = 33;
			button1.Text = "Emprestar";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// panel2
			// 
			panel2.Dock = DockStyle.Bottom;
			panel2.Location = new Point(0, 632);
			panel2.Name = "panel2";
			panel2.Size = new Size(976, 15);
			panel2.TabIndex = 38;
			// 
			// LivrosEmprestadosDGV
			// 
			dataGridViewCellStyle1.BackColor = Color.White;
			dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = Color.Peru;
			dataGridViewCellStyle1.SelectionForeColor = Color.Black;
			LivrosEmprestadosDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			LivrosEmprestadosDGV.BorderStyle = BorderStyle.Fixed3D;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.White;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = Color.Peru;
			dataGridViewCellStyle2.SelectionForeColor = Color.Black;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			LivrosEmprestadosDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			LivrosEmprestadosDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = Color.White;
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = Color.Peru;
			dataGridViewCellStyle3.SelectionForeColor = Color.White;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
			LivrosEmprestadosDGV.DefaultCellStyle = dataGridViewCellStyle3;
			LivrosEmprestadosDGV.GridColor = SystemColors.ActiveCaptionText;
			LivrosEmprestadosDGV.Location = new Point(317, 105);
			LivrosEmprestadosDGV.Name = "LivrosEmprestadosDGV";
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = Color.White;
			dataGridViewCellStyle4.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle4.ForeColor = Color.White;
			dataGridViewCellStyle4.NullValue = null;
			dataGridViewCellStyle4.SelectionBackColor = Color.White;
			dataGridViewCellStyle4.SelectionForeColor = Color.White;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			LivrosEmprestadosDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			dataGridViewCellStyle5.BackColor = Color.White;
			dataGridViewCellStyle5.SelectionForeColor = Color.White;
			LivrosEmprestadosDGV.RowsDefaultCellStyle = dataGridViewCellStyle5;
			LivrosEmprestadosDGV.RowTemplate.DefaultCellStyle.ForeColor = Color.Peru;
			LivrosEmprestadosDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Peru;
			LivrosEmprestadosDGV.RowTemplate.Height = 25;
			LivrosEmprestadosDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			LivrosEmprestadosDGV.Size = new Size(647, 462);
			LivrosEmprestadosDGV.TabIndex = 43;
			LivrosEmprestadosDGV.CellContentClick += LivrosDGV_CellContentClick;
			// 
			// Frm_LivrosEmprestados
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(976, 647);
			Controls.Add(LivrosEmprestadosDGV);
			Controls.Add(panel2);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label9);
			Controls.Add(DataEmprestada);
			Controls.Add(label8);
			Controls.Add(LivroCb);
			Controls.Add(AlnTelTb);
			Controls.Add(label7);
			Controls.Add(Usn);
			Controls.Add(AlnIdTb);
			Controls.Add(label5);
			Controls.Add(AlnDepTb);
			Controls.Add(label4);
			Controls.Add(AlnNomeTb);
			Controls.Add(label3);
			Controls.Add(AtrasoNumTb);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Frm_LivrosEmprestados";
			Text = "Frm_LivrosAtrasados";
			Load += Frm_LivrosAtrasados_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)LivrosEmprestadosDGV).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField AlnTelTb;
        private Label label7;
        private Label Usn;
        private ComboBox AlnIdTb;
        private Label label5;
        private MaterialSkin.Controls.MaterialSingleLineTextField AlnDepTb;
        private Label label4;
        private MaterialSkin.Controls.MaterialSingleLineTextField AlnNomeTb;
        private Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField AtrasoNumTb;
        private Label label8;
        private ComboBox LivroCb;
        private DateTimePicker DataEmprestada;
        private Label label9;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
		public DataGridView LivrosEmprestadosDGV;
	}
}