﻿using ConnectionToSql;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Modelo
{
    public class UserDatos : Conexion
    {
        public bool login(String User, String Password)
        {

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
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
                }
            }

        }
    }
}
