namespace BibliotecaGenerica
{
    partial class Frm_Principal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
			panel1 = new Panel();
			pictureBox1 = new PictureBox();
			panel2 = new Panel();
			button8 = new Button();
			button7 = new Button();
			button6 = new Button();
			panel3 = new Panel();
			label1 = new Label();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			button4 = new Button();
			button5 = new Button();
			pictureBox2 = new PictureBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(128, 64, 0);
			panel1.Controls.Add(pictureBox1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1334, 35);
			panel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.icons8_excluir_120;
			pictureBox1.Location = new Point(1271, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(60, 35);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(128, 64, 0);
			panel2.Controls.Add(button8);
			panel2.Controls.Add(button7);
			panel2.Controls.Add(button6);
			panel2.Dock = DockStyle.Bottom;
			panel2.Location = new Point(0, 573);
			panel2.Name = "panel2";
			panel2.Size = new Size(1334, 61);
			panel2.TabIndex = 1;
			// 
			// button8
			// 
			button8.FlatAppearance.BorderSize = 0;
			button8.FlatStyle = FlatStyle.Flat;
			button8.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			button8.Location = new Point(1004, 0);
			button8.Name = "button8";
			button8.Size = new Size(280, 61);
			button8.TabIndex = 2;
			button8.Text = "Dicas";
			button8.UseVisualStyleBackColor = true;
			button8.Click += button8_Click;
			// 
			// button7
			// 
			button7.FlatAppearance.BorderSize = 0;
			button7.FlatStyle = FlatStyle.Flat;
			button7.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			button7.Location = new Point(516, 0);
			button7.Name = "button7";
			button7.Size = new Size(288, 61);
			button7.TabIndex = 1;
			button7.Text = "Menu";
			button7.UseVisualStyleBackColor = true;
			button7.Click += button7_Click;
			// 
			// button6
			// 
			button6.FlatAppearance.BorderSize = 0;
			button6.FlatStyle = FlatStyle.Flat;
			button6.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			button6.Location = new Point(79, 0);
			button6.Name = "button6";
			button6.Size = new Size(320, 61);
			button6.TabIndex = 0;
			button6.Text = "Sobre nós";
			button6.UseVisualStyleBackColor = true;
			button6.Click += button6_Click;
			// 
			// panel3
			// 
			panel3.BackgroundImage = Properties.Resources.abundante_coleccion_libros_antiguos_estantes_madera_generados_ia;
			panel3.BackgroundImageLayout = ImageLayout.Stretch;
			panel3.Dock = DockStyle.Bottom;
			panel3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			panel3.Location = new Point(0, 102);
			panel3.Name = "panel3";
			panel3.Size = new Size(1334, 471);
			panel3.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Century Schoolbook", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.Brown;
			label1.Location = new Point(95, 50);
			label1.Name = "label1";
			label1.Size = new Size(217, 43);
			label1.TabIndex = 3;
			label1.Text = "Biblioteca";
			// 
			// button1
			// 
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
			button1.ForeColor = SystemColors.ButtonFace;
			button1.Location = new Point(356, 57);
			button1.Name = "button1";
			button1.Size = new Size(154, 36);
			button1.TabIndex = 4;
			button1.Text = "Estudantes";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.FlatAppearance.BorderSize = 0;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
			button2.ForeColor = SystemColors.ButtonFace;
			button2.Location = new Point(516, 57);
			button2.Name = "button2";
			button2.Size = new Size(100, 36);
			button2.TabIndex = 5;
			button2.Text = "Livros";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.FlatAppearance.BorderSize = 0;
			button3.FlatStyle = FlatStyle.Flat;
			button3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
			button3.ForeColor = SystemColors.ButtonFace;
			button3.Location = new Point(628, 54);
			button3.Name = "button3";
			button3.Size = new Size(272, 39);
			button3.TabIndex = 6;
			button3.Text = "Livros Emprestados";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button4
			// 
			button4.FlatAppearance.BorderSize = 0;
			button4.FlatStyle = FlatStyle.Flat;
			button4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
			button4.ForeColor = SystemColors.ButtonFace;
			button4.Location = new Point(906, 54);
			button4.Name = "button4";
			button4.Size = new Size(224, 39);
			button4.TabIndex = 7;
			button4.Text = "Livros Devolvidos";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// button5
			// 
			button5.FlatAppearance.BorderSize = 0;
			button5.FlatStyle = FlatStyle.Flat;
			button5.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
			button5.ForeColor = SystemColors.ButtonFace;
			button5.Location = new Point(1136, 51);
			button5.Name = "button5";
			button5.Size = new Size(198, 42);
			button5.TabIndex = 7;
			button5.Text = "Colaboradores";
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(21, 43);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(68, 54);
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 1;
			pictureBox2.TabStop = false;
			// 
			// Frm_Principal
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(192, 192, 0);
			ClientSize = new Size(1334, 634);
			Controls.Add(pictureBox2);
			Controls.Add(button5);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label1);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Frm_Principal";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Frm_Principal";
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private Button button4;
        private Button button5;
        private Button button8;
        private Button button7;
        private Button button6;
        private PictureBox pictureBox2;
    }
}