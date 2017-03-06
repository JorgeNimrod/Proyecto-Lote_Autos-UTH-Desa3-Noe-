namespace LoteAutos.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("loteautos.usuarios")]
    public partial class usuarios
    {
        public usuarios()
        {
            this.bStatus = true;
        }
        [Key]
        public int pkUsuario { get; set; }

        [Required]
        [StringLength(40)]
        public string sUsuario { get; set; }

        [Required]
        [StringLength(128)]
        public string sPassword { get; set; }

        public bool bStatus { get; set; }

        public int fkRol { get; set; }

        public virtual roles roles { get; set; }
    }
}
