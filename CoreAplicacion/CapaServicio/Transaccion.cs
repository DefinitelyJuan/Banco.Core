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
        public string ConnectionStringBackup;
        SqlConnection Connection;
        SqlTransaction transaction;
        SqlTransaction transactionBackup;
        SqlCommand sqlCommand;
        SqlCommand sqlCommandBackup;
        SqlConnection ConnectionBackup;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        public DataSet transaccion(int ID_TipoTransaccion, int DbCr, string Comentario, int NoCuenta, decimal Monto)
        {
            DataSet dataSet = null;
            DataSet dataSetBackup = null;
            Connection = new SqlConnection();
            ConnectionBackup = new SqlConnection();
            Controlador controlador = new Controlador();
            ConnectionStrings = controlador.ObtenerConexion();
            ConnectionStringBackup = controlador.ObtenerConexionBackup();
            Connection.ConnectionString = ConnectionStrings;
            ConnectionBackup.ConnectionString = ConnectionStringBackup;
            int completado = 0;
            int completadoBackup2 = 0;
            bool coreUp = true;
            //Core
            try
            {
                Connection.Open();
                transaction = Connection.BeginTransaction();
                completado = InsertarTransaccion(ID_TipoTransaccion, DbCr, Comentario, NoCuenta, Monto);
                dataSet = ActualizarNoCuenta(completado, NoCuenta, Monto, DbCr);
                transaction.Commit();
            }
            catch (Exception err)
            {
                coreUp = false;
                log.Error(err.Message);
                return dataSet; //Se retornará null
            }
            finally
            {
                Connection.Close();
            }
            //Backup
            try
            {
                ConnectionBackup.Open();
                transactionBackup = ConnectionBackup.BeginTransaction();
                completadoBackup2 = InsertarTransaccionBackup(ID_TipoTransaccion, DbCr, Comentario, NoCuenta, Monto);
                dataSetBackup = ActualizarNoCuentaBackup(completadoBackup2, NoCuenta, Monto, DbCr);
                transactionBackup.Commit();
            }
            catch (Exception err)
            {
                log.Error(err.Message);
            }                      
           
            finally
            {
                ConnectionBackup.Close();
            }


            if (coreUp)
            {
                return dataSet;
            }
            else
            {
                return dataSetBackup;
            }
        }
        public int UpdateNoCuenta(int NoCuenta, decimal Monto, int DbCr)
        {
            int respuesta = 0;
            sqlCommand = new SqlCommand();
            sqlCommandBackup = new SqlCommand();
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

        public int UpdateNoCuentaBackup(int NoCuenta, decimal Monto, int DbCr)
        {
            int respuesta = 0;
            sqlCommandBackup = new SqlCommand();
            sqlCommandBackup.CommandText = "ppUpdateNoCuenta";
            sqlCommandBackup.Parameters.AddWithValue("@NoCuenta", NoCuenta);
            sqlCommandBackup.Parameters.AddWithValue("@Monto", Monto);
            sqlCommandBackup.Parameters.AddWithValue("@DbCr", DbCr);
            sqlCommandBackup.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommandBackup.Connection = ConnectionBackup;
            sqlCommandBackup.Transaction = transactionBackup;
            try
            {
                respuesta = sqlCommandBackup.ExecuteNonQuery();
            }
            catch
            {
                transactionBackup.Rollback();
            }
            return respuesta;
        }

        public int InsertarTransaccionBackup(int ID_TipoTransaccion, int DbCr, string Comentario, int NoCuenta, decimal Monto)
        {
            int respuesta = 0;
            sqlCommandBackup = new SqlCommand();
            sqlCommandBackup.CommandText = "ppInsertTransaccion";
            sqlCommandBackup.Parameters.AddWithValue("@Monto", Monto);
            sqlCommandBackup.Parameters.AddWithValue("@ID_TipoTransaccion", ID_TipoTransaccion);
            sqlCommandBackup.Parameters.AddWithValue("@DbCr", DbCr);
            sqlCommandBackup.Parameters.AddWithValue("@Comentario", Comentario);
            sqlCommandBackup.Parameters.AddWithValue("@NoCuenta", NoCuenta);
            sqlCommandBackup.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommandBackup.Connection = ConnectionBackup;
            sqlCommandBackup.Transaction = transactionBackup;
            try
            {
               respuesta = sqlCommandBackup.ExecuteNonQuery();
            }
            catch (Exception)
            {
                transactionBackup.Rollback();
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
        public DataSet ConseguirUltimaActualizacionBackup(int NoCuenta)
        {
            DataSet dataset = new DataSet();
            sqlCommandBackup = new SqlCommand();
            sqlCommandBackup.CommandText = "ppGetLastTransaction";
            sqlCommandBackup.Parameters.AddWithValue("@NoCuenta", NoCuenta);
            sqlCommandBackup.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommandBackup.Connection = ConnectionBackup;
            sqlCommandBackup.Transaction = transactionBackup;
            var da = new SqlDataAdapter(sqlCommandBackup);
            try
            {
                da.Fill(dataset);
            }
            catch
            {
                transactionBackup.Rollback();
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
        public DataSet ConseguirTBLBackup(int NoCuenta, int ID_Transacciones)
        {
            DataSet dataset = new DataSet();
            sqlCommandBackup = new SqlCommand();
            sqlCommandBackup.CommandText = "ppGetTbl";
            sqlCommandBackup.Parameters.AddWithValue("@NoCuenta", NoCuenta);
            sqlCommandBackup.Parameters.AddWithValue("@ID_Transacciones", ID_Transacciones);
            sqlCommandBackup.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommandBackup.Connection = ConnectionBackup;
            sqlCommandBackup.Transaction = transactionBackup;
            var da = new SqlDataAdapter(sqlCommandBackup);
            try
            {
                da.Fill(dataset);
            }
            catch
            {
                transactionBackup.Rollback();
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

        public DataSet ConseguirTBLNTPBackup(int NoCuenta, int ID_Transacciones)
        {
            DataSet dataset = new DataSet();
            sqlCommandBackup = new SqlCommand();
            sqlCommandBackup.CommandText = "ppGetTblNTP";
            sqlCommandBackup.Parameters.AddWithValue("@NoCuenta", NoCuenta);
            sqlCommandBackup.Parameters.AddWithValue("@ID_Transacciones", ID_Transacciones);
            sqlCommandBackup.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommandBackup.Connection = ConnectionBackup;
            sqlCommandBackup.Transaction = transactionBackup;
            var da = new SqlDataAdapter(sqlCommandBackup);
            try
            {
                da.Fill(dataset);
            }
            catch
            {
                transactionBackup.Rollback();
            }
            return dataset;
        }
        public DataSet TransaccionATercero(int NoCuenta, int Entidad, int ID_TipoEntidad, int ID_TipoTransaccion, int DbCr, string Comentario, decimal Monto)
        {
            DataSet dataset = new DataSet();
            DataSet datasetBackup = new DataSet();
            Connection = new SqlConnection();
            ConnectionBackup = new SqlConnection();
            Controlador controlador = new Controlador();
            ConnectionStrings = controlador.ObtenerConexion();
            ConnectionStringBackup = controlador.ObtenerConexionBackup();
            Connection.ConnectionString = ConnectionStrings;
            ConnectionBackup.ConnectionString = ConnectionStringBackup;

            bool coreUp = true;
            int completado = 0, completadoBackup = 0;
            try
            {
                Connection.Open();
                transaction = Connection.BeginTransaction();
                completado = InsertarTransaccion(ID_TipoTransaccion, DbCr, Comentario, NoCuenta, Monto);
            }
            catch (Exception err)
            {
                coreUp = false;
                log.Error(err.Message);
                DataSet noConn = null;
                return noConn;
            }

            try
            {
                ConnectionBackup.Open();
                transactionBackup = ConnectionBackup.BeginTransaction();
                completadoBackup = InsertarTransaccionBackup(ID_TipoTransaccion, DbCr, Comentario, NoCuenta, Monto);
            }
            catch(Exception Error)
            {
                log.Error(Error.Message);
            }
            
            
            if(completado == 1)
            {
                if(DbCr == 2)
                    dataset = ActualizarNoCuentaNTP(completado, Entidad, ID_TipoEntidad, NoCuenta, 0, DbCr);
                else
                    dataset = ActualizarNoCuentaNTP(completado, Entidad, ID_TipoEntidad, NoCuenta, Monto, DbCr);
                completado = InsertarTransaccion(ID_TipoTransaccion, 1, Comentario, Entidad, Monto);
            }
            if (completadoBackup == 1)
            {
                if (DbCr == 2)
                    datasetBackup = ActualizarNoCuentaNTPBackup(completadoBackup, Entidad, ID_TipoEntidad, NoCuenta, 0, DbCr);
                else
                    datasetBackup = ActualizarNoCuentaNTPBackup(completadoBackup, Entidad, ID_TipoEntidad, NoCuenta, Monto, DbCr);
                completadoBackup = InsertarTransaccionBackup(ID_TipoTransaccion, 1, Comentario, Entidad, Monto);
            }
            if(completado == 1 && dataset.Tables.Count == 3)
                ActualizarNoCuentaNTP(completado,NoCuenta, ID_TipoEntidad, Entidad, Monto, 1);
            if (completadoBackup == 1 && dataset.Tables.Count == 3)
                ActualizarNoCuentaNTPBackup(completadoBackup, NoCuenta, ID_TipoEntidad, Entidad, Monto, 1);
            try
            {
                transaction.Commit();
                transactionBackup.Commit();
            }
            catch (Exception errorr)
            {
                log.Error(errorr.Message);
            }
            finally
            {
                Connection.Close();
                ConnectionBackup.Close();
            }
            if (coreUp)
            {
                return dataset;
            }
            else
            {
                return datasetBackup;
            }            
        }
        public DataSet ActualizarNoCuenta(int completado, int NoCuenta, decimal Monto, int DbCr)
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

        public DataSet ActualizarNoCuentaBackup(int completado, int NoCuenta, decimal Monto, int DbCr)
        {
            DataSet dataset = new DataSet();
            if (completado == 1)
            {
                completado = UpdateNoCuentaBackup(NoCuenta, Monto, DbCr);
                if (completado == 1)
                {
                    DataSet dataSet1 = ConseguirUltimaActualizacionBackup(NoCuenta);
                    int ID_Transacciones = int.Parse(dataSet1.Tables[0].Rows[0][0].ToString());
                    dataset = ConseguirTBLBackup(NoCuenta, ID_Transacciones);
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
        public DataSet ActualizarNoCuentaNTPBackup(int completado, int Entidad, int ID_TipoEntidad, int NoCuenta, decimal Monto, int DbCr)
        {
            DataSet dataset = new DataSet();
            if (completado == 1)
            {
                completado = UpdateNoCuentaBackup(NoCuenta, Monto, DbCr);
                if (completado == 1)
                {
                    DataSet dataSet1 = ConseguirUltimaActualizacionBackup(NoCuenta);
                    int ID_Transacciones = int.Parse(dataSet1.Tables[0].Rows[0][0].ToString());
                    completado = InsertPagoBackup(NoCuenta, Entidad, ID_TipoEntidad, ID_Transacciones);
                    if (completado == 1)
                        dataset = ConseguirTBLNTPBackup(NoCuenta, ID_Transacciones);
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

        public int InsertPagoBackup(int NoCuenta, int Entidad, int ID_TipoEntidad, int ID_Transacciones)
        {
            int respuesta = 0;
            sqlCommandBackup = new SqlCommand();
            sqlCommandBackup.CommandText = "ppInsertPago";
            sqlCommandBackup.Parameters.AddWithValue("@NoCuenta", NoCuenta);
            sqlCommandBackup.Parameters.AddWithValue("@Entidad", Entidad);
            sqlCommandBackup.Parameters.AddWithValue("@ID_TipoEntidad", ID_TipoEntidad);
            sqlCommandBackup.Parameters.AddWithValue("@ID_Transacciones", ID_Transacciones);
            sqlCommandBackup.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommandBackup.Connection = ConnectionBackup;
            sqlCommandBackup.Transaction = transactionBackup;
            try
            {
                respuesta = sqlCommandBackup.ExecuteNonQuery();
            }
            catch (Exception)
            {
                transactionBackup.Rollback();
            }
            return respuesta;
        }
    }
}