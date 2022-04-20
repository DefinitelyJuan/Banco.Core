using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreAplicacion.JsonClases
{
    public class TransaccionTercero
    {
        public int NoCuenta { get; set; }
        public int Entidad { get; set; }
        public int ID_TipoEntidad { get; set; }
        public int ID_TipoTransaccion { get; set; }
        public int DbCr { get; set; }
        public string Comentario { get; set; }
        public decimal Monto { get; set; }
    }
}