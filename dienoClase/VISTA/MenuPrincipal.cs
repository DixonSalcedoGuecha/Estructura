using PRUEBA_FINAL;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Vista.VISTA;

namespace InicioSesion.VISTA
{
    public partial class IdMenuPrincipal : Form
    {
        public IdMenuPrincipal()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void IdMenuPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void IdMenuPrincipal_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        private void btnSalida_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmProductos Productos = new frmProductos();
            Productos.Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmAjustes ajustes = new frmAjustes();
            ajustes.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmReservaProducto reserva = new frmReservaProducto();
            reserva.Show();
            this.Hide();
            
        }
    }
}
