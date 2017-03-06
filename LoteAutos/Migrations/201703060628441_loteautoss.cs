namespace LoteAutos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class loteautoss : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "loteautos.automoviles",
                c => new
                    {
                        pkAutomovil = c.Int(nullable: false, identity: true),
                        sFoto1 = c.String(unicode: false),
                        sFoto2 = c.String(unicode: false),
                        sFoto3 = c.String(unicode: false),
                        sMarca = c.String(nullable: false, maxLength: 40, unicode: false),
                        sModelo = c.String(nullable: false, maxLength: 20, unicode: false),
                        iAño = c.Int(nullable: false),
                        sNoSerie = c.String(nullable: false, maxLength: 20, unicode: false),
                        sNoPlaca = c.String(nullable: false, maxLength: 20, unicode: false),
                        sColor = c.String(nullable: false, maxLength: 20, unicode: false),
                        sNacionalidad = c.String(nullable: false, maxLength: 20, unicode: false),
                        dPrecio = c.Double(nullable: false),
                        sObservaciones = c.String(maxLength: 150, unicode: false),
                        bStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.pkAutomovil);
            
            CreateTable(
                "loteautos.propietarioautomoviles",
                c => new
                    {
                        pkPropietarioAutomovil = c.Int(nullable: false, identity: true),
                        fkPropietario = c.Int(nullable: false),
                        fkAutomovil = c.Int(nullable: false),
                        bStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.pkPropietarioAutomovil)
                .ForeignKey("loteautos.propietarios", t => t.fkPropietario)
                .ForeignKey("loteautos.automoviles", t => t.fkAutomovil)
                .Index(t => t.fkPropietario)
                .Index(t => t.fkAutomovil);
            
            CreateTable(
                "loteautos.propietarios",
                c => new
                    {
                        pkPropietario = c.Int(nullable: false, identity: true),
                        sNombre = c.String(nullable: false, maxLength: 40, unicode: false),
                        sApellido = c.String(nullable: false, maxLength: 40, unicode: false),
                        sDireccion = c.String(nullable: false, maxLength: 40, unicode: false),
                        sTelefono = c.String(nullable: false, maxLength: 40, unicode: false),
                        sEmail = c.String(maxLength: 40, unicode: false),
                        sIfe = c.String(nullable: false, maxLength: 40, unicode: false),
                        sFoto = c.String(unicode: false),
                        bStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.pkPropietario);
            
            CreateTable(
                "loteautos.ventas",
                c => new
                    {
                        pkVenta = c.Int(nullable: false, identity: true),
                        fkAutomovil = c.Int(nullable: false),
                        dPrecio = c.Double(nullable: false),
                        bStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.pkVenta)
                .ForeignKey("loteautos.automoviles", t => t.fkAutomovil)
                .Index(t => t.fkAutomovil);
            
            CreateTable(
                "loteautos.detalleventas",
                c => new
                    {
                        pkDetalleVenta = c.Int(nullable: false, identity: true),
                        fkComprador = c.Int(nullable: false),
                        sNombre = c.String(nullable: false, maxLength: 40, unicode: false),
                        sApellido = c.String(nullable: false, maxLength: 40, unicode: false),
                        dtFechaVenta = c.DateTime(nullable: false, precision: 0),
                        dTotal = c.Double(nullable: false),
                        dPago = c.Double(nullable: false),
                        dCambio = c.Double(nullable: false),
                        bStatus = c.Boolean(nullable: false),
                        fkVenta = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.pkDetalleVenta)
                .ForeignKey("loteautos.compradores", t => t.fkComprador)
                .ForeignKey("loteautos.ventas", t => t.fkVenta)
                .Index(t => t.fkComprador)
                .Index(t => t.fkVenta);
            
            CreateTable(
                "loteautos.compradores",
                c => new
                    {
                        pkComprador = c.Int(nullable: false, identity: true),
                        sNombre = c.String(nullable: false, maxLength: 40, unicode: false),
                        sApellido = c.String(nullable: false, maxLength: 40, unicode: false),
                        sDireccion = c.String(nullable: false, maxLength: 80, unicode: false),
                        bStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.pkComprador);
            
            CreateTable(
                "loteautos.comisionregistros",
                c => new
                    {
                        pkComisionRegistro = c.Int(nullable: false, identity: true),
                        dCobro = c.Double(nullable: false),
                        dtFechaCobro = c.DateTime(nullable: false, precision: 0),
                        dPago = c.Double(nullable: false),
                        dCambio = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.pkComisionRegistro);
            
            CreateTable(
                "loteautos.permisos",
                c => new
                    {
                        pkPermiso = c.Int(nullable: false, identity: true),
                        sModulo = c.String(nullable: false, maxLength: 20, unicode: false),
                        sDescripcion = c.String(maxLength: 150, unicode: false),
                        bStatusl = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.pkPermiso);
            
            CreateTable(
                "loteautos.permisosnegadosrol",
                c => new
                    {
                        pkPermisoNegadoRol = c.Int(nullable: false, identity: true),
                        fkPermiso = c.Int(nullable: false),
                        fkRol = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.pkPermisoNegadoRol)
                .ForeignKey("loteautos.roles", t => t.fkRol)
                .ForeignKey("loteautos.permisos", t => t.fkPermiso)
                .Index(t => t.fkPermiso)
                .Index(t => t.fkRol);
            
            CreateTable(
                "loteautos.roles",
                c => new
                    {
                        pkRol = c.Int(nullable: false, identity: true),
                        sNombre = c.String(nullable: false, maxLength: 20, unicode: false),
                        bStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.pkRol);
            
            CreateTable(
                "loteautos.usuarios",
                c => new
                    {
                        pkUsuario = c.Int(nullable: false, identity: true),
                        sUsuario = c.String(nullable: false, maxLength: 40, unicode: false),
                        sPassword = c.String(nullable: false, maxLength: 128, unicode: false),
                        bStatus = c.Boolean(nullable: false),
                        fkRol = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.pkUsuario)
                .ForeignKey("loteautos.roles", t => t.fkRol)
                .Index(t => t.fkRol);
            
        }
        
        public override void Down()
        {
            DropForeignKey("loteautos.permisosnegadosrol", "fkPermiso", "loteautos.permisos");
            DropForeignKey("loteautos.usuarios", "fkRol", "loteautos.roles");
            DropForeignKey("loteautos.permisosnegadosrol", "fkRol", "loteautos.roles");
            DropForeignKey("loteautos.ventas", "fkAutomovil", "loteautos.automoviles");
            DropForeignKey("loteautos.detalleventas", "fkVenta", "loteautos.ventas");
            DropForeignKey("loteautos.detalleventas", "fkComprador", "loteautos.compradores");
            DropForeignKey("loteautos.propietarioautomoviles", "fkAutomovil", "loteautos.automoviles");
            DropForeignKey("loteautos.propietarioautomoviles", "fkPropietario", "loteautos.propietarios");
            DropIndex("loteautos.usuarios", new[] { "fkRol" });
            DropIndex("loteautos.permisosnegadosrol", new[] { "fkRol" });
            DropIndex("loteautos.permisosnegadosrol", new[] { "fkPermiso" });
            DropIndex("loteautos.detalleventas", new[] { "fkVenta" });
            DropIndex("loteautos.detalleventas", new[] { "fkComprador" });
            DropIndex("loteautos.ventas", new[] { "fkAutomovil" });
            DropIndex("loteautos.propietarioautomoviles", new[] { "fkAutomovil" });
            DropIndex("loteautos.propietarioautomoviles", new[] { "fkPropietario" });
            DropTable("loteautos.usuarios");
            DropTable("loteautos.roles");
            DropTable("loteautos.permisosnegadosrol");
            DropTable("loteautos.permisos");
            DropTable("loteautos.comisionregistros");
            DropTable("loteautos.compradores");
            DropTable("loteautos.detalleventas");
            DropTable("loteautos.ventas");
            DropTable("loteautos.propietarios");
            DropTable("loteautos.propietarioautomoviles");
            DropTable("loteautos.automoviles");
        }
    }
}
