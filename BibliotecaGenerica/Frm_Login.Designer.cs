﻿namespace BibliotecaGenerica
{
    partial class Frm_Login
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
            materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(materialRaisedButton1);
            panel1.Controls.Add(materialSingleLineTextField2);
            panel1.Controls.Add(materialSingleLineTextField1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(261, 329);
            panel1.TabIndex = 0;
            // 
            // materialRaisedButton1
            // 
            materialRaisedButton1.AutoSize = true;
            materialRaisedButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialRaisedButton1.Depth = 0;
            materialRaisedButton1.Icon = null;
            materialRaisedButton1.Location = new Point(95, 190);
            materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialRaisedButton1.Name = "materialRaisedButton1";
            materialRaisedButton1.Primary = true;
            materialRaisedButton1.Size = new Size(73, 36);
            materialRaisedButton1.TabIndex = 7;
            materialRaisedButton1.Text = "Entrar";
            materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // materialSingleLineTextField2
            // 
            materialSingleLineTextField2.Depth = 0;
            materialSingleLineTextField2.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            materialSingleLineTextField2.Hint = "";
            materialSingleLineTextField2.Location = new Point(46, 149);
            materialSingleLineTextField2.MaxLength = 32767;
            materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            materialSingleLineTextField2.PasswordChar = '\0';
            materialSingleLineTextField2.SelectedText = "";
            materialSingleLineTextField2.SelectionLength = 0;
            materialSingleLineTextField2.SelectionStart = 0;
            materialSingleLineTextField2.Size = new Size(165, 23);
            materialSingleLineTextField2.TabIndex = 6;
            materialSingleLineTextField2.TabStop = false;
            materialSingleLineTextField2.Text = "Senha";
            materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField1
            // 
            materialSingleLineTextField1.Depth = 0;
            materialSingleLineTextField1.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            materialSingleLineTextField1.Hint = "";
            materialSingleLineTextField1.Location = new Point(46, 108);
            materialSingleLineTextField1.MaxLength = 32767;
            materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            materialSingleLineTextField1.PasswordChar = '\0';
            materialSingleLineTextField1.SelectedText = "";
            materialSingleLineTextField1.SelectionLength = 0;
            materialSingleLineTextField1.SelectionStart = 0;
            materialSingleLineTextField1.Size = new Size(165, 23);
            materialSingleLineTextField1.TabIndex = 5;
            materialSingleLineTextField1.TabStop = false;
            materialSingleLineTextField1.Text = "Usuario";
            materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(111, 229);
            label2.Name = "label2";
            label2.Size = new Size(36, 12);
            label2.TabIndex = 4;
            label2.Text = "Limpar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(78, 46);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Schoolbook", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(295, 96);
            label3.Name = "label3";
            label3.Size = new Size(267, 25);
            label3.TabIndex = 1;
            label3.Text = "CAMPUS  DO CENTRO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Schoolbook", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(338, 121);
            label4.Name = "label4";
            label4.Size = new Size(178, 19);
            label4.TabIndex = 2;
            label4.Text = "BIBLIOTECA GERAL";
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gran_coleccion_libros_antiguos_estantes_madera_generados_ia;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(598, 329);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
    }
}