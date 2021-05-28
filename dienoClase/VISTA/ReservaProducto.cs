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
    public partial class frmReservaProducto : Form
    {
        ControlProducto productos = new ControlProducto();
        
        public frmReservaProducto()
        {
            InitializeComponent();
        }

        private void ReservaProducto_Load(object sender, EventArgs e)
        {
            mostrarProductos();
        }

        private void mostrarProductos()
        {
            dtgvMostrarProducto.DataSource = productos.mostrarListaReservaProductos();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            mostrarDatos();
        }
        public void mostrarDatos()
        {
            
            if (dtgvMostrarProducto.SelectedRows.Count > 0)
            {

                txtNombre.Text = dtgvMostrarProducto.CurrentRow.Cells["nombreProducto"].Value.ToString();
                txtCantidad.Text = dtgvMostrarProducto.CurrentRow.Cells["Cantidad"].Value.ToString();
               

            }
            else
            {
                MessageBox.Show("Seleccione la fila a editar");
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            IdMenuPrincipal menu = new IdMenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void btnApartar_Click(object sender, EventArgs e)
        {
            int cantidad = 0;
            string id = "";
            int CantidadAnterior = 0, total = 0, valor = 0, ValorTotal = 0;
            
            if (txtCantidad.Text == "" || txtNombre.Text == "")
            {
                MessageBox.Show("Pro favor seleccione un producto valido y presione el Boton Mostrar");
            }
            else
            {
                productos.buscarProducto(txtNombre.Text);
                id = productos.buscarProducto(txtNombre.Text)[0];
                cantidad = Convert.ToInt32(txtCantidad.Text);
                CantidadAnterior = Convert.ToInt32(productos.buscarProducto(txtNombre.Text)[8]);
                valor = Convert.ToInt32(productos.buscarProducto(txtNombre.Text)[5]);
                // Operaciones
                
                total = CantidadAnterior - cantidad;
                ValorTotal = cantidad * valor;

                if (total< 0)
                {
                    MessageBox.Show("La cantidad ingresada es mayor a la cantidad disponible");
                }
                else
                {
                    lblValorTotal.Text = "$ " + ValorTotal.ToString();
                    try
                    {
                        productos.editarCantidadProducto(total.ToString(), id);
                        mostrarProductos();
                        MessageBox.Show("Proceso realizado correctamente");
                        //limpiar();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Lo sentimos no es psible realizar su reserva por favor revice los datos ingresados o comuniquese con el administrador");
                    }
                   

                }
            }
        }

        private void limpiar()
        {
            txtCantidad.Text = "";
            txtNombre.Text = "";
        }
    }
}
