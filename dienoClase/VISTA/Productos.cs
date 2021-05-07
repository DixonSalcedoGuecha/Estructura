using InicioSesion.VISTA;
using Registro_Usuario;
using System;
using System.Windows.Forms;

namespace PRUEBA_FINAL
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmEditarProducto editarProducto = new frmEditarProducto();
            editarProducto.Show();
            this.Hide();
        }

           private void button1_Click(object sender, EventArgs e)
        {
            frmRegistrarProducto RegistrarProducto = new frmRegistrarProducto();
            RegistrarProducto.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IdMenuPrincipal menuPrincipal = new IdMenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmEditarProducto editarProducto = new frmEditarProducto();
            editarProducto.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmInventario Inventario = new frmInventario();
            Inventario.Show();
            this.Hide();
        }
    }
}
