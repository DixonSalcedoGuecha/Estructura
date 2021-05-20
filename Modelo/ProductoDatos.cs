using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ConnectionToSql;

namespace Modelo
{
   public class ProductoDatos : Conexion
    {
        public void registro(string Nombre, string Descripcion, string Ubicacion , int Tipo, Double Valor)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Producto(nombreProducto ,descripcion ,ubicacionProducto ,valorProducto ,tipoProducto )"+
                                          "VALUES('"+ Nombre + "',"+ "'" + Descripcion + "'," + "'," + Ubicacion + "'," + "" + Valor + "," + Tipo + ") ";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    
                }
            }
        }
    }
}
