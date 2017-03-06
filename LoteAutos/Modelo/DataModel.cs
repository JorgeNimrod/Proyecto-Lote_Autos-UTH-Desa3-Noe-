namespace LoteAutos.Modelo
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=DataModel")
        {
        }

        public virtual DbSet<automoviles> automoviles { get; set; }
        public virtual DbSet<comisionregistros> comisionregistros { get; set; }
        public virtual DbSet<compradores> compradores { get; set; }
        public virtual DbSet<detalleventas> detalleventas { get; set; }
        public virtual DbSet<permisos> permisos { get; set; }
        public virtual DbSet<permisosnegadosrol> permisosnegadosrol { get; set; }
        public virtual DbSet<propietarioautomoviles> propietarioautomoviles { get; set; }
        public virtual DbSet<propietarios> propietarios { get; set; }
        public virtual DbSet<roles> roles { get; set; }
        public virtual DbSet<usuarios> usuarios { get; set; }
        public virtual DbSet<ventas> ventas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<automoviles>()
                .Property(e => e.sFoto1)
                .IsUnicode(false);

            modelBuilder.Entity<automoviles>()
                .Property(e => e.sFoto2)
                .IsUnicode(false);

            modelBuilder.Entity<automoviles>()
                .Property(e => e.sFoto3)
                .IsUnicode(false);

            modelBuilder.Entity<automoviles>()
                .Property(e => e.sMarca)
                .IsUnicode(false);

            modelBuilder.Entity<automoviles>()
                .Property(e => e.sModelo)
                .IsUnicode(false);

            modelBuilder.Entity<automoviles>()
                .Property(e => e.sNoSerie)
                .IsUnicode(false);

            modelBuilder.Entity<automoviles>()
                .Property(e => e.sNoPlaca)
                .IsUnicode(false);

            modelBuilder.Entity<automoviles>()
                .Property(e => e.sColor)
                .IsUnicode(false);

            modelBuilder.Entity<automoviles>()
                .Property(e => e.sNacionalidad)
                .IsUnicode(false);

            modelBuilder.Entity<automoviles>()
                .Property(e => e.sObservaciones)
                .IsUnicode(false);

            modelBuilder.Entity<automoviles>()
                .HasMany(e => e.propietarioautomoviles)
                .WithRequired(e => e.automoviles)
                .HasForeignKey(e => e.fkAutomovil)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<automoviles>()
                .HasMany(e => e.ventas)
                .WithRequired(e => e.automoviles)
                .HasForeignKey(e => e.fkAutomovil)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<compradores>()
                .Property(e => e.sNombre)
                .IsUnicode(false);

            modelBuilder.Entity<compradores>()
                .Property(e => e.sApellido)
                .IsUnicode(false);

            modelBuilder.Entity<compradores>()
                .Property(e => e.sDireccion)
                .IsUnicode(false);

            modelBuilder.Entity<compradores>()
                .HasMany(e => e.detalleventas)
                .WithRequired(e => e.compradores)
                .HasForeignKey(e => e.fkComprador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<detalleventas>()
                .Property(e => e.sNombre)
                .IsUnicode(false);

            modelBuilder.Entity<detalleventas>()
                .Property(e => e.sApellido)
                .IsUnicode(false);

            modelBuilder.Entity<permisos>()
                .Property(e => e.sModulo)
                .IsUnicode(false);

            modelBuilder.Entity<permisos>()
                .Property(e => e.sDescripcion)
                .IsUnicode(false);

            modelBuilder.Entity<permisos>()
                .HasMany(e => e.permisosnegadosrol)
                .WithRequired(e => e.permisos)
                .HasForeignKey(e => e.fkPermiso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<propietarios>()
                .Property(e => e.sNombre)
                .IsUnicode(false);

            modelBuilder.Entity<propietarios>()
                .Property(e => e.sApellido)
                .IsUnicode(false);

            modelBuilder.Entity<propietarios>()
                .Property(e => e.sDireccion)
                .IsUnicode(false);

            modelBuilder.Entity<propietarios>()
                .Property(e => e.sTelefono)
                .IsUnicode(false);

            modelBuilder.Entity<propietarios>()
                .Property(e => e.sEmail)
                .IsUnicode(false);

            modelBuilder.Entity<propietarios>()
                .Property(e => e.sIfe)
                .IsUnicode(false);

            modelBuilder.Entity<propietarios>()
                .Property(e => e.sFoto)
                .IsUnicode(false);

            modelBuilder.Entity<propietarios>()
                .HasMany(e => e.propietarioautomoviles)
                .WithRequired(e => e.propietarios)
                .HasForeignKey(e => e.fkPropietario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<roles>()
                .Property(e => e.sNombre)
                .IsUnicode(false);

            modelBuilder.Entity<roles>()
                .HasMany(e => e.permisosnegadosrol)
                .WithRequired(e => e.roles)
                .HasForeignKey(e => e.fkRol)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<roles>()
                .HasMany(e => e.usuarios)
                .WithRequired(e => e.roles)
                .HasForeignKey(e => e.fkRol)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.sUsuario)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.sPassword)
                .IsUnicode(false);

            modelBuilder.Entity<ventas>()
                .HasMany(e => e.detalleventas)
                .WithRequired(e => e.ventas)
                .HasForeignKey(e => e.fkVenta)
                .WillCascadeOnDelete(false);
        }
    }
}
