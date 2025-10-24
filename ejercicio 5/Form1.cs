namespace ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool EsPrimo(int n)
        {
            if (n <= 1)
            {
                return false;
            }

            if (n == 2)
            {
                return true;
            }

            if (n % 2 == 0)
            {
                return false;
            }

            var limite = Math.Sqrt(n);
            for (int i = 3; i <= limite; i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private void BtnVerificarPrimo_Click(object sender, EventArgs e)
        {
            string texto = MtbNumero.Text.Trim().Replace("_", "");

            if (!int.TryParse(texto, out int numero) || string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("Por favor, ingrese un número entero válido.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (EsPrimo(numero))
            {
                MessageBox.Show($"El número {numero} SÍ es primo.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"El número {numero} NO es primo.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    
}
