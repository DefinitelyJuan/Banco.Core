using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace CoreAplicacion.CapaServicioBackup
{

    public class TruncateBackup
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        SqlConnection Connection = null;
        SqlCommand cmd = null;
        public string ConnectionStrings;
        public bool Truncate()
        {
            Controlador controlador = new Controlador();
            bool done = false;
            Connection.ConnectionString = controlador.ObtenerConexionBackup();
            try
            {
                Connection.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "ppTruncateBackup";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = Connection;
                int Response = cmd.ExecuteNonQuery();
                if (Response > 0)
                {
                    done = true;
                }

            }
            catch (Exception err)
            {
                log.Info(err.Message);
            }
            finally
            {
                Connection.Close();
            }
            return done;
        }

    }

}