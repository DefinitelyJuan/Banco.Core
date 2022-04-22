
using CoreAplicacion.CapaServicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using CoreAplicacion.Clases;
using CoreAplicacion.CapaServicioBackup;
using System.Text.Json;
using CoreAplicacion.JsonClases;
using System.Data.SqlClient;

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

                    //Bloque de carga del backup 
                    //TODO: maybe convertir a funcion
                    Controlador controlador = new Controlador();
                    getbackupjson backupInfo = new getbackupjson();
                    TransaccionBackup transaccionBackup = new TransaccionBackup();
                    DataSet backup = backupInfo.backupdata();
                    if (backup.Tables[0].Rows.Count > 0)
                    {
                        log.Info("Iniciando Restauracion de datos");
                        RestauracionDeDatos(backup, transaccionBackup);
                    }
                    //Bloque de carga del backup

                    return auth;
                }
                catch (Exception err)
                {
                    try
                    {
                        log.Error($"Error en Autenticacion: {err.Message}");
                        AutenticacionBackup backupAuth = new AutenticacionBackup();
                        DataSet authbackup = backupAuth.Autenticarse(usuario, contraseña, pin);
                        return authbackup;
                    }
                    catch (Exception error)
                    {
                        log.Error($"Error en Autenticacion version backup: {error.Message}");
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
                    if(dataset.Tables[0].Rows.Count == 0)
                    {
                        throw new Exception("La base de datos del core se encuentra fuera de servicio.");
                    }
                    //Bloque de carga del backup
                    Controlador controlador = new Controlador();
                    getbackupjson backupInfo = new getbackupjson();
                    TransaccionBackup transaccionBackup = new TransaccionBackup();
                    DataSet backup = backupInfo.backupdata();
                    if (backup.Tables[0].Rows.Count > 0)
                    {
                        log.Info("Iniciando Restauracion de datos");
                        RestauracionDeDatos(backup, transaccionBackup);
                    }

                    //Bloque de carga del backup

                    return dataset;
                }
                catch(Exception err)
                {
                    log.Error($"Error en Insertar Transaccion: {err.Message}");
                    try
                    {
                        TransaccionBackup transaccionbackup = new TransaccionBackup();
                        DataSet datasetbackup;
                        datasetbackup = transaccionbackup.transaccion(ID_TipoTransaccion, DbCr, Comentario, NoCuenta, Monto,false);
                        return datasetbackup;
                    }
                    catch(Exception error)
                    {
                        log.Error($"Error en Insertar transaccion version backup: {error.Message}");
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
                    if (dataset.Tables[0].Rows.Count == 0)
                    {
                        throw new Exception("La base de datos del core se encuentra fuera de servicio.");
                    }
                    //Bloque de carga del backup
                    Controlador controlador = new Controlador();
                    getbackupjson backupInfo = new getbackupjson();
                    TransaccionBackup transaccionBackup = new TransaccionBackup();
                    DataSet backup = backupInfo.backupdata();
                    if (backup.Tables[0].Rows.Count > 0)
                    {
                        log.Info("Iniciando Restauracion de datos");
                        RestauracionDeDatos(backup, transaccionBackup);
                    }
                    //Bloque de carga del backup

                    return dataset;
                }
                catch (Exception err)
                {
                    log.Error($"Error en Obtener cuentas diferentes: {err.Message}");
                    try
                    {
                        recargasBackup recargasbackup = new recargasBackup();
                        DataSet datasetbackup = recargasbackup.TodasCuentasDiferentes(ID_Cliente);
                        return datasetbackup;
                    }
                    catch (Exception error)
                    {
                        log.Error($"Error en ObtenerCuentasDiferentes version backup: {error.Message}");
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
                    //Bloque de servicio
                    Transaccion transaccion = new Transaccion();
                    DataSet dataset = transaccion.TransaccionATercero(NoCuenta, Entidad, ID_TipoEntidad, ID_TipoTransaccion, DbCr, Comentario, Monto);
                    //Bloque de servicio
                    if (dataset.Tables[0].Rows.Count == 0)
                    {
                        throw new Exception("La base de datos del core se encuentra fuera de servicio.");
                    }
                    //Bloque de carga del backup
                    Controlador controlador = new Controlador();
                    getbackupjson backupInfo = new getbackupjson();
                    TransaccionBackup transaccionBackup = new TransaccionBackup();
                    DataSet backup = backupInfo.backupdata();
                    if ((backup.Tables[0].Rows.Count > 0))
                    {
                        log.Info("Iniciando Restauracion de datos");
                        RestauracionDeDatos(backup, transaccionBackup);
                    }

                   //Bloque de carga del backup
                    
                    return dataset;

                }
                catch (Exception err)
                {
                    log.Error($"Error en Insertar Transaccion a terceros: {err.Message}");
                    try
                    {
                        TransaccionBackup transaccionbackup = new TransaccionBackup();
                        DataSet datasetbackup = transaccionbackup.TransaccionATercero(NoCuenta, Entidad, ID_TipoEntidad, ID_TipoTransaccion, DbCr, Comentario, Monto, false);
                        return datasetbackup;
                    }
                    catch (Exception error)
                    {
                        log.Error($"Error en Insertar a terceros (coreDown): {error.Message}");
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
        public bool InsertarBeneficiario(int NoCuenta, int ID_TipoBeneficiario, string Nombre, int ID_Cliente, string clave)
        {
            //TODO: Que devuelva dataset/datarow
            if (clave == "Droog ethereal develop 269138")
            {
                bool result = false;
                try
                {
                    InsertBeneficiario beneficiarionormal = new InsertBeneficiario();
                    result = beneficiarionormal.Insert(NoCuenta, ID_TipoBeneficiario, Nombre, ID_Cliente);
                    if (result == false) //No se inserto...
                    {
                        throw new Exception("La base de datos del core se encuentra fuera de servicio.");
                    }
                    //Bloque de carga del backup
                    Controlador controlador = new Controlador();
                    getbackupjson backupInfo = new getbackupjson();
                    TransaccionBackup transaccionBackup = new TransaccionBackup();
                    DataSet backup = backupInfo.backupdata();
                    if (backup.Tables[0].Rows.Count > 0)
                    {
                        log.Info("Iniciando Restauracion de datos");
                        RestauracionDeDatos(backup, transaccionBackup);
                    }
                    //Bloque de carga del backup
                }
                catch (Exception err)
                {
                    log.Error($"Error en Insertar Beneficiario: {err.Message}");
                    InsertBeneficiarioBackup beneficiariohandler = new InsertBeneficiarioBackup();
                    result = beneficiariohandler.Insert(NoCuenta, ID_TipoBeneficiario, Nombre, ID_Cliente, false);
                }
                
                return result;
            }
            else
                return false;

        }
        public void RestauracionDeDatos(DataSet backup, TransaccionBackup transaccionBackup)
        {
            try
            {
                DataTable tableBackup = backup.Tables[0];
                TransaccionMismaCuenta transactMismaCuenta = new TransaccionMismaCuenta();
                TransaccionTercero transact3ero = new TransaccionTercero();
                BeneficiarioInsert beneficiarioInsert = new BeneficiarioInsert();
                PrestamoInsertData prestamoInsertData = new PrestamoInsertData();
                bool data = false;
                DataSet datatest = null;
                foreach (DataRow row in tableBackup.Rows)
                {
                    if (row.IsNull(0))
                        continue;

                    data = false;
                    datatest = new DataSet();
                    switch (row[3].ToString())
                    {
                        case "0": //transaccion misma cuenta
                            {
                                transactMismaCuenta = JsonSerializer.Deserialize<TransaccionMismaCuenta>(row[1].ToString());
                                //el todo seria lo de abajo, es EXPERIMENTAL
                                datatest = transaccionBackup.transaccion(transactMismaCuenta.ID_TipoTransaccion, transactMismaCuenta.DbCr, transactMismaCuenta.comentario, transactMismaCuenta.NoCuenta, transactMismaCuenta.Monto, true);
                                if (datatest.Tables.Count > 0)
                                {
                                    log.Info($"Se inserto transaccion a misma cuenta (recovery): Cuenta: {transactMismaCuenta.NoCuenta}, Monto: {transactMismaCuenta.Monto}, DbCr: {transactMismaCuenta.DbCr}");

                                }
                                break;
                            }
                        case "1": //transaccion 3ero
                            {

                                transact3ero = JsonSerializer.Deserialize<TransaccionTercero>(row[1].ToString());
                                datatest = transaccionBackup.TransaccionATercero(transact3ero.NoCuenta, transact3ero.Entidad, transact3ero.ID_TipoEntidad, transact3ero.ID_TipoTransaccion, transact3ero.DbCr, transact3ero.Comentario, transact3ero.Monto, true);

                                if (datatest.Tables.Count > 0)
                                {
                                    log.Info($"Se inserto transaccion a tercero (recovery): Origen: {transact3ero.NoCuenta}, Destino: {transact3ero.Entidad}, Monto: {transact3ero.Monto}");

                                }
                                break;
                            }
                        case "2": //insert beneficiario
                            {
                                beneficiarioInsert = JsonSerializer.Deserialize<BeneficiarioInsert>(row[1].ToString());
                                InsertBeneficiarioBackup backupbeneficiario = new InsertBeneficiarioBackup();
                                data = backupbeneficiario.Insert(beneficiarioInsert.NoCuenta, beneficiarioInsert.ID_TipoBeneficiario, beneficiarioInsert.nombre, beneficiarioInsert.ID_Cliente, true);
                                if (data == true)
                                {
                                    log.Info($"Se inserto beneficiario (recovery): NoCuenta: {beneficiarioInsert.NoCuenta}, Nombre:{beneficiarioInsert.nombre}, IDCliente: {beneficiarioInsert.ID_Cliente}");

                                }
                                break;
                            }
                        default:
                            {
                                throw new Exception("Error"); //probar poner continue aqui
                            }
                    }
                }
                if ((datatest.Tables.Count > 0) || (data == true))
                {
                    log.Info("Iniciando Truncado...");
                    TruncateBackup backupsTrunc = new TruncateBackup();
                    bool done = backupsTrunc.Truncate();
                    if (done)
                    {
                        log.Info("Tabla backups truncada, base de datos refrescada tras la caida");
                    }
                }
                
            }
            catch (Exception err)
            {
                log.Error($"Error en RestauracionDeDatos: {err.Message}");
            }
        }
    }
}
