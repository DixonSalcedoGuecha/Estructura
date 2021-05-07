using InicioSesion.VISTA;
using PRUEBA_FINAL;
using System;
using System.Windows.Forms;
//using Vista;

namespace Registro_Usuario
{
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }

       
        private void SALIR_Click(object sender, EventArgs e)
        {

            frmProductos productos = new frmProductos();
            productos.Show();
            this.Hide();
        }
    }
}
