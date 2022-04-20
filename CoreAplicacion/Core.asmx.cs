using CoreAplicacion.CapaServicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using CoreAplicacion.Clases;
using CoreAplicacion.CapaServicioBackup;
namespace CoreAplicacion
{
    /// <summary>
    /// Summary description for Core
    /// </summary>
    [WebService(Namespace = "http://CoreAplicacion.somee.com")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class Core : System.Web.Services.WebService
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        [WebMethod]
        public DataSet Autenticacion(string usuario, string contraseña, int pin, string clave)
        {
            DataSet empty = null;
            if(clave == "Droog ethereal develop 269138")
            {
                try
                {
                    Autenticacion autenticacion = new Autenticacion();
                    DataSet auth = autenticacion.Autenticarse(usuario, contraseña, pin);
                    return auth;
                }
                catch (Exception err)
                {
                    try
                    {
                        log.Error(err.Message);
                        AutenticacionBackup backupAuth = new AutenticacionBackup();
                        DataSet authbackup = backupAuth.Autenticarse(usuario, contraseña, pin);
                        return authbackup;
                    }
                    catch (Exception error)
                    {
                        log.Error(error.Message);
                        return empty;                        
                    }                    
                }
            }
            else
                {
                    return empty;
                }
            
        }
        [WebMethod]
        public DataSet Transaccion(int ID_TipoTransaccion, int DbCr, string Comentario, int NoCuenta, decimal Monto, string clave)
        {
            DataSet empty = null;
            if (clave == "Droog ethereal develop 269138")
            {
                try
                {
                    Transaccion transaccion = new Transaccion();
                    DataSet dataset;
                    dataset = transaccion.transaccion(ID_TipoTransaccion, DbCr, Comentario, NoCuenta, Monto);
                    return dataset;
                }
                catch(Exception err)
                {
                    log.Error(err.Message);
                    try
                    {
                        TransaccionBackup transaccionbackup = new TransaccionBackup();
                        DataSet datasetbackup;
                        datasetbackup = transaccionbackup.transaccion(ID_TipoTransaccion, DbCr, Comentario, NoCuenta, Monto);
                        return datasetbackup;
                    }
                    catch(Exception error)
                    {
                        log.Error(error);
                        return empty;
                    }
                }
            }
            else
            {
                return empty;
            }
            
        }
        [WebMethod]
        public DataSet ObtenerTodasCuentasDiferentes(int ID_Cliente, string clave)
        {
            DataSet empty = null;
            if (clave == "Droog ethereal develop 269138")
            {
                try
                {
                    recargas recargas = new recargas();
                    DataSet dataset = recargas.TodasCuentasDiferentes(ID_Cliente);
                    return dataset;
                }
                catch (Exception err)
                {
                    log.Error(err.Message);
                    try
                    {
                        recargasBackup recargasbackup = new recargasBackup();
                        DataSet datasetbackup = recargasbackup.TodasCuentasDiferentes(ID_Cliente);
                        return datasetbackup;
                    }
                    catch (Exception error)
                    {
                        log.Error(error);
                        return empty;
                    }
                }
                
            }
            else
            {
                return empty;
            }
            
        }

        [WebMethod]
        public DataSet TransaccionATercero(int NoCuenta, int Entidad, int ID_TipoEntidad, int ID_TipoTransaccion, int DbCr, string Comentario, decimal Monto, string clave)
        {
            DataSet empty = null;
            if (clave == "Droog ethereal develop 269138")
            {
                try
                {
                    Transaccion transaccion = new Transaccion();
                    DataSet dataset = transaccion.TransaccionATercero(NoCuenta, Entidad, ID_TipoEntidad, ID_TipoTransaccion, DbCr, Comentario, Monto);
                    return dataset;
                }
                catch (Exception err)
                {
                    log.Error(err.Message);
                    try
                    {
                        TransaccionBackup transaccionbackup = new TransaccionBackup();
                        DataSet datasetbackup = transaccionbackup.TransaccionATercero(NoCuenta, Entidad, ID_TipoEntidad, ID_TipoTransaccion, DbCr, Comentario, Monto);
                        return datasetbackup;
                    }
                    catch (Exception error)
                    {
                        log.Error(error);
                        return empty;
                    }
                }                
            }
            else
            {
                return empty;
            }
                
           
        }


        [WebMethod]
        public bool InsertarCliente(ClienteClase cliente, string clave)
        {
            if (clave == "Droog ethereal develop 269138")
            {
                CRUDCliente crudcliente = new CRUDCliente();
                bool result = crudcliente.InsertarClientes(cliente);
                return result;
            }
            else
                return false;
            
        }
    }
}
