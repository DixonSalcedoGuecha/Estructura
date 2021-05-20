using System;
using System.Collections.Generic;
using System.Text;
using Modelo;

namespace Controlador
{
    public class ControlProducto
    {
        ProductoDatos producto = new ProductoDatos();
        public void registroProducto(string Nombre, string Descripcion, string Ubicacion, int Tipo, Double Valor) 
        {
            producto.registro(Nombre,Descripcion,Ubicacion,Tipo,Valor);
        }
    }
}
