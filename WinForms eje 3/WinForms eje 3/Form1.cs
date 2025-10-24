namespace WinForms_eje_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            lstTabla.Items.Clear();

            if (int.TryParse(txtNumero.Text, out int numero))
            {
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = numero * i;
                    string linea = $"{numero} x {i} = {resultado}";
                    lstTabla.Items.Add(linea);
                }
            }
            else
            {
                MessageBox.Show(
                    "¡Error! Por favor, ingrese solamente un número entero válido.",
                    "Error de Entrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                txtNumero.Focus();
            }
        }
    }
}
