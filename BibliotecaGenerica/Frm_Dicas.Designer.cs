namespace BibliotecaGenerica
{
	partial class Frm_Dicas
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
			panel4 = new Panel();
			panel5 = new Panel();
			pictureBox2 = new PictureBox();
			label1 = new Label();
			label4 = new Label();
			panel3 = new Panel();
			panel4.SuspendLayout();
			panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// panel4
			// 
			panel4.BackColor = Color.Peru;
			panel4.Controls.Add(panel5);
			panel4.Controls.Add(label4);
			panel4.Dock = DockStyle.Top;
			panel4.Location = new Point(0, 0);
			panel4.Name = "panel4";
			panel4.Size = new Size(800, 81);
			panel4.TabIndex = 10;
			// 
			// panel5
			// 
			panel5.BackColor = Color.Peru;
			panel5.Controls.Add(pictureBox2);
			panel5.Controls.Add(label1);
			panel5.Dock = DockStyle.Top;
			panel5.Location = new Point(0, 0);
			panel5.Name = "panel5";
			panel5.Size = new Size(800, 81);
			panel5.TabIndex = 7;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = Properties.Resources.icons8_excluir_120;
			pictureBox2.Location = new Point(745, 12);
			pictureBox2.Margin = new Padding(4, 3, 4, 3);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(42, 27);
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 1;
			pictureBox2.TabStop = false;
			pictureBox2.Click += pictureBox2_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Century Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.ButtonHighlight;
			label1.Location = new Point(307, 19);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(118, 44);
			label1.TabIndex = 6;
			label1.Text = "Dicas";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Century Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
			label4.ForeColor = SystemColors.ButtonHighlight;
			label4.Location = new Point(307, 19);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(196, 44);
			label4.TabIndex = 6;
			label4.Text = "Sobre Nós";
			// 
			// panel3
			// 
			panel3.BackColor = Color.Peru;
			panel3.Dock = DockStyle.Bottom;
			panel3.Location = new Point(0, 426);
			panel3.Name = "panel3";
			panel3.Size = new Size(800, 24);
			panel3.TabIndex = 11;
			// 
			// Frm_Dicas
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(panel3);
			Controls.Add(panel4);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Frm_Dicas";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Frm_Dicas";
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			panel5.ResumeLayout(false);
			panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel4;
		private Panel panel5;
		private PictureBox pictureBox2;
		private Label label1;
		private Label label4;
		private Panel panel3;
	}
}