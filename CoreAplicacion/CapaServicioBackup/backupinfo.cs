using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace CoreAplicacion.CapaServicioBackup
{
    public class getbackupjson
    {
        public DataSet backupdata()
        {        
            Controlador controlador = new Controlador();
            string cn = controlador.ObtenerConexionBackup();
            DataSet backups = new DataSet();
            SqlConnection conn = new SqlConnection(cn);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "ppGetBackup";
            cmd.CommandType = CommandType.StoredProcedure;
            var adapter = new SqlDataAdapter(cmd);
            adapter.Fill(backups);
            conn.Close();
            return backups;
        }

    }
}