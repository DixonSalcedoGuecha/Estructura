using ConnectionToSql;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Modelo
{
    public class UserDatos : Conexion
    {
        SqlCommand command = new SqlCommand();
        public bool login(String User, String Password)
        {
            

            using (var connection = GetConnection())
            {
                connection.Open();
                
                command.Connection = connection;
                command.CommandText = "select * from Usuario where users = " + User + " and password = '" + Password + "'";
                command.CommandType = CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                connection.Close();
            }

        }

        public DataTable listaUsuarios()
        {
            DataTable tabla = new DataTable();
            SqlDataReader leerDatos;

            using var ConexionBD = GetConnection();
            ConexionBD.Open();
            command.Connection = ConexionBD;
            command.CommandText = "select idAdministrador as id,nombres,apellidos,direccion,telefono,email from Usuario";
            command.CommandType = CommandType.Text;
            leerDatos = command.ExecuteReader();
            tabla.Load(leerDatos);
            return tabla;
            ConexionBD.Close();

        }

        public void registroUsuario(string Nombre, string Apellidos, string direccion, double telefono, string email)
        {
            using var connection = GetConnection();
            connection.Open();

            command.Connection = connection;
            command.CommandText = "INSERT INTO Usuario(nombres,apellidos,direccion,telefono,email)" +
                                  "VALUES('" + Nombre + "'," + "'" + Apellidos + "'," + "'" + direccion + "'," + "" + telefono + ",'" + email + "') ";
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();


            connection.Close();

        }

        public void editarUsuario(string Nombre, string Apellidos, string direccion, double telefono, string email, int id)
        {
            using var connection = GetConnection();
            connection.Open();

            command.Connection = connection;
            command.CommandText = "UPDATE Usuario set nombres = '" + Nombre + "',apellidos = " + "'" + Apellidos + "'" + ",direccion = '" + direccion + "' ,telefono = "+ telefono + ", email ='" + email + "' Where idAdministrador = " + id +"";
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();


            connection.Close();

        }

        public void eliminarUsuario(int id)
        {
            using var connection = GetConnection();
            connection.Open();

            command.Connection = connection;
            command.CommandText = "DELETE FROM Usuario Where idAdministrador = " + id + "";
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
