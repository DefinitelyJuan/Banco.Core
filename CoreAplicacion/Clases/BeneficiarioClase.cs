using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreAplicacion.Clases
{
    public class BeneficiarioClase
    {
        public int ID_Beneficiario { get; set; }
        public int NoCuenta { get; set; }
        public int ID_TipoBeneficiario { get; set; }      
        public string nombre { get; set; }
        public int ID_Cliente { get; set; }
    }
}