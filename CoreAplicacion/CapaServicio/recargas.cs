using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CoreAplicacion.CapaServicio
{
    public class recargas
    {
        public string ConnectionStrings;
        SqlConnection Connection;
        SqlCommand sqlCommand;
        public DataSet TodasCuentasDiferentes(int ID_Cliente)
        {
            DataSet dataSet = new DataSet();
            Connection = new SqlConnection();
            Controlador controlador = new Controlador();
            ConnectionStrings = controlador.ObtenerConexion();
            Connection.ConnectionString = ConnectionStrings;
            Connection.Open();
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "ppGetAllDiferentNoCuenta";
            sqlCommand.Parameters.AddWithValue("@ID_Cliente", ID_Cliente);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Connection = Connection;
            var da = new SqlDataAdapter(sqlCommand);
            da.Fill(dataSet);
            Connection.Close();
            return dataSet;
        }
    }
}