using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
namespace CoreAplicacion
{
    
    public class Controlador
    {
        public string ObtenerConexion()
        {
            
            string connection = ConfigurationManager.ConnectionStrings["cnCore"].ConnectionString;
            return connection;
        }

        public string ObtenerConexionBackup()
        {

            string connection = ConfigurationManager.ConnectionStrings["cnBackup"].ConnectionString;
            return connection;
        }
    }
}