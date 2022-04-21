using CoreAplicacion.JsonClases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.Json;
using System.Web;

namespace CoreAplicacion.CapaServicioBackup
{
    public class TransaccionBackup
    {
        public string ConnectionStrings;
        SqlConnection Connection;
        SqlTransaction transaction;
        SqlCommand sqlCommand;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public DataSet transaccion(int ID_TipoTransaccion, int DbCr, string Comentario, int NoCuenta, decimal Monto, bool backingup)
        {
            DataSet dataSet = null;
            Connection = new SqlConnection();
            Controlador controlador = new Controlador();
            if (backingup)
            {
                ConnectionStrings = controlador.ObtenerConexion();
            }
            else
            {
                ConnectionStrings = controlador.ObtenerConexionBackup();
            }
            Connection.ConnectionString = ConnectionStrings;
            Connection.Open();
            transaction = Connection.BeginTransaction();            
            int completado = InsertarTransaccion(ID_TipoTransaccion, DbCr, Comentario, NoCuenta, Monto);
            dataSet = ActualizarNoCuenta(completado, NoCuenta, Monto, DbCr);
            //TODO: InsertBackup tipo = 0  aqui con todo lo que se envio (osea, serializar objeto tipo transaccionmismapersona).(debajo)
            TransaccionMismaCuenta mismacuenta = new TransaccionMismaCuenta();
            mismacuenta.ID_TipoTransaccion = ID_TipoTransaccion;
            mismacuenta.DbCr = DbCr;
            mismacuenta.comentario = Comentario;
            mismacuenta.NoCuenta = NoCuenta;
            mismacuenta.Monto = Monto; //añadir if abajo con el connstring (Done)
            if(ConnectionStrings == controlador.ObtenerConexionBackup())
            {
                int insertado = InsertTransaccionMismaCuentaEnBackups(ConnectionStrings, mismacuenta);
            }
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
            catch(Exception err)
            {
                log.Error(err.Message);
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
            catch (Exception err)
            {
                log.Error(err.Message);
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
            catch(Exception err)
            {
                log.Error(err.Message);
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
            catch(Exception err)
            {
                log.Error(err.Message);
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
            catch(Exception err)
            {
                log.Error(err.Message);
                transaction.Rollback();
            }
            return dataset;
        }
        public DataSet TransaccionATercero(int NoCuenta, int Entidad, int ID_TipoEntidad, int ID_TipoTransaccion, int DbCr, string Comentario, decimal Monto, bool backingup)
        {
            DataSet dataset = new DataSet();
            Connection = new SqlConnection();
            Controlador controlador = new Controlador();
            if (backingup)
            {
                ConnectionStrings = controlador.ObtenerConexion();
            }
            else
            {
                ConnectionStrings = controlador.ObtenerConexionBackup();
            }            
            Connection.ConnectionString = ConnectionStrings;
            Connection.Open();
            transaction = Connection.BeginTransaction();
            int completado = InsertarTransaccion(ID_TipoTransaccion, DbCr, Comentario, NoCuenta, Monto);            
            if (completado == 1)
            {
                if(DbCr == 2)
                    dataset = ActualizarNoCuentaNTP(completado, Entidad, ID_TipoEntidad, NoCuenta, 0, DbCr);
                else
                    dataset = ActualizarNoCuentaNTP(completado, Entidad, ID_TipoEntidad, NoCuenta, Monto, DbCr);
                completado = InsertarTransaccion(ID_TipoTransaccion, 1, Comentario, Entidad, Monto);
            }
            if(completado == 1 && dataset.Tables.Count == 3)
                ActualizarNoCuentaNTP(completado,NoCuenta, ID_TipoEntidad, Entidad, Monto, 1);
            //TODO: InsertBackup tipo = 1 aqui con todo lo que se envio (osea, serializar objeto tipo transaccion 3ero). abajo (EXPERIMENTAL)
            TransaccionTercero tercero = new TransaccionTercero();
            tercero.NoCuenta = NoCuenta;
            tercero.Entidad = Entidad;
            tercero.ID_TipoEntidad = ID_TipoEntidad;
            tercero.ID_TipoTransaccion = ID_TipoTransaccion;
            tercero.DbCr = DbCr;
            tercero.Comentario = Comentario;
            tercero.Monto = Monto;
            if (ConnectionStrings == controlador.ObtenerConexionBackup())
            {
                InsertTransaccion3eroEnBackups(ConnectionStrings, tercero);
            }
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
            catch (Exception err)
            {
                log.Error(err.Message);
                transaction.Rollback();
            }
            return respuesta;
        }
        public int InsertTransaccionMismaCuentaEnBackups(string cn, TransaccionMismaCuenta mismacuenta)
        {
            int response = 0;
            try
            {
                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "ppInsertBackup";
                sqlCommand.Parameters.AddWithValue("@jsontext", JsonSerializer.Serialize(mismacuenta));
                sqlCommand.Parameters.AddWithValue("@estado", "Pendiente");
                sqlCommand.Parameters.AddWithValue("@tipo", 0);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = Connection;
                sqlCommand.Transaction = transaction;
                response = sqlCommand.ExecuteNonQuery();               
            }
            catch (Exception err)
            {
                log.Error(err.Message);
                transaction.Rollback();
            }
            return response;
        }
        public int InsertTransaccion3eroEnBackups(string cn, TransaccionTercero tercero)
        {
            int response = 0;
            try
            {
                sqlCommand = new SqlCommand();
                sqlCommand.Connection = Connection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "ppInsertBackup";
                sqlCommand.Parameters.AddWithValue("@jsontext", JsonSerializer.Serialize(tercero));
                sqlCommand.Parameters.AddWithValue("@estado", "Pendiente");
                sqlCommand.Parameters.AddWithValue("@tipo", 1);
                sqlCommand.Transaction = transaction;
                response = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                log.Error(err.Message);
                transaction.Rollback();
            }
            return response;
        }
    }
}