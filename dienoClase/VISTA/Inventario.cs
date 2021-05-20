using InicioSesion.VISTA;
using PRUEBA_FINAL;
using System;
using System.Windows.Forms;
using Controlador;

namespace Registro_Usuario
{
    public partial class frmInventario : Form
    {
        ControlProducto ControlProducto = new ControlProducto();
        public frmInventario()
        {
            InitializeComponent();
            MostrarProductos();
        }

       
        private void SALIR_Click(object sender, EventArgs e)
        {

            frmProductos productos = new frmProductos();
            productos.Show();
            this.Hide();
        }
        private void MostrarProductos()
        {
            dgwInventario.DataSource = ControlProducto.mostrarProductos();
             
        }
        private void dgwInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
