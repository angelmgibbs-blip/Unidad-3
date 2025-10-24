namespace Ejercicio_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVerificarPerfecto_Click(object sender, EventArgs e)
        {
            string texto = MtbNumero.Text.Trim().Replace("_", "");

            if (!int.TryParse(texto, out int numero) || string.IsNullOrEmpty(texto) || numero <= 0)
            {
                MessageBox.Show("Por favor, ingrese un número entero positivo válido.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (EsPerfecto(numero))
            {
                MessageBox.Show($"El número {numero} SÍ es un número perfecto.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"El número {numero} NO es un número perfecto.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool EsPerfecto(int n)
        {
            if (n <= 1)
            {
                return false;
            }

            long sumaDivisores = 0;

            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sumaDivisores += i;
                }
            }

            return sumaDivisores == n;
        }
    }
    
}
