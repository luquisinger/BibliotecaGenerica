namespace BibliotecaGenerica
{
    partial class Livros
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
			pictureBox1 = new PictureBox();
			label5 = new Label();
			Editora = new MaterialSkin.Controls.MaterialSingleLineTextField();
			label4 = new Label();
			Autor = new MaterialSkin.Controls.MaterialSingleLineTextField();
			label3 = new Label();
			NomeLivro = new MaterialSkin.Controls.MaterialSingleLineTextField();
			panel2 = new Panel();
			button4 = new Button();
			button3 = new Button();
			button2 = new Button();
			button1 = new Button();
			Preco = new MaterialSkin.Controls.MaterialSingleLineTextField();
			label7 = new Label();
			Quantidade = new MaterialSkin.Controls.MaterialSingleLineTextField();
			label6 = new Label();
			LivrosDGV = new DataGridView();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)LivrosDGV).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(128, 64, 0);
			panel1.Controls.Add(pictureBox2);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(pictureBox1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Margin = new Padding(4, 3, 4, 3);
			panel1.Name = "panel1";
			panel1.Size = new Size(831, 82);
			panel1.TabIndex = 2;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = Properties.Resources.icons8_excluir_120;
			pictureBox2.Location = new Point(755, 3);
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
			label2.Size = new Size(86, 33);
			label2.TabIndex = 5;
			label2.Text = "Livros";
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
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.icons8_excluir_120;
			pictureBox1.Location = new Point(858, -1);
			pictureBox1.Margin = new Padding(4, 3, 4, 3);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(42, 27);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label5.ForeColor = SystemColors.ActiveCaptionText;
			label5.Location = new Point(22, 163);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(50, 17);
			label5.TabIndex = 25;
			label5.Text = "Editora";
			// 
			// Editora
			// 
			Editora.Depth = 0;
			Editora.Hint = "";
			Editora.Location = new Point(123, 157);
			Editora.MaxLength = 32767;
			Editora.MouseState = MaterialSkin.MouseState.HOVER;
			Editora.Name = "Editora";
			Editora.PasswordChar = '\0';
			Editora.SelectedText = "";
			Editora.SelectionLength = 0;
			Editora.SelectionStart = 0;
			Editora.Size = new Size(110, 23);
			Editora.TabIndex = 24;
			Editora.TabStop = false;
			Editora.UseSystemPasswordChar = false;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label4.ForeColor = SystemColors.ActiveCaptionText;
			label4.Location = new Point(22, 134);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(41, 17);
			label4.TabIndex = 23;
			label4.Text = "Autor";
			// 
			// Autor
			// 
			Autor.Depth = 0;
			Autor.Hint = "";
			Autor.Location = new Point(123, 128);
			Autor.MaxLength = 32767;
			Autor.MouseState = MaterialSkin.MouseState.HOVER;
			Autor.Name = "Autor";
			Autor.PasswordChar = '\0';
			Autor.SelectedText = "";
			Autor.SelectionLength = 0;
			Autor.SelectionStart = 0;
			Autor.Size = new Size(110, 23);
			Autor.TabIndex = 22;
			Autor.TabStop = false;
			Autor.UseSystemPasswordChar = false;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label3.ForeColor = SystemColors.ActiveCaptionText;
			label3.Location = new Point(22, 105);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(44, 17);
			label3.TabIndex = 21;
			label3.Text = "Nome";
			// 
			// NomeLivro
			// 
			NomeLivro.Depth = 0;
			NomeLivro.Hint = "";
			NomeLivro.Location = new Point(123, 99);
			NomeLivro.MaxLength = 32767;
			NomeLivro.MouseState = MaterialSkin.MouseState.HOVER;
			NomeLivro.Name = "NomeLivro";
			NomeLivro.PasswordChar = '\0';
			NomeLivro.SelectedText = "";
			NomeLivro.SelectionLength = 0;
			NomeLivro.SelectionStart = 0;
			NomeLivro.Size = new Size(110, 23);
			NomeLivro.TabIndex = 20;
			NomeLivro.TabStop = false;
			NomeLivro.UseSystemPasswordChar = false;
			// 
			// panel2
			// 
			panel2.Dock = DockStyle.Bottom;
			panel2.Location = new Point(0, 450);
			panel2.Name = "panel2";
			panel2.Size = new Size(831, 15);
			panel2.TabIndex = 33;
			// 
			// button4
			// 
			button4.BackColor = Color.Yellow;
			button4.FlatAppearance.BorderSize = 0;
			button4.FlatStyle = FlatStyle.Flat;
			button4.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
			button4.Location = new Point(125, 299);
			button4.Name = "button4";
			button4.Size = new Size(83, 28);
			button4.TabIndex = 32;
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
			button3.Location = new Point(214, 265);
			button3.Name = "button3";
			button3.Size = new Size(83, 28);
			button3.TabIndex = 31;
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
			button2.Location = new Point(125, 265);
			button2.Name = "button2";
			button2.Size = new Size(83, 28);
			button2.TabIndex = 30;
			button2.Text = "Editar";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.BackColor = SystemColors.ActiveCaption;
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
			button1.Location = new Point(22, 265);
			button1.Name = "button1";
			button1.Size = new Size(97, 28);
			button1.TabIndex = 29;
			button1.Text = "Adicionar";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// Preco
			// 
			Preco.Depth = 0;
			Preco.Hint = "";
			Preco.Location = new Point(125, 195);
			Preco.MaxLength = 32767;
			Preco.MouseState = MaterialSkin.MouseState.HOVER;
			Preco.Name = "Preco";
			Preco.PasswordChar = '\0';
			Preco.SelectedText = "";
			Preco.SelectionLength = 0;
			Preco.SelectionStart = 0;
			Preco.Size = new Size(110, 23);
			Preco.TabIndex = 28;
			Preco.TabStop = false;
			Preco.UseSystemPasswordChar = false;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label7.ForeColor = SystemColors.ActiveCaptionText;
			label7.Location = new Point(24, 201);
			label7.Margin = new Padding(4, 0, 4, 0);
			label7.Name = "label7";
			label7.Size = new Size(43, 17);
			label7.TabIndex = 27;
			label7.Text = "Preço";
			// 
			// Quantidade
			// 
			Quantidade.Depth = 0;
			Quantidade.Hint = "";
			Quantidade.Location = new Point(123, 224);
			Quantidade.MaxLength = 32767;
			Quantidade.MouseState = MaterialSkin.MouseState.HOVER;
			Quantidade.Name = "Quantidade";
			Quantidade.PasswordChar = '\0';
			Quantidade.SelectedText = "";
			Quantidade.SelectionLength = 0;
			Quantidade.SelectionStart = 0;
			Quantidade.Size = new Size(110, 23);
			Quantidade.TabIndex = 35;
			Quantidade.TabStop = false;
			Quantidade.UseSystemPasswordChar = false;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label6.ForeColor = SystemColors.ActiveCaptionText;
			label6.Location = new Point(22, 230);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(80, 17);
			label6.TabIndex = 34;
			label6.Text = "Quantidade";
			// 
			// LivrosDGV
			// 
			dataGridViewCellStyle1.BackColor = Color.White;
			dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = Color.Peru;
			dataGridViewCellStyle1.SelectionForeColor = Color.Black;
			LivrosDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			LivrosDGV.BorderStyle = BorderStyle.Fixed3D;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.White;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = Color.Peru;
			dataGridViewCellStyle2.SelectionForeColor = Color.Black;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			LivrosDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			LivrosDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = Color.White;
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = Color.Peru;
			dataGridViewCellStyle3.SelectionForeColor = Color.White;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
			LivrosDGV.DefaultCellStyle = dataGridViewCellStyle3;
			LivrosDGV.GridColor = SystemColors.ActiveCaptionText;
			LivrosDGV.Location = new Point(336, 93);
			LivrosDGV.Name = "LivrosDGV";
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = Color.White;
			dataGridViewCellStyle4.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle4.ForeColor = Color.White;
			dataGridViewCellStyle4.NullValue = null;
			dataGridViewCellStyle4.SelectionBackColor = Color.White;
			dataGridViewCellStyle4.SelectionForeColor = Color.White;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			LivrosDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			dataGridViewCellStyle5.BackColor = Color.White;
			dataGridViewCellStyle5.SelectionForeColor = Color.White;
			LivrosDGV.RowsDefaultCellStyle = dataGridViewCellStyle5;
			LivrosDGV.RowTemplate.DefaultCellStyle.ForeColor = Color.Peru;
			LivrosDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Peru;
			LivrosDGV.RowTemplate.Height = 25;
			LivrosDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			LivrosDGV.Size = new Size(461, 351);
			LivrosDGV.TabIndex = 42;
			LivrosDGV.CellContentClick += LivrosDGV_CellContentClick;
			// 
			// Livros
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(831, 465);
			Controls.Add(LivrosDGV);
			Controls.Add(Quantidade);
			Controls.Add(label6);
			Controls.Add(panel2);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(Preco);
			Controls.Add(label7);
			Controls.Add(label5);
			Controls.Add(Editora);
			Controls.Add(label4);
			Controls.Add(Autor);
			Controls.Add(label3);
			Controls.Add(NomeLivro);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Livros";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Livros";
			Load += Livros_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)LivrosDGV).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label5;
        private MaterialSkin.Controls.MaterialSingleLineTextField Editora;
        private Label label4;
        private MaterialSkin.Controls.MaterialSingleLineTextField Autor;
        private Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField NomeLivro;
        private Panel panel2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private MaterialSkin.Controls.MaterialSingleLineTextField Preco;
        private Label label7;
        private MaterialSkin.Controls.MaterialSingleLineTextField Quantidade;
        private Label label6;
		public DataGridView LivrosDGV;
	}
}