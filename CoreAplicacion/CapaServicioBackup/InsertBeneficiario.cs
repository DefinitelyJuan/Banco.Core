using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using CoreAplicacion.JsonClases;
using System.Text.Json;

namespace CoreAplicacion.CapaServicioBackup
{
    public class InsertBeneficiarioBackup
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        SqlConnection Connection = null;
        SqlCommand cmd = null;
        SqlCommand cmdBackup = null;
        public string ConnectionStrings;
        public bool Insert(int NoCuenta, int ID_TipoBeneficiario, string Nombre, int ID_Cliente,bool backingup)
        {
            Connection = new SqlConnection();
            Controlador controlador = new Controlador();
            int response = 0;
            BeneficiarioInsert beneficiario = new BeneficiarioInsert();
            beneficiario.NoCuenta = NoCuenta;
            beneficiario.ID_TipoBeneficiario = ID_TipoBeneficiario;
            beneficiario.nombre = Nombre;
            beneficiario.ID_Cliente = ID_Cliente;
            if (backingup)
            {
                ConnectionStrings = controlador.ObtenerConexion(); //Obtengo conexion del core
            }
            else
            {
                ConnectionStrings = controlador.ObtenerConexionBackup(); //Obtengo conexion del minicore
            }
            Connection.ConnectionString = ConnectionStrings;
            try
            {
                Connection.Open();
                response = ExecuteCommand(ConnectionStrings,beneficiario);
                log.Info($"Insertado Beneficiario: {beneficiario.id_beneficiario}, {beneficiario.NoCuenta}");
                if(ConnectionStrings == controlador.ObtenerConexionBackup())
                {
                    int resp = InsertBeneficiarioEnBackups(ConnectionStrings, beneficiario);
                    log.Info($"Insertado backup del beneficiario: {beneficiario.id_beneficiario}, {beneficiario.NoCuenta}, filas afectadas: {resp}");
                }
                else
                {
                    log.Info($"No se inserto backup (backing up?)");
                }
            }
            catch(Exception err)
            {
                log.Error(err.Message);
            }
            finally
            {
                Connection.Close();
            }      
            
            if (response > 0)
                return true;
            else
                return false;
        }
        public int ExecuteCommand(string cn, BeneficiarioInsert beneficiario)
        {
            int response = 0;
            try
            {
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
        }
        public int InsertBeneficiarioEnBackups(string cn, BeneficiarioInsert beneficiario)
        {
            int response = 0;
            try
            {
                cmdBackup = new SqlCommand();
                cmdBackup.Connection = Connection;
                cmdBackup.CommandType = CommandType.StoredProcedure;
                cmdBackup.CommandText = "ppInsertBackup";
                cmdBackup.Parameters.AddWithValue("@jsontext", JsonSerializer.Serialize(beneficiario));
                cmdBackup.Parameters.AddWithValue("@estado", "Pendiente");
                cmdBackup.Parameters.AddWithValue("@tipo", 2);
                response = cmdBackup.ExecuteNonQuery();
                return response;
            }
            catch (Exception err)
            {
                log.Error(err.Message);
                return response;
            }
        }
    }
}