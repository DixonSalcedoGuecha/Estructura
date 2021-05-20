using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Modelo;

namespace Controlador
{
    public class ControlProducto
    {
        ProductoDatos producto = new ProductoDatos();

        //Controlador para el registro de productos
        public void registroProducto(string Nombre, string Descripcion, string Ubicacion, string Tipo, string Valor) 
        {
            producto.registro(Nombre,Descripcion,Ubicacion, Convert.ToInt32(Tipo), Convert.ToInt64(Valor));
        }

        //Controlador para el inventario de productos

        public DataTable mostrarProductos()
        {
            DataTable tabla = new DataTable();
            tabla = producto.listaProductos();
            return tabla;
        }

        //Controlador para la edicion de productos

        public void editarProducto(string Buscar,string Nombre, string Descripcion, string Ubicacion, string Tipo, string Valor, string Estado)
        {
            producto.editarProducto( Buscar,Nombre,  Descripcion,  Ubicacion,  Convert.ToInt32(Tipo), Convert.ToInt64(Valor), Convert.ToInt32(Estado));

        }

        public List<string> buscarProducto(string Nombre)
        {
            return producto.buscarProductos(Nombre);
        }
        

    }
}
