namespace Progamacion3F.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v12 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Facturas",
                c => new
                    {
                        IDFactura = c.Int(nullable: false, identity: true),
                        IDCliente = c.Int(nullable: false),
                        SubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descuento = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ITBIS = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FechaFactura = c.DateTime(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IDFactura)
                .ForeignKey("dbo.Clientes", t => t.IDCliente, cascadeDelete: true)
                .Index(t => t.IDCliente);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Facturas", "IDCliente", "dbo.Clientes");
            DropIndex("dbo.Facturas", new[] { "IDCliente" });
            DropTable("dbo.Facturas");
        }
    }
}
