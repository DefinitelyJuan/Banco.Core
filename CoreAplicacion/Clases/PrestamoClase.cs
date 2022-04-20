using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreAplicacion.Clases
{
    public class PrestamoClase
    {
        public int ID_Prestamo { get; set; }
        public decimal monto { get; set; }
        public decimal montoPlazoMax { get; set; }
        public int ID_TipoPrestamo { get; set; }
        public int NoCuenta { get; set; }
        public decimal tasa { get; set; }
        public int duracion { get; set; }
        public DateTime FechaPrestamo { get; set; }
    }
}