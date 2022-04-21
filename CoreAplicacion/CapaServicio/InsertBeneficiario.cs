using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Text.Json;
using CoreAplicacion.JsonClases;
namespace CoreAplicacion.CapaServicio
{
    public class InsertBeneficiario
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        SqlConnection Connection = null;
        SqlConnection ConnectionBackup = null;
        SqlCommand cmd = null;
        SqlCommand cmdBackup = null;
        public string ConnectionStrings;
        public string ConnectionStringsBackup;
        //TODO: Usar transaction pq son dos tablas

        public bool Insert(int NoCuenta, int ID_TipoBeneficiario, string Nombre, int ID_Cliente)
        {
            Connection = new SqlConnection();
            ConnectionBackup = new SqlConnection();
            Controlador controlador = new Controlador();
            int response = 0;
            
            ConnectionStrings = controlador.ObtenerConexion(); //Obtengo conexion del core
            ConnectionStringsBackup = controlador.ObtenerConexionBackup(); //Obtengo conexion del backup
            BeneficiarioInsert beneficiario = new BeneficiarioInsert();
            beneficiario.NoCuenta = NoCuenta;
            beneficiario.ID_TipoBeneficiario = ID_TipoBeneficiario;
            beneficiario.nombre = Nombre;
            beneficiario.ID_Cliente = ID_Cliente;
            Connection.ConnectionString = ConnectionStrings;
            ConnectionBackup.ConnectionString = ConnectionStringsBackup;
            try
            {
                Connection.Open();
                //response = ExecuteCommand(ConnectionStrings, beneficiario);
                cmd = new SqlCommand();
                cmd.Connection = Connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ppInsertBeneficiario";
                cmd.Parameters.AddWithValue("@NoCuenta", beneficiario.NoCuenta);
                cmd.Parameters.AddWithValue("@ID_TipoBeneficiario", beneficiario.ID_TipoBeneficiario);
                cmd.Parameters.AddWithValue("@Nombre", beneficiario.nombre);
                cmd.Parameters.AddWithValue("@ID_Cliente", beneficiario.ID_Cliente);
                response = cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                log.Error(err);               
                return false;
            }
            finally
            {
                Connection.Close();
            }

            try
            {
                ConnectionBackup.Open();
                //ExecuteCommand(ConnectionStringsBackup, beneficiario);
                cmdBackup = new SqlCommand();
                cmdBackup.Connection = Connection;
                cmdBackup.CommandType = CommandType.StoredProcedure;
                cmdBackup.CommandText = "ppInsertBeneficiario";
                cmdBackup.Parameters.AddWithValue("@NoCuenta", beneficiario.NoCuenta);
                cmdBackup.Parameters.AddWithValue("@ID_TipoBeneficiario", beneficiario.ID_TipoBeneficiario);
                cmdBackup.Parameters.AddWithValue("@Nombre", beneficiario.nombre);
                cmdBackup.Parameters.AddWithValue("@ID_Cliente", beneficiario.ID_Cliente);
                cmdBackup.ExecuteNonQuery();

            }
            catch (Exception err)
            {
                log.Error(err);
            }
            finally
            {
                ConnectionBackup.Close();
            }
            if (response > 0)
                return true;
            else
                return false;

        }
        //todo: borrar esta funcion
        public int ExecuteCommand(string cn, BeneficiarioInsert beneficiario)
        {
            Connection = new SqlConnection();
            Connection.ConnectionString = cn;
            int response = 0;
            try
            {
                Connection.Open();
                cmd = new SqlCommand();
                cmd.Connection = Connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ppInsertBeneficiario";                
                cmd.Parameters.AddWithValue("@NoCuenta", beneficiario.NoCuenta);
                cmd.Parameters.AddWithValue("@ID_TipoBeneficiario", beneficiario.ID_TipoBeneficiario);
                cmd.Parameters.AddWithValue("@Nombre", beneficiario.nombre);
                cmd.Parameters.AddWithValue("@ID_Cliente", beneficiario.ID_Cliente);
                response = cmd.ExecuteNonQuery();
                return response;
            }
            catch (Exception err)
            {
                log.Error(err.Message);
                return response;
            }
            finally
            {
                Connection.Close();

            }
        }

    }
}