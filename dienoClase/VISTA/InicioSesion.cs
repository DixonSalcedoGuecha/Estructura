using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using VentaTienda.VISTA;
using Controlador;

namespace dienoClase
{

    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void InicioSesion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.LightGray;
                txtContrasena.UseSystemPasswordChar = true;
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "CONTRASEÑA";
                txtContrasena.ForeColor = Color.DimGray;
                txtContrasena.UseSystemPasswordChar = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO" || txtContrasena.Text == "CONTRASEÑA")
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Datos incorrectos revice la información ingresada";

            }
            else 
            {
                lblErrorMessage.Visible = false;
                ControlUsuario userControl = new ControlUsuario();
                var Validar = userControl.loginUser((int)Convert.ToInt64(txtUsuario.Text),txtContrasena.Text);
                if (Validar)
                {
                    this.Hide();

                    BarraDeCarga frmBarra = new BarraDeCarga();
                    frmBarra.Show();
                }
                else
                {
                    lblErrorMessage.Visible = true;
                    lblErrorMessage.Text = "El Usuario o la Contraseña ingresada son incorrectas";
                }
            }          
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            } 
        }
    }
}
