using System;
using System.Configuration;

namespace Data
{
    public class Connection
    {
        public static string conexion = ConfigurationManager.ConnectionStrings["cadena"].ToString();

       
    }
}
