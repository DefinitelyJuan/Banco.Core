using CoreAplicacion.CapaServicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

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

        [WebMethod]
        public DataSet Autenticacion(string usuario, string contraseña, int pin)
        {
            Autenticacion autenticacion = new Autenticacion();
            DataSet auth = autenticacion.Autenticarse(usuario, contraseña, pin);
            return auth;
        }
        [WebMethod]
        public DataSet Transaccion(int ID_TipoTransaccion, int DbCr, string Comentario, int NoCuenta, decimal Monto)
        {
            Transaccion transaccion = new Transaccion();
            DataSet dataset;
            dataset = transaccion.transaccion(ID_TipoTransaccion, DbCr, Comentario, NoCuenta, Monto);
            return dataset;
        }
        [WebMethod]
        public DataSet ObtenerTodasCuentasDiferentes(int ID_Cliente)
        {
            recargas recargas = new recargas();
            DataSet dataset = recargas.TodasCuentasDiferentes(ID_Cliente);
            return dataset;
        }
        [WebMethod]
        public DataSet TransaccionATercero(int NoCuenta, int Entidad, int ID_TipoEntidad, int ID_TipoTransaccion, int DbCr, string Comentario, decimal Monto)
        {
            Transaccion transaccion = new Transaccion();
            DataSet dataset = transaccion.TransaccionATercero(NoCuenta, Entidad, ID_TipoEntidad, ID_TipoTransaccion, DbCr, Comentario, Monto);
            return dataset;
        }
    }
}
