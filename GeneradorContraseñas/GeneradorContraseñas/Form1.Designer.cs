namespace GeneradorContraseñas
{
	partial class Form1
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
			lbTitulo = new Label();
			lbContrasena = new Label();
			txtContrasena = new TextBox();
			panel1 = new Panel();
			lbCantidadCaracteres = new Label();
			cbCaracteres = new ComboBox();
			chbNumeros = new CheckBox();
			chbCaracteres = new CheckBox();
			chbMayusculas = new CheckBox();
			btnGenerar = new Button();
			btnPapeles = new Button();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// lbTitulo
			// 
			lbTitulo.AutoSize = true;
			lbTitulo.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lbTitulo.Location = new Point(45, 24);
			lbTitulo.Name = "lbTitulo";
			lbTitulo.Size = new Size(311, 33);
			lbTitulo.TabIndex = 0;
			lbTitulo.Text = "Generador de Contraseñas";
			// 
			// lbContrasena
			// 
			lbContrasena.AutoSize = true;
			lbContrasena.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbContrasena.Location = new Point(45, 89);
			lbContrasena.Name = "lbContrasena";
			lbContrasena.Size = new Size(100, 21);
			lbContrasena.TabIndex = 1;
			lbContrasena.Text = "Contraseña:";
			// 
			// txtContrasena
			// 
			txtContrasena.Location = new Point(151, 87);
			txtContrasena.Name = "txtContrasena";
			txtContrasena.ReadOnly = true;
			txtContrasena.Size = new Size(205, 23);
			txtContrasena.TabIndex = 2;
			txtContrasena.TextAlign = HorizontalAlignment.Center;
			// 
			// panel1
			// 
			panel1.BackColor = Color.Lavender;
			panel1.Controls.Add(lbCantidadCaracteres);
			panel1.Controls.Add(cbCaracteres);
			panel1.Controls.Add(chbNumeros);
			panel1.Controls.Add(chbCaracteres);
			panel1.Controls.Add(chbMayusculas);
			panel1.Location = new Point(45, 190);
			panel1.Name = "panel1";
			panel1.Size = new Size(311, 130);
			panel1.TabIndex = 3;
			// 
			// lbCantidadCaracteres
			// 
			lbCantidadCaracteres.AutoSize = true;
			lbCantidadCaracteres.Location = new Point(20, 20);
			lbCantidadCaracteres.Name = "lbCantidadCaracteres";
			lbCantidadCaracteres.Size = new Size(130, 15);
			lbCantidadCaracteres.TabIndex = 4;
			lbCantidadCaracteres.Text = "Cantidad de caracteres:";
			// 
			// cbCaracteres
			// 
			cbCaracteres.DropDownStyle = ComboBoxStyle.DropDownList;
			cbCaracteres.FormattingEnabled = true;
			cbCaracteres.Location = new Point(153, 12);
			cbCaracteres.Name = "cbCaracteres";
			cbCaracteres.Size = new Size(63, 23);
			cbCaracteres.TabIndex = 3;
			// 
			// chbNumeros
			// 
			chbNumeros.AutoSize = true;
			chbNumeros.Location = new Point(20, 96);
			chbNumeros.Name = "chbNumeros";
			chbNumeros.Size = new Size(111, 19);
			chbNumeros.TabIndex = 2;
			chbNumeros.Text = "Incluir Numeros";
			chbNumeros.UseVisualStyleBackColor = true;
			// 
			// chbCaracteres
			// 
			chbCaracteres.AutoSize = true;
			chbCaracteres.Location = new Point(20, 71);
			chbCaracteres.Name = "chbCaracteres";
			chbCaracteres.Size = new Size(115, 19);
			chbCaracteres.TabIndex = 1;
			chbCaracteres.Text = "Incluir caracteres";
			chbCaracteres.UseVisualStyleBackColor = true;
			// 
			// chbMayusculas
			// 
			chbMayusculas.AutoSize = true;
			chbMayusculas.Location = new Point(20, 46);
			chbMayusculas.Name = "chbMayusculas";
			chbMayusculas.Size = new Size(124, 19);
			chbMayusculas.TabIndex = 0;
			chbMayusculas.Text = "Incluir mayusculas";
			chbMayusculas.UseVisualStyleBackColor = true;
			// 
			// btnGenerar
			// 
			btnGenerar.Location = new Point(45, 139);
			btnGenerar.Name = "btnGenerar";
			btnGenerar.Size = new Size(131, 23);
			btnGenerar.TabIndex = 4;
			btnGenerar.Text = "Generar contraseña";
			btnGenerar.UseVisualStyleBackColor = true;
			btnGenerar.Click += btnGenerar_Click;
			// 
			// btnPapeles
			// 
			btnPapeles.Location = new Point(281, 139);
			btnPapeles.Name = "btnPapeles";
			btnPapeles.Size = new Size(75, 23);
			btnPapeles.TabIndex = 5;
			btnPapeles.Text = "Copiar";
			btnPapeles.UseVisualStyleBackColor = true;
			btnPapeles.Click += btnPapeles_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(405, 343);
			Controls.Add(btnPapeles);
			Controls.Add(btnGenerar);
			Controls.Add(panel1);
			Controls.Add(txtContrasena);
			Controls.Add(lbContrasena);
			Controls.Add(lbTitulo);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "Form1";
			Text = "Generador de contraseñas";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lbTitulo;
		private Label lbContrasena;
		private TextBox txtContrasena;
		private Panel panel1;
		private Label lbCantidadCaracteres;
		private ComboBox cbCaracteres;
		private CheckBox chbNumeros;
		private CheckBox chbCaracteres;
		private CheckBox chbMayusculas;
		private Button btnGenerar;
		private Button btnPapeles;
	}
}
