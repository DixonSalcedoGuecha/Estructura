using InicioSesion.VISTA;
using System;
using System.Windows.Forms;

namespace VentaTienda.VISTA
{
    public partial class BarraDeCarga : Form
    {
        public BarraDeCarga()
        {
            InitializeComponent();
        }

        private void tmrBarraProgreso_Tick(object sender, EventArgs e)
        {
            this.brdProgresos.Increment(1);
            if (brdProgresos.Value >= brdProgresos.Maximum)
            {
                this.Hide();
                this.tmrBarraProgreso.Stop();
                IdMenuPrincipal frmMenu = new IdMenuPrincipal();
                frmMenu.Show();

            }

        }

        private void brdProgresos_Click(object sender, EventArgs e)
        {
            ProgressBar pBar = new ProgressBar();

        }

        private void BarraDeCarga_Load(object sender, EventArgs e)
        {
            this.tmrBarraProgreso.Start();
        }
    }
}
