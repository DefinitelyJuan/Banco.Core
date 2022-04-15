namespace CoreAplicacion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using CoreAplicacion.Clases;

    [Table("Cuenta")]
    public partial class Cuenta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cuenta()
        {
            Transaccions = new HashSet<TransaccionClass>();
        }

        [Key]
        public int IDCuenta { get; set; }

        public int NoCuenta { get; set; }

        public int IDCliente { get; set; }

        public int IDTipoCuenta { get; set; }

        public int IDTipoMoneda { get; set; }

        public decimal Balance { get; set; }

        public DateTime FechaRegistro { get; set; }

        public virtual ClienteInternetBanking ClienteInternetBanking { get; set; }

        public virtual TipoCuenta TipoCuenta { get; set; }

        public virtual TipoMoneda TipoMoneda { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransaccionClass> Transaccions { get; set; }
    }
}
