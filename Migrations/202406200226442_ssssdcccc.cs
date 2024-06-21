namespace PosDesktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ssssdcccc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abonoes",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    fechaPago = c.DateTime(nullable: false),
                    valorAbono = c.Decimal(nullable: false, precision: 18, scale: 2),
                    separado_id = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Separadoes", t => t.separado_id, cascadeDelete: true)
                .Index(t => t.separado_id);

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

            AddColumn("dbo.Despachoes", "separados_id", c => c.Int());

            // Crear índice para la clave foránea
            CreateIndex("dbo.Despachoes", "separados_id");

            // Agregar la clave foránea
            AddForeignKey("dbo.Despachoes", "separados_id", "dbo.Separadoes", "id");
        }
        
        public override void Down()
        {
            // Eliminar la clave foránea en Despachoes
            DropForeignKey("dbo.Despachoes", "separados_id", "dbo.Separadoes");

            // Eliminar el índice en Despachoes
            DropIndex("dbo.Despachoes", new[] { "separados_id" });

            // Eliminar la columna separados_id en Despachoes
            DropColumn("dbo.Despachoes", "separados_id");

            // Eliminar la tabla Separadoes
            DropTable("dbo.Separadoes");

            // Eliminar la tabla Abonoes
            DropTable("dbo.Abonoes");
        }
    }
}
