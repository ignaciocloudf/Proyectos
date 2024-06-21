using System;

namespace GeneradorContraseñas
{
	public partial class Form1 : Form
	{
		static string minusculas = "abcdefghijklmnopqrstuvwxyz";
		static string mayusculas = minusculas.ToUpper();
		static string numeros = "1234567890";
		static string especiales = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
		public Form1()
		{
			InitializeComponent();
			llenarComboBox();
			chbCaracteres.Checked = true;
			chbMayusculas.Checked = true;
			chbNumeros.Checked = true;
			cbCaracteres.SelectedIndex = 0;

		}


		private void llenarComboBox()
		{
			var numero = 6;

			do
			{
				cbCaracteres.Items.Add(numero);
				numero++;
			} while (numero <= 20);
		}

		private void btnGenerar_Click(object sender, EventArgs e)
		{
			var valueCaracteres = chbCaracteres.Checked;
			var valueNumeros = chbNumeros.Checked;
			var valueMayusculas = chbMayusculas.Checked;
			var cantidadCaracteres = Convert.ToInt32(cbCaracteres.SelectedItem);

			var newPassword = generarPassword(cantidadCaracteres, valueCaracteres, valueNumeros, valueMayusculas, true);

			txtContrasena.Text = newPassword;
		}

		private string generarPassword(int cantidad, bool eespeciales, bool nnumeros, bool lmayusculas, bool lminusculas)
		{
			var random = new Random();
			var contador = 0;
			var password = "";

			do
			{
				var value = "";
				var opcion = random.Next(4);

				if (eespeciales == true && opcion == 0 && value == "")
					value += especiales[random.Next(32)];
				if (nnumeros == true && opcion == 1 && value == "")
					value += numeros[random.Next(10)];
				if (lmayusculas == true && opcion == 2 && value == "")
					value += mayusculas[random.Next(26)];
				if (lminusculas == true && opcion == 3 && value == "")
					value += minusculas[random.Next(26)];

				if (value != "")
				{
					contador++;
					password += value;
				}


			} while (contador < cantidad);

			return password;
		}

		private void btnPapeles_Click(object sender, EventArgs e)
		{
			var password = txtContrasena.Text;
			Clipboard.SetText(password);

			MessageBox.Show("Contraseña copiada al portapapeles.");
		}
	}
}
