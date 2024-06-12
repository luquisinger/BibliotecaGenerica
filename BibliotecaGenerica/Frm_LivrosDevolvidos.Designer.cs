namespace BibliotecaGenerica
{
	partial class Frm_LivrosDevolvidos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_LivrosDevolvidos));
			panel1 = new Panel();
			label2 = new Label();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			LivrosEmprestadosDGV = new DataGridView();
			DataEmprestada = new DateTimePicker();
			AlnTelTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
			label7 = new Label();
			Usn = new Label();
			label5 = new Label();
			AlnDepTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
			label4 = new Label();
			AlnNomeTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
			label3 = new Label();
			DevNumTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
			label6 = new Label();
			DevData = new DateTimePicker();
			label10 = new Label();
			label14 = new Label();
			label15 = new Label();
			label8 = new Label();
			LivrosDevolvidosDGV = new DataGridView();
			button3 = new Button();
			button2 = new Button();
			button4 = new Button();
			button1 = new Button();
			LivroCb = new ComboBox();
			AlnIdTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
			panel3 = new Panel();
			pictureBox6 = new PictureBox();
			printDocument1 = new System.Drawing.Printing.PrintDocument();
			printPreviewDialog1 = new PrintPreviewDialog();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)LivrosEmprestadosDGV).BeginInit();
			((System.ComponentModel.ISupportInitialize)LivrosDevolvidosDGV).BeginInit();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
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
			label2.Location = new Point(372, 42);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(242, 33);
			label2.TabIndex = 5;
			label2.Text = "Livros Devolvidos";
			label2.Click += label2_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.ButtonHighlight;
			label1.Location = new Point(220, 9);
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
			LivrosEmprestadosDGV.Location = new Point(348, 111);
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
			LivrosEmprestadosDGV.Size = new Size(616, 236);
			LivrosEmprestadosDGV.TabIndex = 44;
			LivrosEmprestadosDGV.CellContentClick += LivrosEmprestadosDGV_CellContentClick;
			// 
			// DataEmprestada
			// 
			DataEmprestada.Location = new Point(132, 362);
			DataEmprestada.Name = "DataEmprestada";
			DataEmprestada.Size = new Size(181, 23);
			DataEmprestada.TabIndex = 57;
			// 
			// AlnTelTb
			// 
			AlnTelTb.Depth = 0;
			AlnTelTb.Hint = "";
			AlnTelTb.Location = new Point(133, 288);
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
			label7.Location = new Point(15, 289);
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
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label5.ForeColor = SystemColors.ActiveCaptionText;
			label5.Location = new Point(15, 216);
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
			AlnDepTb.Location = new Point(133, 184);
			AlnDepTb.MaxLength = 32767;
			AlnDepTb.MouseState = MaterialSkin.MouseState.HOVER;
			AlnDepTb.Name = "AlnDepTb";
			AlnDepTb.PasswordChar = '\0';
			AlnDepTb.SelectedText = "";
			AlnDepTb.SelectionLength = 0;
			AlnDepTb.SelectionStart = 0;
			AlnDepTb.Size = new Size(147, 23);
			AlnDepTb.TabIndex = 49;
			AlnDepTb.TabStop = false;
			AlnDepTb.UseSystemPasswordChar = false;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label4.ForeColor = SystemColors.ActiveCaptionText;
			label4.Location = new Point(15, 184);
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
			AlnNomeTb.Location = new Point(132, 216);
			AlnNomeTb.MaxLength = 32767;
			AlnNomeTb.MouseState = MaterialSkin.MouseState.HOVER;
			AlnNomeTb.Name = "AlnNomeTb";
			AlnNomeTb.PasswordChar = '\0';
			AlnNomeTb.SelectedText = "";
			AlnNomeTb.SelectionLength = 0;
			AlnNomeTb.SelectionStart = 0;
			AlnNomeTb.Size = new Size(148, 23);
			AlnNomeTb.TabIndex = 47;
			AlnNomeTb.TabStop = false;
			AlnNomeTb.UseSystemPasswordChar = false;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label3.ForeColor = SystemColors.ActiveCaptionText;
			label3.Location = new Point(15, 148);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(83, 22);
			label3.TabIndex = 46;
			label3.Text = "Número";
			label3.Click += label3_Click;
			// 
			// DevNumTb
			// 
			DevNumTb.Depth = 0;
			DevNumTb.Hint = "";
			DevNumTb.Location = new Point(133, 148);
			DevNumTb.MaxLength = 32767;
			DevNumTb.MouseState = MaterialSkin.MouseState.HOVER;
			DevNumTb.Name = "DevNumTb";
			DevNumTb.PasswordChar = '\0';
			DevNumTb.SelectedText = "";
			DevNumTb.SelectionLength = 0;
			DevNumTb.SelectionStart = 0;
			DevNumTb.Size = new Size(147, 23);
			DevNumTb.TabIndex = 45;
			DevNumTb.TabStop = false;
			DevNumTb.UseSystemPasswordChar = false;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label6.ForeColor = SystemColors.ActiveCaptionText;
			label6.Location = new Point(13, 395);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(83, 22);
			label6.TabIndex = 60;
			label6.Text = "Retorno";
			// 
			// DevData
			// 
			DevData.Location = new Point(132, 395);
			DevData.Name = "DevData";
			DevData.Size = new Size(181, 23);
			DevData.TabIndex = 59;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label10.ForeColor = SystemColors.ActiveCaptionText;
			label10.Location = new Point(585, 85);
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
			label14.Location = new Point(15, 325);
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
			label15.Location = new Point(15, 362);
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
			label8.Location = new Point(585, 350);
			label8.Margin = new Padding(4, 0, 4, 0);
			label8.Name = "label8";
			label8.Size = new Size(167, 23);
			label8.TabIndex = 67;
			label8.Text = "Livros Devolvidos";
			// 
			// LivrosDevolvidosDGV
			// 
			dataGridViewCellStyle6.BackColor = Color.White;
			dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle6.ForeColor = Color.Black;
			dataGridViewCellStyle6.SelectionBackColor = Color.Peru;
			dataGridViewCellStyle6.SelectionForeColor = Color.Black;
			LivrosDevolvidosDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
			LivrosDevolvidosDGV.BorderStyle = BorderStyle.Fixed3D;
			dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = Color.White;
			dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = Color.Peru;
			dataGridViewCellStyle7.SelectionForeColor = Color.Black;
			dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
			LivrosDevolvidosDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			LivrosDevolvidosDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = Color.White;
			dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = Color.Peru;
			dataGridViewCellStyle8.SelectionForeColor = Color.White;
			dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
			LivrosDevolvidosDGV.DefaultCellStyle = dataGridViewCellStyle8;
			LivrosDevolvidosDGV.GridColor = SystemColors.ActiveCaptionText;
			LivrosDevolvidosDGV.Location = new Point(346, 376);
			LivrosDevolvidosDGV.Name = "LivrosDevolvidosDGV";
			dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = Color.White;
			dataGridViewCellStyle9.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle9.ForeColor = Color.White;
			dataGridViewCellStyle9.NullValue = null;
			dataGridViewCellStyle9.SelectionBackColor = Color.White;
			dataGridViewCellStyle9.SelectionForeColor = Color.White;
			dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
			LivrosDevolvidosDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			dataGridViewCellStyle10.BackColor = Color.White;
			dataGridViewCellStyle10.SelectionForeColor = Color.White;
			LivrosDevolvidosDGV.RowsDefaultCellStyle = dataGridViewCellStyle10;
			LivrosDevolvidosDGV.RowTemplate.DefaultCellStyle.ForeColor = Color.Peru;
			LivrosDevolvidosDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Peru;
			LivrosDevolvidosDGV.RowTemplate.Height = 25;
			LivrosDevolvidosDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			LivrosDevolvidosDGV.Size = new Size(617, 212);
			LivrosDevolvidosDGV.TabIndex = 68;
			// 
			// button3
			// 
			button3.BackColor = Color.Red;
			button3.FlatAppearance.BorderSize = 0;
			button3.FlatStyle = FlatStyle.Flat;
			button3.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
			button3.Location = new Point(770, 603);
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
			button2.Location = new Point(463, 603);
			button2.Name = "button2";
			button2.Size = new Size(94, 28);
			button2.TabIndex = 69;
			button2.Text = "Imprimir";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
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
			button1.Location = new Point(36, 440);
			button1.Name = "button1";
			button1.Size = new Size(257, 47);
			button1.TabIndex = 71;
			button1.Text = "Devolver Livro";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// LivroCb
			// 
			LivroCb.FormattingEnabled = true;
			LivroCb.Items.AddRange(new object[] { "1\t", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
			LivroCb.Location = new Point(133, 324);
			LivroCb.Name = "LivroCb";
			LivroCb.Size = new Size(181, 23);
			LivroCb.TabIndex = 55;
			// 
			// AlnIdTb
			// 
			AlnIdTb.Depth = 0;
			AlnIdTb.Hint = "";
			AlnIdTb.Location = new Point(132, 259);
			AlnIdTb.MaxLength = 32767;
			AlnIdTb.MouseState = MaterialSkin.MouseState.HOVER;
			AlnIdTb.Name = "AlnIdTb";
			AlnIdTb.PasswordChar = '\0';
			AlnIdTb.SelectedText = "";
			AlnIdTb.SelectionLength = 0;
			AlnIdTb.SelectionStart = 0;
			AlnIdTb.Size = new Size(43, 23);
			AlnIdTb.TabIndex = 74;
			AlnIdTb.TabStop = false;
			AlnIdTb.UseSystemPasswordChar = false;
			// 
			// panel3
			// 
			panel3.BackColor = Color.FromArgb(128, 64, 0);
			panel3.Controls.Add(pictureBox6);
			panel3.Dock = DockStyle.Bottom;
			panel3.Location = new Point(0, 648);
			panel3.Margin = new Padding(4, 3, 4, 3);
			panel3.Name = "panel3";
			panel3.Size = new Size(976, 10);
			panel3.TabIndex = 75;
			// 
			// pictureBox6
			// 
			pictureBox6.Image = Properties.Resources.icons8_excluir_120;
			pictureBox6.Location = new Point(921, 12);
			pictureBox6.Margin = new Padding(4, 3, 4, 3);
			pictureBox6.Name = "pictureBox6";
			pictureBox6.Size = new Size(42, 27);
			pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox6.TabIndex = 0;
			pictureBox6.TabStop = false;
			// 
			// printDocument1
			// 
			printDocument1.PrintPage += printDocument1_PrintPage;
			// 
			// printPreviewDialog1
			// 
			printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
			printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
			printPreviewDialog1.ClientSize = new Size(400, 300);
			printPreviewDialog1.Document = printDocument1;
			printPreviewDialog1.Enabled = true;
			printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
			printPreviewDialog1.Name = "printPreviewDialog1";
			printPreviewDialog1.Visible = false;
			// 
			// Frm_LivrosDevolvidos
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(976, 658);
			Controls.Add(panel3);
			Controls.Add(AlnIdTb);
			Controls.Add(button4);
			Controls.Add(button1);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(LivrosDevolvidosDGV);
			Controls.Add(label8);
			Controls.Add(label15);
			Controls.Add(label14);
			Controls.Add(label10);
			Controls.Add(label6);
			Controls.Add(DevData);
			Controls.Add(DataEmprestada);
			Controls.Add(LivroCb);
			Controls.Add(AlnTelTb);
			Controls.Add(label7);
			Controls.Add(Usn);
			Controls.Add(label5);
			Controls.Add(AlnDepTb);
			Controls.Add(label4);
			Controls.Add(AlnNomeTb);
			Controls.Add(label3);
			Controls.Add(DevNumTb);
			Controls.Add(LivrosEmprestadosDGV);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Frm_LivrosDevolvidos";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Frm_LivrosRetornados";
			Load += Frm_LivrosRetornados_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)LivrosEmprestadosDGV).EndInit();
			((System.ComponentModel.ISupportInitialize)LivrosDevolvidosDGV).EndInit();
			panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
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
		private MaterialSkin.Controls.MaterialSingleLineTextField AlnTelTb;
		private Label label7;
		private Label Usn;
		private Label label5;
		private MaterialSkin.Controls.MaterialSingleLineTextField AlnDepTb;
		private Label label4;
		private MaterialSkin.Controls.MaterialSingleLineTextField AlnNomeTb;
		private Label label3;
		private MaterialSkin.Controls.MaterialSingleLineTextField DevNumTb;
		private Label label6;
		private DateTimePicker DevData;
		private Label label10;
		private Label label14;
		private Label label15;
		private Label label8;
		public DataGridView LivrosDevolvidosDGV;
		private Button button3;
		private Button button2;
		private Button button4;
		private Button button1;
		private ComboBox LivroCb;
		private MaterialSkin.Controls.MaterialSingleLineTextField AlnIdTb;
		private Panel panel3;
		private PictureBox pictureBox6;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private PrintPreviewDialog printPreviewDialog1;
	}
}