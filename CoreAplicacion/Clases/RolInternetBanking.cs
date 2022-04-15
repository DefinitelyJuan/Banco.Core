namespace CoreAplicacion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using CoreAplicacion.Clases;

    [Table("RolInternetBanking")]
    public partial class RolInternetBanking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RolInternetBanking()
        {
            ClienteInternetBankings = new HashSet<ClienteInternetBanking>();
        }

        [Key]
        public int IDRol { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteInternetBanking> ClienteInternetBankings { get; set; }
    }
}
