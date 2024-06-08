namespace BibliotecaGenerica
{
	partial class Frm_LivrosRetornados
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
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
			panel1 = new Panel();
			label2 = new Label();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			LivrosEmprestadosDGV = new DataGridView();
			DataEmprestada = new DateTimePicker();
			LivroCb = new ComboBox();
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
			label6 = new Label();
			dateTimePicker1 = new DateTimePicker();
			label10 = new Label();
			label14 = new Label();
			label15 = new Label();
			label8 = new Label();
			dataGridView1 = new DataGridView();
			button3 = new Button();
			button2 = new Button();
			button4 = new Button();
			button1 = new Button();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)LivrosEmprestadosDGV).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(128, 64, 0);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(pictureBox1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Margin = new Padding(4, 3, 4, 3);
			panel1.Name = "panel1";
			panel1.Size = new Size(976, 82);
			panel1.TabIndex = 4;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			label2.ForeColor = SystemColors.ButtonHighlight;
			label2.Location = new Point(308, 42);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(244, 33);
			label2.TabIndex = 5;
			label2.Text = "Livros Retornados";
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
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.icons8_excluir_120;
			pictureBox1.Location = new Point(921, 12);
			pictureBox1.Margin = new Padding(4, 3, 4, 3);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(42, 27);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
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
			LivrosEmprestadosDGV.Location = new Point(347, 124);
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
			LivrosEmprestadosDGV.Size = new Size(606, 236);
			LivrosEmprestadosDGV.TabIndex = 44;
			LivrosEmprestadosDGV.CellContentClick += LivrosEmprestadosDGV_CellContentClick;
			// 
			// DataEmprestada
			// 
			DataEmprestada.Location = new Point(132, 338);
			DataEmprestada.Name = "DataEmprestada";
			DataEmprestada.Size = new Size(181, 23);
			DataEmprestada.TabIndex = 57;
			// 
			// LivroCb
			// 
			LivroCb.FormattingEnabled = true;
			LivroCb.Items.AddRange(new object[] { "1\t", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
			LivroCb.Location = new Point(132, 308);
			LivroCb.Name = "LivroCb";
			LivroCb.Size = new Size(181, 23);
			LivroCb.TabIndex = 55;
			// 
			// AlnTelTb
			// 
			AlnTelTb.Depth = 0;
			AlnTelTb.Hint = "";
			AlnTelTb.Location = new Point(133, 279);
			AlnTelTb.MaxLength = 32767;
			AlnTelTb.MouseState = MaterialSkin.MouseState.HOVER;
			AlnTelTb.Name = "AlnTelTb";
			AlnTelTb.PasswordChar = '\0';
			AlnTelTb.SelectedText = "";
			AlnTelTb.SelectionLength = 0;
			AlnTelTb.SelectionStart = 0;
			AlnTelTb.Size = new Size(147, 23);
			AlnTelTb.TabIndex = 54;
			AlnTelTb.TabStop = false;
			AlnTelTb.UseSystemPasswordChar = false;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label7.ForeColor = SystemColors.ActiveCaptionText;
			label7.Location = new Point(15, 280);
			label7.Margin = new Padding(4, 0, 4, 0);
			label7.Name = "label7";
			label7.Size = new Size(87, 22);
			label7.TabIndex = 53;
			label7.Text = "Telefone";
			// 
			// Usn
			// 
			Usn.AutoSize = true;
			Usn.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			Usn.ForeColor = SystemColors.ActiveCaptionText;
			Usn.Location = new Point(15, 255);
			Usn.Margin = new Padding(4, 0, 4, 0);
			Usn.Name = "Usn";
			Usn.Size = new Size(88, 22);
			Usn.TabIndex = 52;
			Usn.Text = "Aluno ID";
			// 
			// AlnIdTb
			// 
			AlnIdTb.FormattingEnabled = true;
			AlnIdTb.Items.AddRange(new object[] { "1\t", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
			AlnIdTb.Location = new Point(133, 254);
			AlnIdTb.Name = "AlnIdTb";
			AlnIdTb.Size = new Size(110, 23);
			AlnIdTb.TabIndex = 51;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label5.ForeColor = SystemColors.ActiveCaptionText;
			label5.Location = new Point(15, 229);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(54, 22);
			label5.TabIndex = 50;
			label5.Text = "Dep.";
			// 
			// AlnDepTb
			// 
			AlnDepTb.Depth = 0;
			AlnDepTb.Hint = "";
			AlnDepTb.Location = new Point(133, 206);
			AlnDepTb.MaxLength = 32767;
			AlnDepTb.MouseState = MaterialSkin.MouseState.HOVER;
			AlnDepTb.Name = "AlnDepTb";
			AlnDepTb.PasswordChar = '\0';
			AlnDepTb.SelectedText = "";
			AlnDepTb.SelectionLength = 0;
			AlnDepTb.SelectionStart = 0;
			AlnDepTb.Size = new Size(110, 23);
			AlnDepTb.TabIndex = 49;
			AlnDepTb.TabStop = false;
			AlnDepTb.UseSystemPasswordChar = false;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label4.ForeColor = SystemColors.ActiveCaptionText;
			label4.Location = new Point(15, 206);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(65, 22);
			label4.TabIndex = 48;
			label4.Text = "Nome";
			// 
			// AlnNomeTb
			// 
			AlnNomeTb.Depth = 0;
			AlnNomeTb.Hint = "";
			AlnNomeTb.Location = new Point(132, 206);
			AlnNomeTb.MaxLength = 32767;
			AlnNomeTb.MouseState = MaterialSkin.MouseState.HOVER;
			AlnNomeTb.Name = "AlnNomeTb";
			AlnNomeTb.PasswordChar = '\0';
			AlnNomeTb.SelectedText = "";
			AlnNomeTb.SelectionLength = 0;
			AlnNomeTb.SelectionStart = 0;
			AlnNomeTb.Size = new Size(110, 23);
			AlnNomeTb.TabIndex = 47;
			AlnNomeTb.TabStop = false;
			AlnNomeTb.UseSystemPasswordChar = false;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label3.ForeColor = SystemColors.ActiveCaptionText;
			label3.Location = new Point(15, 184);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(83, 22);
			label3.TabIndex = 46;
			label3.Text = "Número";
			label3.Click += label3_Click;
			// 
			// AtrasoNumTb
			// 
			AtrasoNumTb.Depth = 0;
			AtrasoNumTb.Hint = "";
			AtrasoNumTb.Location = new Point(132, 177);
			AtrasoNumTb.MaxLength = 32767;
			AtrasoNumTb.MouseState = MaterialSkin.MouseState.HOVER;
			AtrasoNumTb.Name = "AtrasoNumTb";
			AtrasoNumTb.PasswordChar = '\0';
			AtrasoNumTb.SelectedText = "";
			AtrasoNumTb.SelectionLength = 0;
			AtrasoNumTb.SelectionStart = 0;
			AtrasoNumTb.Size = new Size(110, 23);
			AtrasoNumTb.TabIndex = 45;
			AtrasoNumTb.TabStop = false;
			AtrasoNumTb.UseSystemPasswordChar = false;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label6.ForeColor = SystemColors.ActiveCaptionText;
			label6.Location = new Point(15, 368);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(83, 22);
			label6.TabIndex = 60;
			label6.Text = "Retorno";
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(132, 367);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(181, 23);
			dateTimePicker1.TabIndex = 59;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label10.ForeColor = SystemColors.ActiveCaptionText;
			label10.Location = new Point(600, 98);
			label10.Margin = new Padding(4, 0, 4, 0);
			label10.Name = "label10";
			label10.Size = new Size(184, 23);
			label10.TabIndex = 61;
			label10.Text = "Livros Emprestados";
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label14.ForeColor = SystemColors.ActiveCaptionText;
			label14.Location = new Point(15, 309);
			label14.Margin = new Padding(4, 0, 4, 0);
			label14.Name = "label14";
			label14.Size = new Size(53, 22);
			label14.TabIndex = 65;
			label14.Text = "Livro";
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label15.ForeColor = SystemColors.ActiveCaptionText;
			label15.Location = new Point(15, 338);
			label15.Margin = new Padding(4, 0, 4, 0);
			label15.Name = "label15";
			label15.Size = new Size(114, 22);
			label15.TabIndex = 66;
			label15.Text = "Emprestimo";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label8.ForeColor = SystemColors.ActiveCaptionText;
			label8.Location = new Point(600, 366);
			label8.Margin = new Padding(4, 0, 4, 0);
			label8.Name = "label8";
			label8.Size = new Size(169, 23);
			label8.TabIndex = 67;
			label8.Text = "Livros Retornados";
			// 
			// dataGridView1
			// 
			dataGridViewCellStyle6.BackColor = Color.White;
			dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle6.ForeColor = Color.Black;
			dataGridViewCellStyle6.SelectionBackColor = Color.Peru;
			dataGridViewCellStyle6.SelectionForeColor = Color.Black;
			dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
			dataGridView1.BorderStyle = BorderStyle.Fixed3D;
			dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = Color.White;
			dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = Color.Peru;
			dataGridViewCellStyle7.SelectionForeColor = Color.Black;
			dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
			dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = Color.White;
			dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = Color.Peru;
			dataGridViewCellStyle8.SelectionForeColor = Color.White;
			dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
			dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
			dataGridView1.GridColor = SystemColors.ActiveCaptionText;
			dataGridView1.Location = new Point(347, 398);
			dataGridView1.Name = "dataGridView1";
			dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = Color.White;
			dataGridViewCellStyle9.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle9.ForeColor = Color.White;
			dataGridViewCellStyle9.NullValue = null;
			dataGridViewCellStyle9.SelectionBackColor = Color.White;
			dataGridViewCellStyle9.SelectionForeColor = Color.White;
			dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
			dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			dataGridViewCellStyle10.BackColor = Color.White;
			dataGridViewCellStyle10.SelectionForeColor = Color.White;
			dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
			dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.Peru;
			dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Peru;
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new Size(606, 212);
			dataGridView1.TabIndex = 68;
			// 
			// button3
			// 
			button3.BackColor = Color.Red;
			button3.FlatAppearance.BorderSize = 0;
			button3.FlatStyle = FlatStyle.Flat;
			button3.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
			button3.Location = new Point(722, 616);
			button3.Name = "button3";
			button3.Size = new Size(94, 28);
			button3.TabIndex = 70;
			button3.Text = "Excluir";
			button3.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			button2.BackColor = SystemColors.AppWorkspace;
			button2.FlatAppearance.BorderSize = 0;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
			button2.Location = new Point(437, 616);
			button2.Name = "button2";
			button2.Size = new Size(94, 28);
			button2.TabIndex = 69;
			button2.Text = "Imprimir";
			button2.UseVisualStyleBackColor = false;
			// 
			// button4
			// 
			button4.BackColor = Color.Yellow;
			button4.FlatAppearance.BorderSize = 0;
			button4.FlatStyle = FlatStyle.Flat;
			button4.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
			button4.Location = new Point(118, 520);
			button4.Name = "button4";
			button4.Size = new Size(83, 28);
			button4.TabIndex = 72;
			button4.Text = "Início";
			button4.UseVisualStyleBackColor = false;
			button4.Click += button4_Click;
			// 
			// button1
			// 
			button1.BackColor = SystemColors.ActiveCaption;
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
			button1.Location = new Point(32, 420);
			button1.Name = "button1";
			button1.Size = new Size(257, 47);
			button1.TabIndex = 71;
			button1.Text = "Emprestar";
			button1.UseVisualStyleBackColor = false;
			// 
			// Frm_LivrosRetornados
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(976, 647);
			Controls.Add(button4);
			Controls.Add(button1);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(dataGridView1);
			Controls.Add(label8);
			Controls.Add(label15);
			Controls.Add(label14);
			Controls.Add(label10);
			Controls.Add(label6);
			Controls.Add(dateTimePicker1);
			Controls.Add(DataEmprestada);
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
			Controls.Add(LivrosEmprestadosDGV);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Frm_LivrosRetornados";
			Text = "Frm_LivrosRetornados";
			Load += Frm_LivrosRetornados_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)LivrosEmprestadosDGV).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Label label2;
		private Label label1;
		private PictureBox pictureBox1;
		public DataGridView LivrosEmprestadosDGV;
		private DateTimePicker DataEmprestada;
		private ComboBox LivroCb;
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
		private Label label6;
		private DateTimePicker dateTimePicker1;
		private Label label10;
		private Label label14;
		private Label label15;
		private Label label8;
		public DataGridView dataGridView1;
		private Button button3;
		private Button button2;
		private Button button4;
		private Button button1;
	}
}