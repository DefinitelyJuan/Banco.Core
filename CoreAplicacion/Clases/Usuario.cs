using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreAplicacion.Clases
{
    public class Usuario
    {
        public int id_cliente { get; set; }
        public string usuario { get; set; }
        public string tipo_usuario { get; set; }
        public string contraseña { get; set; }
        public string pin { get; set; }
    }
}