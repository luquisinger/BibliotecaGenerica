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
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            label3 = new Label();
            label4 = new Label();
            materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            label5 = new Label();
            materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            materialSingleLineTextField4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            panel2 = new Panel();
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
            // materialSingleLineTextField1
            // 
            materialSingleLineTextField1.Depth = 0;
            materialSingleLineTextField1.Hint = "";
            materialSingleLineTextField1.Location = new Point(114, 138);
            materialSingleLineTextField1.MaxLength = 32767;
            materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            materialSingleLineTextField1.PasswordChar = '\0';
            materialSingleLineTextField1.SelectedText = "";
            materialSingleLineTextField1.SelectionLength = 0;
            materialSingleLineTextField1.SelectionStart = 0;
            materialSingleLineTextField1.Size = new Size(110, 23);
            materialSingleLineTextField1.TabIndex = 2;
            materialSingleLineTextField1.TabStop = false;
            materialSingleLineTextField1.UseSystemPasswordChar = false;
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
            // materialSingleLineTextField2
            // 
            materialSingleLineTextField2.Depth = 0;
            materialSingleLineTextField2.Hint = "";
            materialSingleLineTextField2.Location = new Point(114, 167);
            materialSingleLineTextField2.MaxLength = 32767;
            materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            materialSingleLineTextField2.PasswordChar = '\0';
            materialSingleLineTextField2.SelectedText = "";
            materialSingleLineTextField2.SelectionLength = 0;
            materialSingleLineTextField2.SelectionStart = 0;
            materialSingleLineTextField2.Size = new Size(110, 23);
            materialSingleLineTextField2.TabIndex = 7;
            materialSingleLineTextField2.TabStop = false;
            materialSingleLineTextField2.UseSystemPasswordChar = false;
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
            // materialSingleLineTextField3
            // 
            materialSingleLineTextField3.Depth = 0;
            materialSingleLineTextField3.Hint = "";
            materialSingleLineTextField3.Location = new Point(114, 196);
            materialSingleLineTextField3.MaxLength = 32767;
            materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
            materialSingleLineTextField3.Name = "materialSingleLineTextField3";
            materialSingleLineTextField3.PasswordChar = '\0';
            materialSingleLineTextField3.SelectedText = "";
            materialSingleLineTextField3.SelectionLength = 0;
            materialSingleLineTextField3.SelectionStart = 0;
            materialSingleLineTextField3.Size = new Size(110, 23);
            materialSingleLineTextField3.TabIndex = 9;
            materialSingleLineTextField3.TabStop = false;
            materialSingleLineTextField3.UseSystemPasswordChar = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1\t", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBox1.Location = new Point(114, 231);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(110, 23);
            comboBox1.TabIndex = 11;
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
            // materialSingleLineTextField4
            // 
            materialSingleLineTextField4.Depth = 0;
            materialSingleLineTextField4.Hint = "";
            materialSingleLineTextField4.Location = new Point(114, 268);
            materialSingleLineTextField4.MaxLength = 32767;
            materialSingleLineTextField4.MouseState = MaterialSkin.MouseState.HOVER;
            materialSingleLineTextField4.Name = "materialSingleLineTextField4";
            materialSingleLineTextField4.PasswordChar = '\0';
            materialSingleLineTextField4.SelectedText = "";
            materialSingleLineTextField4.SelectionLength = 0;
            materialSingleLineTextField4.SelectionStart = 0;
            materialSingleLineTextField4.Size = new Size(110, 23);
            materialSingleLineTextField4.TabIndex = 15;
            materialSingleLineTextField4.TabStop = false;
            materialSingleLineTextField4.UseSystemPasswordChar = false;
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
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(322, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(466, 330);
            dataGridView1.TabIndex = 19;
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
            // Frm_Estudantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 504);
            Controls.Add(panel2);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(materialSingleLineTextField4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(materialSingleLineTextField3);
            Controls.Add(label4);
            Controls.Add(materialSingleLineTextField2);
            Controls.Add(label3);
            Controls.Add(materialSingleLineTextField1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Frm_Estudantes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
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
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private Label label3;
        private Label label4;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private Label label5;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
        private ComboBox comboBox1;
        private Label label6;
        private Label label7;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField4;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private PictureBox pictureBox2;
        private Button button4;
        private Panel panel2;
    }
}