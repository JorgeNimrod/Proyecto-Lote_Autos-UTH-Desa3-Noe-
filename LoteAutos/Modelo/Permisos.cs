namespace LoteAutos.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("loteautos.permisos")]
    public partial class permisos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public permisos()
        {
            permisosnegadosrol = new HashSet<permisosnegadosrol>();
            this.bStatusl = true;
        }

        [Key]
        public int pkPermiso { get; set; }

        [Required]
        [StringLength(20)]
        public string sModulo { get; set; }

        [StringLength(150)]
        public string sDescripcion { get; set; }

        public bool bStatusl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<permisosnegadosrol> permisosnegadosrol { get; set; }
    }
}
