namespace Progamacion3F.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v15 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DetalleFacturas",
                c => new
                    {
                        IDDetalle = c.Int(nullable: false, identity: true),
                        IDFactura = c.Int(nullable: false),
                        IDProducto = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.IDDetalle)
                .ForeignKey("dbo.Facturas", t => t.IDFactura, cascadeDelete: true)
                .ForeignKey("dbo.Productos", t => t.IDProducto, cascadeDelete: true)
                .Index(t => t.IDFactura)
                .Index(t => t.IDProducto);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DetalleFacturas", "IDProducto", "dbo.Productos");
            DropForeignKey("dbo.DetalleFacturas", "IDFactura", "dbo.Facturas");
            DropIndex("dbo.DetalleFacturas", new[] { "IDProducto" });
            DropIndex("dbo.DetalleFacturas", new[] { "IDFactura" });
            DropTable("dbo.DetalleFacturas");
        }
    }
}
