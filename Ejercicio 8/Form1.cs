namespace Ejercicio_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnContar_Click(object sender, EventArgs e)
        {
            string oracionOriginal = TxtOracion.Text.Trim();

            if (string.IsNullOrEmpty(oracionOriginal))
            {
                LblResultado.Text = "0";
                MessageBox.Show("Por favor, ingrese una oración.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            char[] separadores = new char[] { ' ' };

            string[] palabras = oracionOriginal.Split(separadores, StringSplitOptions.RemoveEmptyEntries);

            int numeroPalabras = palabras.Length;

            LblResultado.Text = numeroPalabras.ToString();
        }
    }
}
