﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace CoreAplicacion.CapaServicioBackup
{
    public class InsertBeneficiarioBackup
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        SqlConnection Connection = null;
        SqlCommand cmd = null;
        public string ConnectionStrings;
        public bool Insert(int ID_Beneficiario, int NoCuenta, int ID_TipoBeneficiario, string Nombre, int ID_Cliente,bool backingup)
        {
            Connection = new SqlConnection();
            Controlador controlador = new Controlador();
            int response = 0;
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
                cmd = new SqlCommand();
                cmd.Connection = Connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ppInsertBeneficiario";
                response = cmd.ExecuteNonQuery();
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

    }
}