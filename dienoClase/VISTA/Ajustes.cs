using InicioSesion.VISTA;
using Registro_Usuario;
using System;
using System.Windows.Forms;

namespace PRUEBA_FINAL
{
    public partial class frmAjustes : Form
    {
        public frmAjustes()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void frmAjustes_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDirectorio directorio = new frmDirectorio();
            directorio.Show();
            this.Hide();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            IdMenuPrincipal menuPrincipal = new IdMenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }
    }
}
