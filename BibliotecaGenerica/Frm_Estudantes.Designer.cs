namespace BibliotecaGenerica
{
    partial class Frm_Estudantes
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
			panel1 = new Panel();
			pictureBox2 = new PictureBox();
			label2 = new Label();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
			AlnId = new MaterialSkin.Controls.MaterialSingleLineTextField();
			label3 = new Label();
			label4 = new Label();
			AlnNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
			label5 = new Label();
			AlnDepartamento = new MaterialSkin.Controls.MaterialSingleLineTextField();
			AlnSemestre = new ComboBox();
			label6 = new Label();
			label7 = new Label();
			AlnNumero = new MaterialSkin.Controls.MaterialSingleLineTextField();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			button4 = new Button();
			panel2 = new Panel();
			AlunoDGV = new DataGridView();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)AlunoDGV).BeginInit();
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
			panel1.Size = new Size(847, 82);
			panel1.TabIndex = 1;
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
			label2.Size = new Size(146, 33);
			label2.TabIndex = 5;
			label2.Text = "Estudante";
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
			// materialContextMenuStrip1
			// 
			materialContextMenuStrip1.BackColor = Color.FromArgb(255, 255, 255);
			materialContextMenuStrip1.Depth = 0;
			materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
			materialContextMenuStrip1.Name = "materialContextMenuStrip1";
			materialContextMenuStrip1.Size = new Size(61, 4);
			// 
			// AlnId
			// 
			AlnId.Depth = 0;
			AlnId.Hint = "";
			AlnId.Location = new Point(114, 138);
			AlnId.MaxLength = 32767;
			AlnId.MouseState = MaterialSkin.MouseState.HOVER;
			AlnId.Name = "AlnId";
			AlnId.PasswordChar = '\0';
			AlnId.SelectedText = "";
			AlnId.SelectionLength = 0;
			AlnId.SelectionStart = 0;
			AlnId.Size = new Size(110, 23);
			AlnId.TabIndex = 2;
			AlnId.TabStop = false;
			AlnId.UseSystemPasswordChar = false;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label3.ForeColor = SystemColors.ActiveCaptionText;
			label3.Location = new Point(13, 144);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(55, 17);
			label3.TabIndex = 6;
			label3.Text = "Número";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label4.ForeColor = SystemColors.ActiveCaptionText;
			label4.Location = new Point(13, 173);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(44, 17);
			label4.TabIndex = 8;
			label4.Text = "Nome";
			// 
			// AlnNome
			// 
			AlnNome.Depth = 0;
			AlnNome.Hint = "";
			AlnNome.Location = new Point(114, 167);
			AlnNome.MaxLength = 32767;
			AlnNome.MouseState = MaterialSkin.MouseState.HOVER;
			AlnNome.Name = "AlnNome";
			AlnNome.PasswordChar = '\0';
			AlnNome.SelectedText = "";
			AlnNome.SelectionLength = 0;
			AlnNome.SelectionStart = 0;
			AlnNome.Size = new Size(110, 23);
			AlnNome.TabIndex = 7;
			AlnNome.TabStop = false;
			AlnNome.UseSystemPasswordChar = false;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label5.ForeColor = SystemColors.ActiveCaptionText;
			label5.Location = new Point(13, 202);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(97, 17);
			label5.TabIndex = 10;
			label5.Text = "Departamento";
			// 
			// AlnDepartamento
			// 
			AlnDepartamento.Depth = 0;
			AlnDepartamento.Hint = "";
			AlnDepartamento.Location = new Point(114, 196);
			AlnDepartamento.MaxLength = 32767;
			AlnDepartamento.MouseState = MaterialSkin.MouseState.HOVER;
			AlnDepartamento.Name = "AlnDepartamento";
			AlnDepartamento.PasswordChar = '\0';
			AlnDepartamento.SelectedText = "";
			AlnDepartamento.SelectionLength = 0;
			AlnDepartamento.SelectionStart = 0;
			AlnDepartamento.Size = new Size(110, 23);
			AlnDepartamento.TabIndex = 9;
			AlnDepartamento.TabStop = false;
			AlnDepartamento.UseSystemPasswordChar = false;
			// 
			// AlnSemestre
			// 
			AlnSemestre.FormattingEnabled = true;
			AlnSemestre.Items.AddRange(new object[] { "1\t", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
			AlnSemestre.Location = new Point(114, 231);
			AlnSemestre.Name = "AlnSemestre";
			AlnSemestre.Size = new Size(110, 23);
			AlnSemestre.TabIndex = 11;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label6.ForeColor = SystemColors.ActiveCaptionText;
			label6.Location = new Point(13, 237);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(64, 17);
			label6.TabIndex = 12;
			label6.Text = "Semestre";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label7.ForeColor = SystemColors.ActiveCaptionText;
			label7.Location = new Point(13, 274);
			label7.Margin = new Padding(4, 0, 4, 0);
			label7.Name = "label7";
			label7.Size = new Size(59, 17);
			label7.TabIndex = 14;
			label7.Text = "Telefone";
			// 
			// AlnNumero
			// 
			AlnNumero.Depth = 0;
			AlnNumero.Hint = "";
			AlnNumero.Location = new Point(114, 268);
			AlnNumero.MaxLength = 32767;
			AlnNumero.MouseState = MaterialSkin.MouseState.HOVER;
			AlnNumero.Name = "AlnNumero";
			AlnNumero.PasswordChar = '\0';
			AlnNumero.SelectedText = "";
			AlnNumero.SelectionLength = 0;
			AlnNumero.SelectionStart = 0;
			AlnNumero.Size = new Size(110, 23);
			AlnNumero.TabIndex = 15;
			AlnNumero.TabStop = false;
			AlnNumero.UseSystemPasswordChar = false;
			// 
			// button1
			// 
			button1.BackColor = SystemColors.ActiveCaption;
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
			button1.Location = new Point(13, 322);
			button1.Name = "button1";
			button1.Size = new Size(97, 28);
			button1.TabIndex = 16;
			button1.Text = "Adicionar";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.BackColor = SystemColors.AppWorkspace;
			button2.FlatAppearance.BorderSize = 0;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
			button2.Location = new Point(116, 322);
			button2.Name = "button2";
			button2.Size = new Size(83, 28);
			button2.TabIndex = 17;
			button2.Text = "Editar";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.BackColor = Color.Red;
			button3.FlatAppearance.BorderSize = 0;
			button3.FlatStyle = FlatStyle.Flat;
			button3.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
			button3.Location = new Point(205, 322);
			button3.Name = "button3";
			button3.Size = new Size(83, 28);
			button3.TabIndex = 18;
			button3.Text = "Excluir";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			// 
			// button4
			// 
			button4.BackColor = Color.Yellow;
			button4.FlatAppearance.BorderSize = 0;
			button4.FlatStyle = FlatStyle.Flat;
			button4.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
			button4.Location = new Point(116, 356);
			button4.Name = "button4";
			button4.Size = new Size(83, 28);
			button4.TabIndex = 20;
			button4.Text = "Início";
			button4.UseVisualStyleBackColor = false;
			button4.Click += button4_Click;
			// 
			// panel2
			// 
			panel2.Dock = DockStyle.Bottom;
			panel2.Location = new Point(0, 489);
			panel2.Name = "panel2";
			panel2.Size = new Size(847, 15);
			panel2.TabIndex = 21;
			// 
			// AlunoDGV
			// 
			dataGridViewCellStyle1.BackColor = Color.White;
			dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = Color.Peru;
			dataGridViewCellStyle1.SelectionForeColor = Color.Black;
			AlunoDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			AlunoDGV.BorderStyle = BorderStyle.Fixed3D;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.White;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = Color.Peru;
			dataGridViewCellStyle2.SelectionForeColor = Color.White;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			AlunoDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			AlunoDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = Color.White;
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = Color.Peru;
			dataGridViewCellStyle3.SelectionForeColor = Color.White;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
			AlunoDGV.DefaultCellStyle = dataGridViewCellStyle3;
			AlunoDGV.GridColor = SystemColors.ActiveCaptionText;
			AlunoDGV.Location = new Point(331, 108);
			AlunoDGV.Name = "AlunoDGV";
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = Color.White;
			dataGridViewCellStyle4.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle4.ForeColor = Color.White;
			dataGridViewCellStyle4.NullValue = null;
			dataGridViewCellStyle4.SelectionBackColor = Color.White;
			dataGridViewCellStyle4.SelectionForeColor = Color.White;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			AlunoDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			AlunoDGV.RowHeadersVisible = false;
			AlunoDGV.RowTemplate.Height = 25;
			AlunoDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			AlunoDGV.Size = new Size(483, 360);
			AlunoDGV.TabIndex = 41;
			AlunoDGV.CellContentClick += AlunoDGV_CellContentClick;
			// 
			// Frm_Estudantes
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(847, 504);
			Controls.Add(AlunoDGV);
			Controls.Add(panel2);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(AlnNumero);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(AlnSemestre);
			Controls.Add(label5);
			Controls.Add(AlnDepartamento);
			Controls.Add(label4);
			Controls.Add(AlnNome);
			Controls.Add(label3);
			Controls.Add(AlnId);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(4, 3, 4, 3);
			Name = "Frm_Estudantes";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			Load += Frm_Estudantes_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)AlunoDGV).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialSingleLineTextField AlnId;
        private Label label3;
        private Label label4;
        private MaterialSkin.Controls.MaterialSingleLineTextField AlnNome;
        private Label label5;
        private MaterialSkin.Controls.MaterialSingleLineTextField AlnDepartamento;
        private ComboBox AlnSemestre;
        private Label label6;
        private Label label7;
        private MaterialSkin.Controls.MaterialSingleLineTextField AlnNumero;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox2;
        private Button button4;
        private Panel panel2;
		public DataGridView AlunoDGV;
	}
}