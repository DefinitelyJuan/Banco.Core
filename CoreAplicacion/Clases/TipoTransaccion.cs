namespace CoreAplicacion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using CoreAplicacion.Clases;

    [Table("TipoTransaccion")]
    public partial class TipoTransaccion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoTransaccion()
        {
            Transaccions = new HashSet<TransaccionClass>();
        }

        [Key]
        public int IDTipoTransaccion { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransaccionClass> Transaccions { get; set; }
    }
}
