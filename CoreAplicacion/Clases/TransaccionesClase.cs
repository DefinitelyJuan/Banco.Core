using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreAplicacion.Clases
{
    public class TransaccionesClase
    {
        public int ID_Transacciones { get; set; }
        public decimal monto { get; set; }
        public int ID_TipoTransaccion { get; set; }
        public int DbCr { get; set; }
        public string Comentario { get; set; }
        public int NoCuenta { get; set; }
        public DateTime FechaTransaccion { get; set; }

    }
}