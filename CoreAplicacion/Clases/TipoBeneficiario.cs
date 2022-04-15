namespace CoreAplicacion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TipoBeneficiario")]
    public partial class TipoBeneficiario
    {
        [Key]
        public int IDTipoBeneficiario { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }
    }
}
