using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Controlador;

namespace PRUEBA_FINAL
{
    public partial class frmRegistrarProducto : Form
    {
        ControlProducto producto = new ControlProducto();
        public frmRegistrarProducto()
        {
            InitializeComponent();
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

                
                MemoryStream ms = new MemoryStream();
                pbxFoto.Image.Save(ms,ImageFormat.Png);
                byte[] ImgByte = ms.ToArray();


                producto.registroProducto(txtNombreProducto.Text, txtDescripcion.Text, txtUbicacion.Text, cbxTipo.SelectedIndex, (txtValor.Text), ImgByte);
                MessageBox.Show("Producto registrado correctamente");
                txtNombreProducto.Text = "";
                txtDescripcion.Text = "";
               // txtCategoria.Text = "";
                txtUbicacion.Text = "";
                txtValor.Text = "";
                pbxFoto.Image = null;
            }
            catch (Exception ex)
            {

                MessageBox.Show("No fue posible realizar la insercion de sus datos debido a \n" + ex);
            }


}

private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog subir = new OpenFileDialog();
            subir.Filter = "Imagenes|*.jpg; *.png;";
            subir.Title = "Seleccione una imagen";
            if (subir.ShowDialog() == DialogResult.OK)
            {
                pbxFoto.Image = Image.FromFile(subir.FileName);

            }
        }

      

        private void frmRegistrarProducto_Load(object sender, EventArgs e)
        {
            cbxTipo.DataSource = producto.mostrarTiposProductos();
            cbxTipo.DisplayMember = "descripcion";
            cbxTipo.ValueMember = "idtipoProducto";
        }
    }
}
