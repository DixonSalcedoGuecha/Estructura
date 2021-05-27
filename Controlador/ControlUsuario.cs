using System;
using System.Data;
using Modelo;

namespace Controlador
{
     
    public class ControlUsuario
    {
        UserDatos userDatos = new UserDatos();
        public bool loginUser (string user, string pass)
        {
            return userDatos.login(user, pass);
        }


        public DataTable mostrarUsuarios()
        {
        DataTable tabla = new DataTable();
        tabla = userDatos.listaUsuarios();
        return tabla;
        }
        public void registroUsuario(string Nombre, string Apellidos, string direccion, string telefono, string email, string documento)
        
        {
            userDatos.registroUsuario(Nombre, Apellidos, direccion, Convert.ToInt64(telefono), email,documento);
        }

        public void editarUsuario(string Nombre, string Apellidos, string direccion, string telefono, string email, string id, string documento)

        {
            userDatos.editarUsuario(Nombre, Apellidos, direccion, Convert.ToInt64(telefono), email, Convert.ToInt32(id),documento);
        }

        public void eliminarUsuario(string id)
        {
            userDatos.eliminarUsuario(Convert.ToInt32(id));
        }
    }
}
