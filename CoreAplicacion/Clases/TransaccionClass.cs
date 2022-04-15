namespace CoreAplicacion
{
    using CoreAplicacion.Clases;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Transaccion")]
    public partial class TransaccionClass
    {
        [Key]
        public long IDTransaccion { get; set; }

        public int IDCliente { get; set; }

        public int IDTipoTransaccion { get; set; }

        public int NoCuentaOrigen { get; set; }

        public DateTime FechaTransaccion { get; set; }

        public decimal MontoTransaccion { get; set; }

        public int NoCuentaDestino { get; set; }

        public virtual ClienteInternetBanking ClienteInternetBanking { get; set; }

        public virtual Cuenta Cuenta { get; set; }

        public virtual TipoTransaccion TipoTransaccion { get; set; }
    }
}
