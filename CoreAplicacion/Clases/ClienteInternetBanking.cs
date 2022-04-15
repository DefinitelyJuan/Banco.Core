namespace CoreAplicacion.Clases
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using CoreAplicacion.Clases;

    [Table("ClienteInternetBanking")]
    public partial class ClienteInternetBanking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClienteInternetBanking()
        {
            Cuentas = new HashSet<Cuenta>();
            Transaccions = new HashSet<TransaccionClass>();
        }

        [Key]
        public int IDCliente { get; set; }

        [Required]
        [StringLength(13)]
        public string Cedula { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [StringLength(100)]
        public string Dirección { get; set; }

        [Required]
        [StringLength(50)]
        public string Pais { get; set; }

        [Required]
        [StringLength(50)]
        public string CorreoElectronico { get; set; }

        [Required]
        [StringLength(50)]
        public string Sexo { get; set; }

        public int IDRol { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreUsuario { get; set; }

        [Required]
        [StringLength(500)]
        public string ContraseñaUsuario { get; set; }

        [Required]
        [StringLength(4)]
        public string PIN { get; set; }

        public DateTime FechaRegistro { get; set; }

        public virtual RolInternetBanking RolInternetBanking { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cuenta> Cuentas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransaccionClass> Transaccions { get; set; }
    }
}
