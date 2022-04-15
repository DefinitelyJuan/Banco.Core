namespace CoreAplicacion.Clases
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using CoreAplicacion.Clases;

    public partial class ClienteClase
    {       
        public int IDCliente { get; set; }

        public string Cedula_Cliente { get; set; }
        public string Nombre_Cliente { get; set; }
        public string Direccion_Cliente { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int IDProvincia { get; set; }
        public int IDMunicipio { get; set; }
        public int IDSector { get; set; }
        public int IngresosMensuales { get; set; }     
      
    }
}
