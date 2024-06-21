namespace PosDesktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abonos : DbMigration
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Abonoes", "separado_id", "dbo.Separadoes");
            DropIndex("dbo.Abonoes", new[] { "separado_id" });
            DropTable("dbo.Abonoes");
        }
    }
}
