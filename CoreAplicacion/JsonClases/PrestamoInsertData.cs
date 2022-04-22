using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreAplicacion.JsonClases
{
    public class PrestamoInsertData
    {
        public decimal Monto { get; set; }
        public decimal MontoPlazoMax { get; set; }
        public int ID_TipoPrestamo { get; set; }
        public int NoCuenta { get; set; }
        public decimal Tasa { get; set; }
        public int Duracion { get; set; }

    }
}