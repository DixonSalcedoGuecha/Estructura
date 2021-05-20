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
            try
            {
                ControlProducto producto = new ControlProducto();
                producto.registroProducto(txtNombreProducto.Text, txtDescripcion.Text, txtUbicacion.Text, (txtCategoria.Text), (txtValor.Text));
                MessageBox.Show("Producto registrado correctamente");
                txtNombreProducto.Text = "";
                txtDescripcion.Text = "";
                txtCategoria.Text = "";
                txtUbicacion.Text = "";
                txtValor.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show("No fue posible realizar la insercion de sus datos debido a \n" + ex);
            }
                       
            
        }
    }
}
