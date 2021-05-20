using System;
using System.Windows.Forms;
using Controlador;

namespace PRUEBA_FINAL
{
    public partial class frmRegistrarProducto : Form
    {
        public frmRegistrarProducto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos();
            productos.Show();
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ControlProducto producto = new ControlProducto();
            producto.registroProducto(txtNombreProducto.Text,txtDescripcion.Text,txtUbicacion.Text,Convert.ToInt32(txtCategoria.Text), Convert.ToInt64(txtValor.Text));
            MessageBox.Show("Producto registrado correctamente");
            txtNombreProducto.Text = "";
            txtDescripcion.Text = "";
            txtCategoria.Text = "";
            txtUbicacion.Text = "";
            txtValor.Text = "";
        }
    }
}
