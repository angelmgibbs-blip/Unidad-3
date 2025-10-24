namespace ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int segundosTotales;

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TxtMinutos.Text, out int minutos))
            {
                MessageBox.Show("Ingrese un valor válido para Minutos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(TxtSegundos.Text, out int segundos))
            {
                MessageBox.Show("Ingrese un valor válido para Segundos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            segundosTotales = (minutos * 60) + segundos;

            if (segundosTotales > 0)
            {
                LblTiempoRestante.Text = $"{minutos:D2}:{segundos:D2}";
                timerReloj.Start();
                BtnIniciar.Enabled = false;
            }
            else
            {
                MessageBox.Show("El tiempo configurado debe ser mayor a cero.", "Advertencia");
            }
     
        }

        private void BtnDetener_Click(object sender, EventArgs e)
        {
            timerReloj.Stop();
            BtnIniciar.Enabled = true;
        }

        private void timerReloj_Tick_1(object sender, EventArgs e)
        {
            segundosTotales--;

            if (segundosTotales >= 0)
            {
                int minutosRestantes = segundosTotales / 60;
                int segundosRestantes = segundosTotales % 60;

                LblTiempoRestante.Text = $"{minutosRestantes:D2}:{segundosRestantes:D2}";
            }

            if (segundosTotales < 0)
            {
                timerReloj.Stop();
                BtnIniciar.Enabled = true;

                MessageBox.Show("¡El tiempo se ha agotado!", "Temporizador Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LblTiempoRestante.Text = "00:00";
            }
        }
    }
    

}
