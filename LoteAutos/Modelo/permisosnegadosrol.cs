namespace LoteAutos.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("loteautos.permisosnegadosrol")]
    public partial class permisosnegadosrol
    {
        [Key]
        public int pkPermisoNegadoRol { get; set; }

        public int fkPermiso { get; set; }

        public int fkRol { get; set; }

        public virtual permisos permisos { get; set; }

        public virtual roles roles { get; set; }
    }
}
