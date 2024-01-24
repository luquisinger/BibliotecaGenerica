namespace BibliotecaGenerica
{
    partial class Frm_Inicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            Porcentagem = new Label();
            Myprogress = new ProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(136, 9);
            label1.Name = "label1";
            label1.Size = new Size(478, 47);
            label1.TabIndex = 0;
            label1.Text = "Gerenciamento de Biblioteca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(491, 56);
            label2.Name = "label2";
            label2.Size = new Size(123, 32);
            label2.TabIndex = 1;
            label2.Text = "Versao 1.0";
            label2.Click += label2_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(522, 409);
            label3.Name = "label3";
            label3.Size = new Size(266, 32);
            label3.TabIndex = 3;
            label3.Text = "by Matheus Luchsinger";
            // 
            // Porcentagem
            // 
            Porcentagem.AutoSize = true;
            Porcentagem.Font = new Font("Yu Gothic UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Porcentagem.ForeColor = SystemColors.ButtonFace;
            Porcentagem.Location = new Point(367, 192);
            Porcentagem.Name = "Porcentagem";
            Porcentagem.Size = new Size(49, 47);
            Porcentagem.TabIndex = 4;
            Porcentagem.Text = "%";
            // 
            // Myprogress
            // 
            Myprogress.Location = new Point(-2, 383);
            Myprogress.Name = "Myprogress";
            Myprogress.Size = new Size(790, 23);
            Myprogress.TabIndex = 4;
            // 
            // Frm_Inicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(Porcentagem);
            Controls.Add(Myprogress);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Inicial";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Frm_Inicial_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
        private Label Porcentagem;
        private ProgressBar Myprogress;
    }
}
