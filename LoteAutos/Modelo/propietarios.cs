namespace LoteAutos.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("loteautos.propietarios")]
    public partial class propietarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public propietarios()
        {
            propietarioautomoviles = new HashSet<propietarioautomoviles>();
            this.bStatus = true;
        }

        [Key]
        public int pkPropietario { get; set; }

        [Required]
        [StringLength(40)]
        public string sNombre { get; set; }

        [Required]
        [StringLength(40)]
        public string sApellido { get; set; }

        [Required]
        [StringLength(40)]
        public string sDireccion { get; set; }

        [Required]
        [StringLength(40)]
        public string sTelefono { get; set; }

        [StringLength(40)]
        public string sEmail { get; set; }

        [Required]
        [StringLength(40)]
        public string sIfe { get; set; }

        [StringLength(16777215)]
        public string sFoto { get; set; }

        public bool bStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<propietarioautomoviles> propietarioautomoviles { get; set; }
    }
}
