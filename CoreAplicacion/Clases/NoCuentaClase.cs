using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreAplicacion.Clases
{
    public class NoCuentaClase
    {
        public int NoCuenta {get; set; }
        public decimal monto { get; set; }
        public int ID_Cliente { get; set; }
        public int ID_TipoCuenta { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaUltimaActualizacion { get; set; }




    }
}