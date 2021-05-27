﻿using System;
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
        public void registroProducto(string Nombre, string Descripcion, string Ubicacion, int Tipo, string Valor, byte[] foto) 
        {
            producto.registro(Nombre,Descripcion,Ubicacion, (Tipo), Convert.ToInt64(Valor), foto);
        }

        //Controlador para el inventario de productos

        public DataTable mostrarProductos()
        {
            DataTable tabla = new DataTable();
            tabla = producto.listaProductos();
            return tabla;
        }

        public DataTable mostrarTiposProductos()
        {
            DataTable tabla = new DataTable();
            tabla = producto.listaTipos();
            return tabla;
        }

        //Controlador para la edicion de productos

        public void editarProducto(string Buscar,string Nombre, string Descripcion, string Ubicacion, int Tipo, string Valor, string Estado, byte[] Foto)
        {
            producto.editarProducto( Buscar,Nombre,  Descripcion,  Ubicacion,  (Tipo), Convert.ToInt64(Valor), (Estado), Foto);

        }

        public void eliminarProducto(string id)
        {
            producto.elimarProductos(Convert.ToInt32(id));
        }

        public List<string> buscarProducto(string Nombre)
        {
            return producto.buscarProductos(Nombre);
        }

        public byte[] buscarFoto(string Nombre)
        {
            return producto.buscarFoto(Nombre);
        }


        

    }
}
