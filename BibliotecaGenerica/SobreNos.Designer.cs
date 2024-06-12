namespace BibliotecaGenerica
{
	partial class SobreNos
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
			label2 = new Label();
			label1 = new Label();
			panel2 = new Panel();
			label3 = new Label();
			panel3 = new Panel();
			pictureBox1 = new PictureBox();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.Peru;
			panel1.Controls.Add(panel2);
			panel1.Controls.Add(label2);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(800, 81);
			panel1.TabIndex = 0;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Century Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
			label2.ForeColor = SystemColors.ButtonHighlight;
			label2.Location = new Point(307, 19);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(196, 44);
			label2.TabIndex = 6;
			label2.Text = "Sobre Nós";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Century Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.ActiveCaptionText;
			label1.Location = new Point(40, 145);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(244, 44);
			label1.TabIndex = 7;
			label1.Text = "Nos somos ...";
			// 
			// panel2
			// 
			panel2.BackColor = Color.Peru;
			panel2.Controls.Add(pictureBox1);
			panel2.Controls.Add(label3);
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point(0, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(800, 81);
			panel2.TabIndex = 7;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Century Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
			label3.ForeColor = SystemColors.ButtonHighlight;
			label3.Location = new Point(307, 19);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(196, 44);
			label3.TabIndex = 6;
			label3.Text = "Sobre Nós";
			// 
			// panel3
			// 
			panel3.BackColor = Color.Peru;
			panel3.Dock = DockStyle.Bottom;
			panel3.Location = new Point(0, 426);
			panel3.Name = "panel3";
			panel3.Size = new Size(800, 24);
			panel3.TabIndex = 8;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.icons8_excluir_120;
			pictureBox1.Location = new Point(745, 12);
			pictureBox1.Margin = new Padding(4, 3, 4, 3);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(42, 27);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// SobreNos
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(800, 450);
			Controls.Add(panel3);
			Controls.Add(label1);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "SobreNos";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "SobreNos";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Label label2;
		private Label label1;
		private Panel panel2;
		private Label label3;
		private Panel panel3;
		private PictureBox pictureBox1;
	}
}