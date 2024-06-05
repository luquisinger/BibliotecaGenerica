namespace BibliotecaGenerica
{
    partial class Frm_Colaboradores
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
			ColTelefone = new MaterialSkin.Controls.MaterialSingleLineTextField();
			label6 = new Label();
			panel2 = new Panel();
			button4 = new Button();
			button3 = new Button();
			button2 = new Button();
			button1 = new Button();
			ColSenha = new MaterialSkin.Controls.MaterialSingleLineTextField();
			label7 = new Label();
			ColaboradorDGV = new DataGridView();
			label5 = new Label();
			ColNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
			label4 = new Label();
			ColId = new MaterialSkin.Controls.MaterialSingleLineTextField();
			panel1 = new Panel();
			pictureBox2 = new PictureBox();
			label2 = new Label();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)ColaboradorDGV).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// ColTelefone
			// 
			ColTelefone.Depth = 0;
			ColTelefone.Hint = "";
			ColTelefone.Location = new Point(123, 217);
			ColTelefone.MaxLength = 32767;
			ColTelefone.MouseState = MaterialSkin.MouseState.HOVER;
			ColTelefone.Name = "ColTelefone";
			ColTelefone.PasswordChar = '\0';
			ColTelefone.SelectedText = "";
			ColTelefone.SelectionLength = 0;
			ColTelefone.SelectionStart = 0;
			ColTelefone.Size = new Size(110, 23);
			ColTelefone.TabIndex = 49;
			ColTelefone.TabStop = false;
			ColTelefone.UseSystemPasswordChar = false;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label6.ForeColor = SystemColors.ActiveCaptionText;
			label6.Location = new Point(22, 223);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(59, 17);
			label6.TabIndex = 48;
			label6.Text = "Telefone";
			label6.Click += label6_Click;
			// 
			// panel2
			// 
			panel2.Dock = DockStyle.Bottom;
			panel2.Location = new Point(0, 450);
			panel2.Name = "panel2";
			panel2.Size = new Size(831, 15);
			panel2.TabIndex = 47;
			// 
			// button4
			// 
			button4.BackColor = Color.Yellow;
			button4.FlatAppearance.BorderSize = 0;
			button4.FlatStyle = FlatStyle.Flat;
			button4.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
			button4.Location = new Point(125, 292);
			button4.Name = "button4";
			button4.Size = new Size(83, 28);
			button4.TabIndex = 46;
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
			button3.Location = new Point(214, 258);
			button3.Name = "button3";
			button3.Size = new Size(83, 28);
			button3.TabIndex = 45;
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
			button2.Location = new Point(125, 258);
			button2.Name = "button2";
			button2.Size = new Size(83, 28);
			button2.TabIndex = 44;
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
			button1.Location = new Point(22, 258);
			button1.Name = "button1";
			button1.Size = new Size(97, 28);
			button1.TabIndex = 43;
			button1.Text = "Adicionar";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// ColSenha
			// 
			ColSenha.Depth = 0;
			ColSenha.Hint = "";
			ColSenha.Location = new Point(125, 188);
			ColSenha.MaxLength = 32767;
			ColSenha.MouseState = MaterialSkin.MouseState.HOVER;
			ColSenha.Name = "ColSenha";
			ColSenha.PasswordChar = '\0';
			ColSenha.SelectedText = "";
			ColSenha.SelectionLength = 0;
			ColSenha.SelectionStart = 0;
			ColSenha.Size = new Size(110, 23);
			ColSenha.TabIndex = 42;
			ColSenha.TabStop = false;
			ColSenha.UseSystemPasswordChar = false;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label7.ForeColor = SystemColors.ActiveCaptionText;
			label7.Location = new Point(24, 194);
			label7.Margin = new Padding(4, 0, 4, 0);
			label7.Name = "label7";
			label7.Size = new Size(45, 17);
			label7.TabIndex = 41;
			label7.Text = "Senha";
			// 
			// ColaboradorDGV
			// 
			dataGridViewCellStyle1.BackColor = Color.White;
			dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = Color.Peru;
			dataGridViewCellStyle1.SelectionForeColor = Color.Black;
			ColaboradorDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			ColaboradorDGV.BorderStyle = BorderStyle.Fixed3D;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.White;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = Color.Peru;
			dataGridViewCellStyle2.SelectionForeColor = Color.White;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			ColaboradorDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			ColaboradorDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = Color.White;
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = Color.Peru;
			dataGridViewCellStyle3.SelectionForeColor = Color.White;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
			ColaboradorDGV.DefaultCellStyle = dataGridViewCellStyle3;
			ColaboradorDGV.GridColor = SystemColors.ActiveCaptionText;
			ColaboradorDGV.Location = new Point(331, 103);
			ColaboradorDGV.Name = "ColaboradorDGV";
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = Color.White;
			dataGridViewCellStyle4.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle4.ForeColor = Color.White;
			dataGridViewCellStyle4.NullValue = null;
			dataGridViewCellStyle4.SelectionBackColor = Color.White;
			dataGridViewCellStyle4.SelectionForeColor = Color.White;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			ColaboradorDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			ColaboradorDGV.RowHeadersVisible = false;
			ColaboradorDGV.RowTemplate.Height = 25;
			ColaboradorDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			ColaboradorDGV.Size = new Size(466, 330);
			ColaboradorDGV.TabIndex = 40;
			ColaboradorDGV.CellContentClick += ColaboradorDGV_CellContentClick;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label5.ForeColor = SystemColors.ActiveCaptionText;
			label5.Location = new Point(22, 156);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(44, 17);
			label5.TabIndex = 39;
			label5.Text = "Nome";
			// 
			// ColNome
			// 
			ColNome.Depth = 0;
			ColNome.Hint = "";
			ColNome.Location = new Point(123, 150);
			ColNome.MaxLength = 32767;
			ColNome.MouseState = MaterialSkin.MouseState.HOVER;
			ColNome.Name = "ColNome";
			ColNome.PasswordChar = '\0';
			ColNome.SelectedText = "";
			ColNome.SelectionLength = 0;
			ColNome.SelectionStart = 0;
			ColNome.Size = new Size(110, 23);
			ColNome.TabIndex = 38;
			ColNome.TabStop = false;
			ColNome.UseSystemPasswordChar = false;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label4.ForeColor = SystemColors.ActiveCaptionText;
			label4.Location = new Point(22, 127);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(20, 17);
			label4.TabIndex = 37;
			label4.Text = "ID";
			// 
			// ColId
			// 
			ColId.Depth = 0;
			ColId.Hint = "";
			ColId.Location = new Point(123, 121);
			ColId.MaxLength = 32767;
			ColId.MouseState = MaterialSkin.MouseState.HOVER;
			ColId.Name = "ColId";
			ColId.PasswordChar = '\0';
			ColId.SelectedText = "";
			ColId.SelectionLength = 0;
			ColId.SelectionStart = 0;
			ColId.Size = new Size(110, 23);
			ColId.TabIndex = 36;
			ColId.TabStop = false;
			ColId.UseSystemPasswordChar = false;
			ColId.Click += materialSingleLineTextField2_Click;
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
			panel1.TabIndex = 50;
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
			label2.Size = new Size(214, 33);
			label2.TabIndex = 5;
			label2.Text = "Colaboradores";
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
			// Frm_Colaboradores
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(831, 465);
			Controls.Add(panel1);
			Controls.Add(ColTelefone);
			Controls.Add(label6);
			Controls.Add(panel2);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(ColSenha);
			Controls.Add(label7);
			Controls.Add(ColaboradorDGV);
			Controls.Add(label5);
			Controls.Add(ColNome);
			Controls.Add(label4);
			Controls.Add(ColId);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Frm_Colaboradores";
			Text = "Frm_Colaboradores";
			Load += Frm_Colaboradores_Load;
			((System.ComponentModel.ISupportInitialize)ColaboradorDGV).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MaterialSkin.Controls.MaterialSingleLineTextField ColTelefone;
        private Label label6;
        private Panel panel2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private MaterialSkin.Controls.MaterialSingleLineTextField ColSenha;
        private Label label7;
        private Label label5;
        private MaterialSkin.Controls.MaterialSingleLineTextField ColNome;
        private Label label4;
        private MaterialSkin.Controls.MaterialSingleLineTextField ColId;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
		public DataGridView ColaboradorDGV;
	}
}