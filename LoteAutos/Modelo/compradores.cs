namespace LoteAutos.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("loteautos.compradores")]
    public partial class compradores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public compradores()
        {
            detalleventas = new HashSet<detalleventas>();
            this.bStatus = true;
        }

        [Key]
        public int pkComprador { get; set; }

        [Required]
        [StringLength(40)]
        public string sNombre { get; set; }

        [Required]
        [StringLength(40)]
        public string sApellido { get; set; }

        [Required]
        [StringLength(80)]
        public string sDireccion { get; set; }

        public bool bStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detalleventas> detalleventas { get; set; }
    }
}
