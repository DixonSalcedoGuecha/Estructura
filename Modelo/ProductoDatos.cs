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
        
        SqlCommand command = new SqlCommand();

        //---------- Dixon Fabian Salcedo --------------
        //Metodo para realizar el registro de productos
        //----------------------------------------------
        public void registro(string Nombre, string Descripcion, string Ubicacion , int Tipo, Double Valor)
        {
            using var connection = GetConnection();
            connection.Open();
           
                command.Connection = connection;
                command.CommandText = "INSERT INTO Producto(nombreProducto ,descripcion ,ubicacionProducto ,valorProducto ,tipoProducto )" +
                                      "VALUES('" + Nombre + "'," + "'" + Descripcion + "'," + "'" + Ubicacion + "'," + "" + Valor + "," + Tipo + ") ";
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

            
            connection.Close();

        }

        //---------- Dixon Fabian Salcedo --------------
        //Metodo para realizar la consulta de productos
        //----------------------------------------------

        public DataTable listaProductos()
        {
            DataTable tabla = new DataTable();
            SqlDataReader leerDatos;
            
            using var ConexionBD  = GetConnection() ;
            ConexionBD.Open();
            command.Connection = ConexionBD;
            command.CommandText = "Select * from Producto";
            command.CommandType = CommandType.Text;
            leerDatos = command.ExecuteReader();
            tabla.Load(leerDatos);
            return tabla;
            ConexionBD.Close();

        }

        //---------- Dixon Fabian Salcedo --------------
        //Metodo para realizar la consulta de productos
        //--------------- 20-05-2021 -------------------
        public void editarProducto(string Buscar, string Nombre, string Descripcion, string Ubicacion, int Tipo, Double Valor, int Estado)
        {
            using var ConexionBD = GetConnection();
            ConexionBD.Open();
            command.Connection = ConexionBD;
            command.CommandText = "Update Producto set nombreProducto = '" + Nombre +"', Descripcion = '"+ Descripcion +
                                                    "', ubicacionProducto = '" + Ubicacion + "', tipoProducto = " + Tipo + ", valorProducto =" + Valor +
                                                    ", Estado = "+ Estado + " Where nombreProducto = '" +Buscar+"'";
            command.ExecuteNonQuery();
            ConexionBD.Close();

        }

        public List<string> buscarProductos(string Nombre)
        {

            SqlDataReader leerDatos;

            using var ConexionBD = GetConnection();
            ConexionBD.Open();
            command.Connection = ConexionBD;
            command.CommandText = "Select Top 1 idProducto, nombreProducto, Descripcion, ubicacionProducto, tipoProducto, valorProducto, Estado from Producto where nombreProducto = '" + Nombre + "'";
            command.CommandType = CommandType.Text;
            leerDatos = command.ExecuteReader();
            leerDatos.Read();

            List<string> guardarDatos = new List<string>();

            //while (leerDatos.Read())
            //{
            //    guardarDatos.Add(leerDatos.ToString());
            //}
            guardarDatos.Add(leerDatos[0].ToString());
            guardarDatos.Add(leerDatos[1].ToString());
            guardarDatos.Add(leerDatos[2].ToString());
            guardarDatos.Add(leerDatos[3].ToString());
            guardarDatos.Add(leerDatos[4].ToString());
            guardarDatos.Add(leerDatos[5].ToString());
            guardarDatos.Add(leerDatos[6].ToString());



            return guardarDatos;
            ConexionBD.Close();

        }

         

        }

       

    }

