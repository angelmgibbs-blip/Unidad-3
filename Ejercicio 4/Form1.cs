namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            string original = TxtPalabra.Text.Trim();

            if (string.IsNullOrEmpty(original))
            {
                MessageBox.Show("Por favor, ingrese una palabra.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            char[] caracteres = original.ToCharArray();
            Array.Reverse(caracteres);
            string invertida = new string(caracteres);

            if (string.Equals(original, invertida, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show($"'{original}' SÍ es un palíndromo.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"'{original}' NO es un palíndromo.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    
}
