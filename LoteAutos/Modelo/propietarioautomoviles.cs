namespace LoteAutos.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("loteautos.propietarioautomoviles")]
    public partial class propietarioautomoviles
    {
        public propietarioautomoviles()
        {
            this.bStatus = true;
        }
        [Key]
        public int pkPropietarioAutomovil { get; set; }

        public int fkPropietario { get; set; }

        public int fkAutomovil { get; set; }

        public bool bStatus { get; set; }

        public virtual automoviles automoviles { get; set; }

        public virtual propietarios propietarios { get; set; }
    }
}
