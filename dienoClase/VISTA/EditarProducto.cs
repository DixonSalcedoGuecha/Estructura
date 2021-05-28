using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
            autocompletar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos();
            productos.Show();
            this.Hide();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            MemoryStream ms = new MemoryStream();
            pbxFoto.Image.Save(ms, ImageFormat.Png);
            byte[] ImgByte = ms.ToArray();


            try
            {
                controlProducto.editarProducto(txtBuscar.Text, txtNombre.Text, txtDescripcion.Text, txtUbicacion.Text, cbxTipo.SelectedIndex, txtValor.Text,cbxEstado.SelectedItem.ToString() , ImgByte);
                controlProducto.editarCantidadProducto(txtCantidad.Text,txtId.Text);
                MessageBox.Show("Los cambios fueron aplicados con exito");
                limpiarDatos();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Los cambios no puedieron ser aplicados correctamente debido a \n" + ex);
            }

        }

        private void ptbBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                controlProducto.buscarProducto(txtBuscar.Text);
                txtId.Text = controlProducto.buscarProducto(txtBuscar.Text)[0];
                txtNombre.Text = controlProducto.buscarProducto(txtBuscar.Text)[1];
                txtDescripcion.Text = controlProducto.buscarProducto(txtBuscar.Text)[2];
                txtUbicacion.Text = controlProducto.buscarProducto(txtBuscar.Text)[3];
               // txtTipo.Text = controlProducto.buscarProducto(txtBuscar.Text)[4];
                txtValor.Text = controlProducto.buscarProducto(txtBuscar.Text)[5];
                txtCantidad.Text = controlProducto.buscarProducto(txtBuscar.Text)[8];
                //txtEstado.Text = controlProducto.buscarProducto(txtBuscar.Text)[6];
               // cbxTipo.DataSource = controlProducto.buscarProducto(txtBuscar.Text);
               // cbxTipo.DisplayMember = controlProducto.buscarProducto(txtBuscar.Text)[6];
              
                MemoryStream ms = new MemoryStream(controlProducto.buscarFoto(txtBuscar.Text));
                Bitmap bm = new Bitmap(ms);
                pbxFoto.Image = bm;

               

            }
            catch (Exception)
            {
                MessageBox.Show("No se encontraron resultados con el nombre ingresado");
            }
            

        }

        
        private void autocompletar()
        {
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();

         
            for (int i = 0; i < controlProducto.mostrarProductos().Rows.Count; i++)
            {
                lista.Add(controlProducto.mostrarProductos().Rows[i]["nombreProducto"].ToString());
            }

            txtBuscar.AutoCompleteCustomSource = lista;    
        }

        private void limpiarDatos()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtUbicacion.Text = "";
            txtValor.Text = "";
            txtCantidad.Text = "";
            txtBuscar.Text = "";
            pbxFoto.Image = null;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                controlProducto.eliminarCantidadProducto(txtId.Text);
                controlProducto.eliminarProducto(txtId.Text);
                MessageBox.Show("Datos eliminados correctamente");
                limpiarDatos();
            }
            catch (Exception )
            {

                MessageBox.Show("Por favor escoja los datos a eliminar");
            }
            

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog subir = new OpenFileDialog();
            subir.Filter = "Imagenes|*.jpg; *.png;*.jpeg;";
            subir.Title = "Seleccione una imagen";
            if (subir.ShowDialog() == DialogResult.OK)
            {
                pbxFoto.Image = Image.FromFile(subir.FileName);

            }
        }

        private void frmEditarProducto_Load(object sender, EventArgs e)
        {
            cbxEstado.Items.Add("Activo");
            cbxEstado.Items.Add("Agotado");

            cbxTipo.DataSource = controlProducto.mostrarTiposProductos();
            cbxTipo.DisplayMember = "descripcion";
            cbxTipo.ValueMember = "idtipoProducto";
        }
    }
}
