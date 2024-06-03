namespace BibliotecaGenerica
{
	partial class TestaConexao
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
			Btn_Conectar = new Button();
			SuspendLayout();
			// 
			// Btn_Conectar
			// 
			Btn_Conectar.Location = new Point(400, 215);
			Btn_Conectar.Name = "Btn_Conectar";
			Btn_Conectar.Size = new Size(75, 23);
			Btn_Conectar.TabIndex = 0;
			Btn_Conectar.Text = "Conectar";
			Btn_Conectar.UseVisualStyleBackColor = true;
			Btn_Conectar.Click += this.Btn_Conectar_Click;
			// 
			// TestaConexao
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(Btn_Conectar);
			Name = "TestaConexao";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private Button Btn_Conectar;
	}
}