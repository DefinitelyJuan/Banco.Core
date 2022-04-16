using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace CoreAplicacion.CapaServicio
{
    public class Autenticacion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public string ConnectionStrings;
        public SqlConnection Connection;
        SqlCommand sqlCommand;
        public DataSet Autenticarse(string Usuario, string Contraseña, int Pin)
        {
            Connection = new SqlConnection();
            Controlador controlador = new Controlador();
            try
            { 
                ConnectionStrings = controlador.ObtenerConexion();
                Connection.ConnectionString = ConnectionStrings;
                Connection.Open();
                int ID_Cliente = 0;
                SqlDataReader reader = Autenticar(Usuario, Contraseña, Pin);


                if (reader.HasRows)
                {
                    reader.Read();
                    ID_Cliente = int.Parse(reader["ID_Cliente"].ToString());
                }
                reader.Close();
                DataSet Auth = TodoslosDatosCliente(ID_Cliente);
                Connection.Close();
                return Auth;
            }
            catch (Exception err)
            {
                log.Error(err.Message);
                try
                {
                    ConnectionStrings = controlador.ObtenerConexionBackup();
                    Connection.ConnectionString = ConnectionStrings;
                    Connection.Open();
                    int ID_Cliente = 0;
                    SqlDataReader reader = Autenticar(Usuario, Contraseña, Pin);


                    if (reader.HasRows)
                    {
                        reader.Read();
                        ID_Cliente = int.Parse(reader["ID_Cliente"].ToString());
                    }
                    reader.Close();
                    DataSet Auth = TodoslosDatosCliente(ID_Cliente);
                    Connection.Close();
                    return Auth;
                }
                catch (Exception error)
                {
                    log.Error(error.Message);
                    DataSet auth = new DataSet();
                    return auth;
                }
            }
            //ConnectionStrings = controlador.ObtenerConexion();
            //Connection.ConnectionString = ConnectionStrings;
            //Connection.Open();
            //int ID_Cliente = 0;
            //SqlDataReader reader = Autenticar(Usuario, Contraseña, Pin);
            

            //if (reader.HasRows)
            //{
            //    reader.Read();
            //    ID_Cliente = int.Parse(reader["ID_Cliente"].ToString());
            //}
            //reader.Close();
            //DataSet Auth = TodoslosDatosCliente(ID_Cliente);
            //Connection.Close();
            //return Auth;
        }
        public DataSet TodoslosDatosCliente(int ID_Cliente)
        {
            DataSet Auth = new DataSet();
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "ppGetAll";
            sqlCommand.Parameters.AddWithValue("@ID_Cliente", ID_Cliente);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Connection = Connection;
            var da = new SqlDataAdapter(sqlCommand);
            da.Fill(Auth);
            return Auth;
        }
        public SqlDataReader Autenticar(string Usuario, string Contraseña, int Pin)
        {
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "ppGetAutenticarse";
            sqlCommand.Parameters.AddWithValue("@Usuario", Usuario);
            sqlCommand.Parameters.AddWithValue("@Contra", Contraseña) ;
            sqlCommand.Parameters.AddWithValue("@Pin", Pin);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Connection = Connection;
            SqlDataReader datareader = sqlCommand.ExecuteReader();
            return datareader;
        }
    }
}