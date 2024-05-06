namespace conversor_de_monedas
{
	public partial class monedas : Form
	{
		public monedas()
		{
			InitializeComponent();
		}
		// Inicializa la interfaz de usuario
		private void InitializeUI()
		{
			// Configurar valores predeterminados en los TextBox de resultados
			txtResultadoDolares.Text = "0";
			txtResultadoLibras.Text = "0";

			// Configurar eventos de texto solo para permitir números y coma decimal
			txtCantidad.KeyPress += TextBox_KeyPress;
			txtValorCambioDolares.KeyPress += TextBox_KeyPress;
			txtValorCambioLibras.KeyPress += TextBox_KeyPress;
		}

		// Evento de tecla presionada para permitir solo números y coma decimal
		private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
			{
				e.Handled = true;
			}
		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("¿Estás seguro de que quieres salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
				this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			// Restablecer valores predeterminados en los TextBox
			txtCantidad.Text = "0";
			txtValorCambioDolares.Text = "0";
			txtValorCambioLibras.Text = "0";
			txtResultadoDolares.Text = "0";
			txtResultadoLibras.Text = "0";
		}
		// Función para calcular la conversión
		private void CalcularConversion()
		{
			try
			{
				// Obtener valor de la cantidad a convertir
				decimal cantidad = decimal.Parse(txtCantidad.Text);

				// Definir los valores de cambio
				decimal valorCambioDolares = 1.08m; // De Euros a dólares
				decimal valorCambioLibras = 0.86m;  // De Euros a Libras esterlinas

				// Realizar conversiones
				decimal resultadoDolares = cantidad * valorCambioDolares;
				decimal resultadoLibras = cantidad * valorCambioLibras;

				// Mostrar resultados en los TextBox de resultados
				txtResultadoDolares.Text = resultadoDolares.ToString();
				txtResultadoLibras.Text = resultadoLibras.ToString();
			}
			catch (FormatException)
			{
				MessageBox.Show("Por favor, introduce valores válidos en todos los campos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void button3_Click(object sender, EventArgs e)
		{
			CalcularConversion();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{


		}
	}
}
	
    
