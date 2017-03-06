namespace LoteAutos.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("loteautos.comisionregistros")]
    public partial class comisionregistros
    {
        [Key]
        public int pkComisionRegistro { get; set; }

        public double dCobro { get; set; }

        public DateTime dtFechaCobro { get; set; }

        public double dPago { get; set; }

        public double dCambio { get; set; }
    }
}
