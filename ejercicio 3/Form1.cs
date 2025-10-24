namespace ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(TxtEntrada.Text, out double valorEntrada))
            {
                MessageBox.Show("Ingrese un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CmbUnidadOrigen.SelectedItem == null || CmbUnidadDestino.SelectedItem == null)
            {
                MessageBox.Show("Seleccione las unidades de origen y destino.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string unidadOrigen = CmbUnidadOrigen.SelectedItem?.ToString() ?? "";
            string unidadDestino = CmbUnidadDestino.SelectedItem?.ToString() ?? "";

            double valorEnMetros = 0.0;
            double resultadoFinal = 0.0;
            switch (unidadOrigen)
            {
                case "Metros":
                    valorEnMetros = valorEntrada;
                    break;
                case "Centímetros":
                    valorEnMetros = valorEntrada / 100.0;
                    break;
                case "Pulgadas":
                    valorEnMetros = valorEntrada * 0.0254;
                    break;
            }
            switch (unidadDestino)
            {
                case "Metros":
                    resultadoFinal = valorEnMetros;
                    break;
                case "Centímetros":
                    resultadoFinal = valorEnMetros * 100.0;
                    break;
                case "Pulgadas":
                    resultadoFinal = valorEnMetros / 0.0254;
                    break;
            }
            LblResultado.Text = resultadoFinal.ToString("N4") + " " + unidadDestino;
        }
    }

    
}
