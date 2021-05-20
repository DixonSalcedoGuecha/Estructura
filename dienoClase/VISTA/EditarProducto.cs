using System;
using System.Windows.Forms;
using Controlador;

namespace PRUEBA_FINAL
{
    public partial class frmEditarProducto : Form
    {
        ControlProducto controlProducto = new ControlProducto();
        public frmEditarProducto()
        {
            InitializeComponent();
        }

                private void button4_Click(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos();
            productos.Show();
            this.Hide();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                controlProducto.editarProducto(txtBuscar.Text, txtNombre.Text, txtDescripcion.Text, txtUbicacion.Text, txtTipo.Text, txtValor.Text, txtEstado.Text);
                MessageBox.Show("Los cambios fueron aplicados con exito");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Los cambios no puedieron ser aplicados correctamente debido a \n" + ex);
            }
            
        }

        private void ptbBuscar_Click(object sender, EventArgs e)
        {
            //"Select Top 1 nombreProducto, Descripcion, ubicacionProducto, tipoProducto, valorProducto, Estado from Producto where nombreProducto = '" + Nombre +"'";

            controlProducto.buscarProducto(txtBuscar.Text);
            txtId.Text = controlProducto.buscarProducto(txtBuscar.Text)[0];
            txtNombre.Text = controlProducto.buscarProducto(txtBuscar.Text)[1];
            txtDescripcion.Text = controlProducto.buscarProducto(txtBuscar.Text)[2];
            txtUbicacion.Text = controlProducto.buscarProducto(txtBuscar.Text)[3];
            txtTipo.Text = controlProducto.buscarProducto(txtBuscar.Text)[4];
            txtValor.Text = controlProducto.buscarProducto(txtBuscar.Text)[5];
            txtEstado.Text = controlProducto.buscarProducto(txtBuscar.Text)[6];


        }

        /*private void mostrarBuscados()
        {
            txtNombre.Text = controlProducto.buscarProducto();
        }*/
    }
}
