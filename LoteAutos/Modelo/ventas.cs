namespace LoteAutos.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("loteautos.ventas")]
    public partial class ventas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ventas()
        {
            detalleventas = new HashSet<detalleventas>();
            this.bStatus = true;
        }

        [Key]
        public int pkVenta { get; set; }

        public int fkAutomovil { get; set; }

        public double dPrecio { get; set; }

        public bool bStatus { get; set; }

        public virtual automoviles automoviles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detalleventas> detalleventas { get; set; }
    }
}
