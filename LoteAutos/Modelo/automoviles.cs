namespace LoteAutos.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("loteautos.automoviles")]
    public partial class automoviles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public automoviles()
        {
            propietarioautomoviles = new HashSet<propietarioautomoviles>();
            ventas = new HashSet<ventas>();
            this.bStatus = true;
        }

        [Key]
        public int pkAutomovil { get; set; }

        [StringLength(16777215)]
        public string sFoto1 { get; set; }

        [StringLength(16777215)]
        public string sFoto2 { get; set; }

        [StringLength(16777215)]
        public string sFoto3 { get; set; }

        [Required]
        [StringLength(40)]
        public string sMarca { get; set; }

        [Required]
        [StringLength(20)]
        public string sModelo { get; set; }

        public int iAño { get; set; }

        [Required]
        [StringLength(20)]
        public string sNoSerie { get; set; }

        [Required]
        [StringLength(20)]
        public string sNoPlaca { get; set; }

        [Required]
        [StringLength(20)]
        public string sColor { get; set; }

        [Required]
        [StringLength(20)]
        public string sNacionalidad { get; set; }

        public double dPrecio { get; set; }

        [StringLength(150)]
        public string sObservaciones { get; set; }

        public bool bStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<propietarioautomoviles> propietarioautomoviles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ventas> ventas { get; set; }
    }
}
