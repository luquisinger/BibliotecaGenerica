namespace BibliotecaGenerica
{
    partial class Frm_LivrosAtrasados
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
			panel1 = new Panel();
			pictureBox2 = new PictureBox();
			label2 = new Label();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			AlnTelTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
			label7 = new Label();
			Usn = new Label();
			AlnIdTb = new ComboBox();
			label5 = new Label();
			AlnDepTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
			label4 = new Label();
			AlnNomeTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
			label3 = new Label();
			materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
			label8 = new Label();
			LivroCb = new ComboBox();
			dateTimePicker1 = new DateTimePicker();
			label9 = new Label();
			button4 = new Button();
			button3 = new Button();
			button2 = new Button();
			button1 = new Button();
			panel2 = new Panel();
			dataGridView1 = new DataGridView();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
			panel1.TabIndex = 3;
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
			label2.Size = new Size(223, 33);
			label2.TabIndex = 5;
			label2.Text = "Livros Atrasados";
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
			// AlnTelTb
			// 
			AlnTelTb.Depth = 0;
			AlnTelTb.Hint = "";
			AlnTelTb.Location = new Point(114, 221);
			AlnTelTb.MaxLength = 32767;
			AlnTelTb.MouseState = MaterialSkin.MouseState.HOVER;
			AlnTelTb.Name = "AlnTelTb";
			AlnTelTb.PasswordChar = '\0';
			AlnTelTb.SelectedText = "";
			AlnTelTb.SelectionLength = 0;
			AlnTelTb.SelectionStart = 0;
			AlnTelTb.Size = new Size(110, 23);
			AlnTelTb.TabIndex = 25;
			AlnTelTb.TabStop = false;
			AlnTelTb.UseSystemPasswordChar = false;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label7.ForeColor = SystemColors.ActiveCaptionText;
			label7.Location = new Point(13, 227);
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
			Usn.Location = new Point(13, 198);
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
			AlnIdTb.Location = new Point(114, 192);
			AlnIdTb.Name = "AlnIdTb";
			AlnIdTb.Size = new Size(110, 23);
			AlnIdTb.TabIndex = 22;
			AlnIdTb.SelectionChangeCommitted += AlunoId_SelectionChangeCommitted;
			AlnIdTb.SelectedValueChanged += AlunoId_SelectedValueChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label5.ForeColor = SystemColors.ActiveCaptionText;
			label5.Location = new Point(13, 163);
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
			AlnDepTb.Location = new Point(114, 163);
			AlnDepTb.MaxLength = 32767;
			AlnDepTb.MouseState = MaterialSkin.MouseState.HOVER;
			AlnDepTb.Name = "AlnDepTb";
			AlnDepTb.PasswordChar = '\0';
			AlnDepTb.SelectedText = "";
			AlnDepTb.SelectionLength = 0;
			AlnDepTb.SelectionStart = 0;
			AlnDepTb.Size = new Size(110, 23);
			AlnDepTb.TabIndex = 20;
			AlnDepTb.TabStop = false;
			AlnDepTb.UseSystemPasswordChar = false;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label4.ForeColor = SystemColors.ActiveCaptionText;
			label4.Location = new Point(13, 134);
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
			AlnNomeTb.Location = new Point(114, 134);
			AlnNomeTb.MaxLength = 32767;
			AlnNomeTb.MouseState = MaterialSkin.MouseState.HOVER;
			AlnNomeTb.Name = "AlnNomeTb";
			AlnNomeTb.PasswordChar = '\0';
			AlnNomeTb.SelectedText = "";
			AlnNomeTb.SelectionLength = 0;
			AlnNomeTb.SelectionStart = 0;
			AlnNomeTb.Size = new Size(110, 23);
			AlnNomeTb.TabIndex = 18;
			AlnNomeTb.TabStop = false;
			AlnNomeTb.UseSystemPasswordChar = false;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label3.ForeColor = SystemColors.ActiveCaptionText;
			label3.Location = new Point(13, 111);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(55, 17);
			label3.TabIndex = 17;
			label3.Text = "Número";
			// 
			// materialSingleLineTextField1
			// 
			materialSingleLineTextField1.Depth = 0;
			materialSingleLineTextField1.Hint = "";
			materialSingleLineTextField1.Location = new Point(114, 105);
			materialSingleLineTextField1.MaxLength = 32767;
			materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
			materialSingleLineTextField1.Name = "materialSingleLineTextField1";
			materialSingleLineTextField1.PasswordChar = '\0';
			materialSingleLineTextField1.SelectedText = "";
			materialSingleLineTextField1.SelectionLength = 0;
			materialSingleLineTextField1.SelectionStart = 0;
			materialSingleLineTextField1.Size = new Size(110, 23);
			materialSingleLineTextField1.TabIndex = 16;
			materialSingleLineTextField1.TabStop = false;
			materialSingleLineTextField1.UseSystemPasswordChar = false;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label8.ForeColor = SystemColors.ActiveCaptionText;
			label8.Location = new Point(13, 256);
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
			LivroCb.Location = new Point(114, 250);
			LivroCb.Name = "LivroCb";
			LivroCb.Size = new Size(110, 23);
			LivroCb.TabIndex = 26;
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(114, 279);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(110, 23);
			dateTimePicker1.TabIndex = 28;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label9.ForeColor = SystemColors.ActiveCaptionText;
			label9.Location = new Point(13, 285);
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
			button4.Location = new Point(114, 362);
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
			button3.Location = new Point(203, 328);
			button3.Name = "button3";
			button3.Size = new Size(83, 28);
			button3.TabIndex = 35;
			button3.Text = "Excluir";
			button3.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			button2.BackColor = SystemColors.AppWorkspace;
			button2.FlatAppearance.BorderSize = 0;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
			button2.Location = new Point(114, 328);
			button2.Name = "button2";
			button2.Size = new Size(83, 28);
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
			button1.Location = new Point(11, 328);
			button1.Name = "button1";
			button1.Size = new Size(97, 28);
			button1.TabIndex = 33;
			button1.Text = "Adicionar";
			button1.UseVisualStyleBackColor = false;
			// 
			// panel2
			// 
			panel2.Dock = DockStyle.Bottom;
			panel2.Location = new Point(0, 450);
			panel2.Name = "panel2";
			panel2.Size = new Size(831, 15);
			panel2.TabIndex = 38;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(331, 88);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(466, 330);
			dataGridView1.TabIndex = 37;
			// 
			// Frm_LivrosAtrasados
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(831, 465);
			Controls.Add(panel2);
			Controls.Add(dataGridView1);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label9);
			Controls.Add(dateTimePicker1);
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
			Controls.Add(materialSingleLineTextField1);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Frm_LivrosAtrasados";
			Text = "Frm_LivrosAtrasados";
			Load += Frm_LivrosAtrasados_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField AlnTelTb;
        private Label label7;
        private Label Usn;
        private ComboBox AlnIdTb;
        private Label label5;
        private MaterialSkin.Controls.MaterialSingleLineTextField AlnDepTb;
        private Label label4;
        private MaterialSkin.Controls.MaterialSingleLineTextField AlnNomeTb;
        private Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private Label label8;
        private ComboBox LivroCb;
        private DateTimePicker dateTimePicker1;
        private Label label9;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private DataGridView dataGridView1;
    }
}