using System;
using Modelo;

namespace Controlador
{
    public class ControlUsuario
    {
        UserDatos userDatos = new UserDatos();
        public bool loginUser (int user, string pass)
        {
            return userDatos.login(user, pass);
        }
    }
}
