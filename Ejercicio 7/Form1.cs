namespace Ejercicio_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGenerarPrimos_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TxtInicio.Text, out int inicio) || inicio < 1)
            {
                MessageBox.Show("Ingrese un n�mero de inicio v�lido (entero positivo).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(TxtFin.Text, out int fin) || fin < inicio)
            {
                MessageBox.Show("Ingrese un n�mero final v�lido. Debe ser mayor o igual al inicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LbPrimos.Items.Clear();

            for (int i = inicio; i <= fin; i++)
            {
                if (EsPrimo(i))
                {
                    LbPrimos.Items.Add(i);
                }
            }

            if (LbPrimos.Items.Count == 0)
            {
                MessageBox.Show("No se encontraron n�meros primos en ese rango.", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
       }
        private bool EsPrimo(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

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
    }
}
