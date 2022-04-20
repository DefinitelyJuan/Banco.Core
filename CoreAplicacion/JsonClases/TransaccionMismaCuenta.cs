using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreAplicacion.JsonClases
{
    public class TransaccionMismaCuenta
    {
        public int ID_TipoTransaccion { get; set; }
        public int DbCr { get; set; }
        public string comentario { get; set; }
        public int NoCuenta { get; set; }
        public decimal Monto { get; set; }
    }   
}
