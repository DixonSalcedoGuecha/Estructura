using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Controlador;
using InicioSesion.VISTA;

namespace Vista.VISTA
{
    public partial class ListaUsuarios : Form
    {
        ControlUsuario usuario = new ControlUsuario();
        private string id = null;
        private bool Editar = false;
        public ListaUsuarios()
        {
            InitializeComponent();
        }

        private void ListaUsuarios_Load(object sender, EventArgs e)
        {
            mostrarUsuarios();
        }

        private void mostrarUsuarios()
        {
            dtgvMostrarUsuarios.DataSource = usuario.mostrarUsuarios();
        }

        private void btnRegitrar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    usuario.registroUsuario(txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text);
                    mostrarUsuarios();
                    limpiarDatos();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lo sentimos no fue posible realizar el regitro debido a: \n" + ex);
                }
            }
            else if (Editar==true)
            {
                try
                {
                    usuario.editarUsuario(txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text,id);
                    mostrarUsuarios();
                    limpiarDatos();
                    Editar = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lo sentimos no fue posible realizar la edicion de el regitro debido a: \n" + ex);
                }
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            IdMenuPrincipal menu = new IdMenuPrincipal();
            menu.Show();
            this.Hide();
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dtgvMostrarUsuarios.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNombre.Text = dtgvMostrarUsuarios.CurrentRow.Cells["nombres"].Value.ToString();
                txtApellido.Text = dtgvMostrarUsuarios.CurrentRow.Cells["apellidos"].Value.ToString();
                txtDireccion.Text = dtgvMostrarUsuarios.CurrentRow.Cells["direccion"].Value.ToString();
                txtTelefono.Text = dtgvMostrarUsuarios.CurrentRow.Cells["telefono"].Value.ToString();
                txtEmail.Text = dtgvMostrarUsuarios.CurrentRow.Cells["email"].Value.ToString();
                id = dtgvMostrarUsuarios.CurrentRow.Cells["id"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Seleccione la fila a editar");
            }
        }

        private void limpiarDatos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dtgvMostrarUsuarios.SelectedRows.Count > 0)
            {
                id = dtgvMostrarUsuarios.CurrentRow.Cells["id"].Value.ToString();
                usuario.eliminarUsuario(id);
                MessageBox.Show("Usuario Eliminado Correctamente");
                mostrarUsuarios();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }
    }
}
