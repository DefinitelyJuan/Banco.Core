using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CoreAplicacion.CapaServicio
{
    public class Transaccion
    {
        public string ConnectionStrings;
        SqlConnection Connection;
        SqlTransaction transaction;
        SqlCommand sqlCommand;
        public DataSet transaccion(int ID_TipoTransaccion, int DbCr, string Comentario, int NoCuenta, decimal Monto)
        {
            DataSet dataSet = null;
            Connection = new SqlConnection();
            Controlador controlador = new Controlador();
            ConnectionStrings = controlador.ObtenerConexion();
            Connection.ConnectionString = ConnectionStrings;
            Connection.Open();
            transaction = Connection.BeginTransaction();
            int completado = InsertarTransaccion(ID_TipoTransaccion, DbCr, Comentario, NoCuenta, Monto);
            dataSet = ActualizarNoCuenta(completado, NoCuenta, Monto, DbCr);
            transaction.Commit();
            Connection.Close();
            return dataSet;
        }
        public int UpdateNoCuenta(int NoCuenta, decimal Monto, int DbCr)
        {
            int respuesta = 0;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "ppUpdateNoCuenta";
            sqlCommand.Parameters.AddWithValue("@NoCuenta", NoCuenta);
            sqlCommand.Parameters.AddWithValue("@Monto", Monto);
            sqlCommand.Parameters.AddWithValue("@DbCr", DbCr);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Connection = Connection;
            sqlCommand.Transaction = transaction;
            try
            {
                respuesta = sqlCommand.ExecuteNonQuery();
            }
            catch{
                transaction.Rollback();
            }
            return respuesta;
        }
        public int InsertarTransaccion(int ID_TipoTransaccion, int DbCr, string Comentario, int NoCuenta, decimal Monto)
        {
            int respuesta = 0;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "ppInsertTransaccion";
            sqlCommand.Parameters.AddWithValue("@Monto", Monto);
            sqlCommand.Parameters.AddWithValue("@ID_TipoTransaccion", ID_TipoTransaccion);
            sqlCommand.Parameters.AddWithValue("@DbCr", DbCr);
            sqlCommand.Parameters.AddWithValue("@Comentario", Comentario);
            sqlCommand.Parameters.AddWithValue("@NoCuenta", NoCuenta);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Connection = Connection;
            sqlCommand.Transaction = transaction;
            try
            {
                respuesta = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                transaction.Rollback();
            }
            return respuesta;
        }
        public DataSet ConseguirUltimaActualizacion(int NoCuenta)
        {
            DataSet dataset = new DataSet();
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "ppGetLastTransaction";
            sqlCommand.Parameters.AddWithValue("@NoCuenta", NoCuenta);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Connection = Connection;
            sqlCommand.Transaction = transaction;
            var da = new SqlDataAdapter(sqlCommand);
            try
            {
                da.Fill(dataset);
            }
            catch
            {
                transaction.Rollback();
            }
           
            return dataset;
        }
        public DataSet ConseguirTBL(int NoCuenta, int ID_Transacciones)
        {
            DataSet dataset = new DataSet();
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "ppGetTbl";
            sqlCommand.Parameters.AddWithValue("@NoCuenta", NoCuenta);
            sqlCommand.Parameters.AddWithValue("@ID_Transacciones", ID_Transacciones);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Connection = Connection;
            sqlCommand.Transaction = transaction;
            var da = new SqlDataAdapter(sqlCommand);
            try
            {
                da.Fill(dataset);
            }
            catch
            {
                transaction.Rollback();
            }
            return dataset;
        }
        public DataSet ConseguirTBLNTP(int NoCuenta, int ID_Transacciones)
        {
            DataSet dataset = new DataSet();
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "ppGetTblNTP";
            sqlCommand.Parameters.AddWithValue("@NoCuenta", NoCuenta);
            sqlCommand.Parameters.AddWithValue("@ID_Transacciones", ID_Transacciones);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Connection = Connection;
            sqlCommand.Transaction = transaction;
            var da = new SqlDataAdapter(sqlCommand);
            try
            {
                da.Fill(dataset);
            }
            catch
            {
                transaction.Rollback();
            }
            return dataset;
        }
        public DataSet TransaccionATercero(int NoCuenta, int Entidad, int ID_TipoEntidad, int ID_TipoTransaccion, int DbCr, string Comentario, decimal Monto)
        {
            DataSet dataset = new DataSet();
            Connection = new SqlConnection();
            Controlador controlador = new Controlador();
            ConnectionStrings = controlador.ObtenerConexion();
            Connection.ConnectionString = ConnectionStrings;
            Connection.Open();
            transaction = Connection.BeginTransaction();
            int completado = InsertarTransaccion(ID_TipoTransaccion, DbCr, Comentario, NoCuenta, Monto);
            if(completado == 1)
            {
                if(DbCr == 2)
                    dataset = ActualizarNoCuentaNTP(completado, Entidad, ID_TipoEntidad, NoCuenta, 0, DbCr);
                else
                    dataset = ActualizarNoCuentaNTP(completado, Entidad, ID_TipoEntidad, NoCuenta, Monto, DbCr);
                completado = InsertarTransaccion(ID_TipoTransaccion, 1, Comentario, Entidad, Monto);
            }
            if(completado == 1 && dataset.Tables.Count == 3)
                ActualizarNoCuentaNTP(completado,NoCuenta, ID_TipoEntidad, Entidad, Monto, 1);
            transaction.Commit();
            Connection.Close();
            return dataset;
        }
        public DataSet ActualizarNoCuenta(int completado, int NoCuenta, decimal Monto,int DbCr)
        {
            DataSet dataset = new DataSet();
            if (completado == 1)
            {
                completado = UpdateNoCuenta(NoCuenta, Monto, DbCr);
                if (completado == 1)
                {
                    DataSet dataSet1 = ConseguirUltimaActualizacion(NoCuenta);
                    int ID_Transacciones = int.Parse(dataSet1.Tables[0].Rows[0][0].ToString());
                    dataset = ConseguirTBL(NoCuenta, ID_Transacciones);
                }
            }
            return dataset;
        }
        public DataSet ActualizarNoCuentaNTP(int completado, int Entidad, int ID_TipoEntidad, int NoCuenta, decimal Monto, int DbCr)
        {
            DataSet dataset = new DataSet();
            if (completado == 1)
            {
                completado = UpdateNoCuenta(NoCuenta, Monto, DbCr);
                if (completado == 1)
                {
                    DataSet dataSet1 = ConseguirUltimaActualizacion(NoCuenta);
                    int ID_Transacciones = int.Parse(dataSet1.Tables[0].Rows[0][0].ToString());
                    completado = InsertPago(NoCuenta, Entidad, ID_TipoEntidad, ID_Transacciones);
                    if(completado == 1)
                        dataset = ConseguirTBLNTP(NoCuenta, ID_Transacciones);
                }
            }
            return dataset;
        }
        public int InsertPago(int NoCuenta, int Entidad, int ID_TipoEntidad, int ID_Transacciones)
        {
            int respuesta  = 0;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "ppInsertPago";
            sqlCommand.Parameters.AddWithValue("@NoCuenta", NoCuenta);
            sqlCommand.Parameters.AddWithValue("@Entidad", Entidad);
            sqlCommand.Parameters.AddWithValue("@ID_TipoEntidad", ID_TipoEntidad);
            sqlCommand.Parameters.AddWithValue("@ID_Transacciones", ID_Transacciones);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Connection = Connection;
            sqlCommand.Transaction = transaction;
            try
            {
                respuesta = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                transaction.Rollback();
            }
            return respuesta;
        }
    }
}