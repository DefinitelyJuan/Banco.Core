using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreAplicacion.Clases
{
    public class PagoClase
    {
        public int NoCuenta { get; set; }
        public int Entidad { get; set; }
        public string ID_TipoEntidad { get; set; }
        public int ID_Transacciones { get; set; }
    }
}