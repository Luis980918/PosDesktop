namespace PosDesktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sssdd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cierres",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        pagoTrabajadoras = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ahorro = c.Decimal(nullable: false, precision: 18, scale: 2),
                        totalBase = c.Decimal(nullable: false, precision: 18, scale: 2),
                        totalEnCaja = c.Decimal(nullable: false, precision: 18, scale: 2),
                        totalCierre = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Despachoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        pagoTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        totalRecibido = c.Decimal(nullable: false, precision: 18, scale: 2),
                        totalDevuelto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fechaMovimiento = c.DateTime(nullable: false),
                        separados_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Separadoes", t => t.separados_id)
                .Index(t => t.separados_id);
            
            CreateTable(
                "dbo.Separadoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        cliente = c.String(nullable: false),
                        articulos = c.String(nullable: false),
                        costoTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        restante = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        numeroItem = c.Int(nullable: false),
                        precioUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        cantidad = c.Int(nullable: false),
                        despacho_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Despachoes", t => t.despacho_id, cascadeDelete: true)
                .Index(t => t.despacho_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ventas", "despacho_id", "dbo.Despachoes");
            DropForeignKey("dbo.Despachoes", "separados_id", "dbo.Separadoes");
            DropIndex("dbo.Ventas", new[] { "despacho_id" });
            DropIndex("dbo.Despachoes", new[] { "separados_id" });
            DropTable("dbo.Ventas");
            DropTable("dbo.Separadoes");
            DropTable("dbo.Despachoes");
            DropTable("dbo.Cierres");
        }
    }
}
