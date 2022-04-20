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
                        datasetbackup = transaccionbackup.transaccion(ID_TipoTransaccion, DbCr, Comentario, NoCuenta, Monto,false);
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
                    //Bloque de servicio
                    Transaccion transaccion = new Transaccion();
                    DataSet dataset = transaccion.TransaccionATercero(NoCuenta, Entidad, ID_TipoEntidad, ID_TipoTransaccion, DbCr, Comentario, Monto);
                    //Bloque de servicio

                    //Bloque de carga del backup
                    Controlador controlador = new Controlador();
                    getbackupjson backupInfo = new getbackupjson();
                    TransaccionBackup transaccionBackup = new TransaccionBackup();
                    DataSet backup = backupInfo.backupdata();
                    if (backup.Tables.Count != 0)
                    {
                        DataTable tableBackup = backup.Tables[0];
                        //Usuario userobj = new Usuario();
                        //ClienteClase clienteobj = new ClienteClase();
                        //BeneficiarioClase beneficiarioobj = new BeneficiarioClase();
                        //NoCuentaClase nocuentaobj = new NoCuentaClase();
                        //PagoClase pagoobj = new PagoClase();
                        //PrestamoClase prestamoobj = new PrestamoClase();
                        //TransaccionesClase transaccionesobj = new TransaccionesClase();
                        TransaccionMismaCuenta transactMismaCuenta = new TransaccionMismaCuenta();
                        TransaccionTercero transact3ero = new TransaccionTercero();
                        BeneficiarioInsert beneficiarioInsert = new BeneficiarioInsert();
                        foreach (DataRow row in tableBackup.Rows)
                        {
                            switch (row[3].ToString())
                            {
                                case "0": //transaccion misma cuenta
                                    {
                                        transactMismaCuenta = JsonSerializer.Deserialize<TransaccionMismaCuenta>(row[1].ToString());
                                        //TODO: Insert de la bd (usar dataset si deja el profe)
                                        //el todo seria lo de abajo, es EXPERIMENTAL
                                        transaccionBackup.transaccion(transactMismaCuenta.ID_TipoTransaccion, transactMismaCuenta.DbCr, transactMismaCuenta.comentario, transactMismaCuenta.NoCuenta, transactMismaCuenta.Monto, true);
                                        break;
                                    }
                                case "1": //transaccion 3ero
                                    {

                                        transact3ero = JsonSerializer.Deserialize<TransaccionTercero>(row[1].ToString());
                                        transaccionBackup.TransaccionATercero(transact3ero.NoCuenta,transact3ero.Entidad,transact3ero.ID_TipoEntidad,transact3ero.ID_TipoTransaccion, transact3ero.DbCr,transact3ero.Comentario,transact3ero.Monto, true);
                                        break;
                                    }
                                case "2": //insert beneficiario
                                    {
                                        beneficiarioInsert = JsonSerializer.Deserialize<BeneficiarioInsert>(row[1].ToString());
                                        InsertBeneficiarioBackup backupbeneficiario = new InsertBeneficiarioBackup();
                                        backupbeneficiario.Insert(beneficiarioInsert.id_beneficiario, beneficiarioInsert.NoCuenta, beneficiarioInsert.ID_TipoBeneficiario, beneficiarioInsert.nombre, beneficiarioInsert.ID_Cliente, true);


                                        break;
                                    }
                                //and so on...
                                //case "3":
                                //    {
                                //        transaccionesobj = JsonSerializer.Deserialize<TransaccionesClase>(row[1].ToString());
                                //        //capaserviciobackup.
                                //        transaccion.InsertarTransaccion(transaccionesobj.ID_TipoTransaccion, transaccionesobj.DbCr, transaccionesobj.Comentario, transaccionesobj.NoCuenta, transaccionesobj.monto);


                                //        break;
                                //    }
                                //case "4":
                                //    {
                                //        pagoobj = JsonSerializer.Deserialize<PagoClase>(row[1].ToString());



                                //        break;
                                //    }
                                //case "5":
                                //    {
                                //        prestamoobj = JsonSerializer.Deserialize<PrestamoClase>(row[1].ToString());


                                //        break;
                                //    }
                                //case "6":
                                //    {
                                //        beneficiarioobj = JsonSerializer.Deserialize<BeneficiarioClase>(row[1].ToString());                                     

                                //        break;
                                //    }
                                default:
                                    {
                                        throw new Exception("Error");
                                    }
                            }
                        }
                            //bucle de inserts
                            //actualizar estados
                            //truncar tabla CONFLICT (preguntar, pq si trunco entonces no tengo que actualizar estados)
                    }
                   //Bloque de carga del backup
                    
                    return dataset;

                }
                catch (Exception err)
                {
                    log.Error(err.Message);
                    try
                    {
                        TransaccionBackup transaccionbackup = new TransaccionBackup();
                        DataSet datasetbackup = transaccionbackup.TransaccionATercero(NoCuenta, Entidad, ID_TipoEntidad, ID_TipoTransaccion, DbCr, Comentario, Monto, false);
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

        [WebMethod]
        public bool InsertarBeneficiario(int ID_Beneficiario, int NoCuenta, int ID_TipoBeneficiario, string Nombre, int ID_Cliente, string clave)
        {
            if (clave == "Droog ethereal develop 269138")
            {
                bool result = false;
                try
                {
                    InsertBeneficiario beneficiariohandler = new InsertBeneficiario();
                    result = beneficiariohandler.Insert(ID_Beneficiario, NoCuenta, ID_TipoBeneficiario, Nombre, ID_Cliente);
                }
                catch (Exception err)
                {
                    log.Error(err.Message);
                    InsertBeneficiarioBackup beneficiariohandler = new InsertBeneficiarioBackup();
                    result = beneficiariohandler.Insert(ID_Beneficiario, NoCuenta, ID_TipoBeneficiario, Nombre, ID_Cliente, false);
                }
                
                return result;
            }
            else
                return false;

        }
    }
}
