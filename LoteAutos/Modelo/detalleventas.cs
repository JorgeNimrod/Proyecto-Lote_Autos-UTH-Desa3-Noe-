namespace LoteAutos.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("loteautos.detalleventas")]
    public partial class detalleventas
    {
        public detalleventas()
        {
            this.bStatus = true;
        }
        [Key]
        public int pkDetalleVenta { get; set; }

        public int fkComprador { get; set; }

        [Required]
        [StringLength(40)]
        public string sNombre { get; set; }

        [Required]
        [StringLength(40)]
        public string sApellido { get; set; }

        public DateTime dtFechaVenta { get; set; }

        public double dTotal { get; set; }

        public double dPago { get; set; }

        public double dCambio { get; set; }

        public bool bStatus { get; set; }

        public int fkVenta { get; set; }

        public virtual compradores compradores { get; set; }

        public virtual ventas ventas { get; set; }
    }
}
