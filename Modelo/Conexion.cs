using System;
using System.Data.SqlClient;

namespace ConnectionToSql
{
    
    public abstract class Conexion
    {
        private readonly string connectionstring;
        public Conexion() { 
        connectionstring = "Server= DESKTOP-MUAS3NV; Database= Billar; User Id = sa; Password= administrador;";
        }

          
       protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionstring);
        }
       
    }
}
