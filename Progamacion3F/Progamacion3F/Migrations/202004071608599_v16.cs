namespace Progamacion3F.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v16 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EntradaMercancias",
                c => new
                    {
                        IDEntrada = c.Int(nullable: false, identity: true),
                        IDProducto = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        IDProveedor = c.Int(nullable: false),
                        FechaEntrada = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IDEntrada)
                .ForeignKey("dbo.Productos", t => t.IDProducto, cascadeDelete: true)
                .ForeignKey("dbo.Proveedores", t => t.IDProveedor, cascadeDelete: true)
                .Index(t => t.IDProducto)
                .Index(t => t.IDProveedor);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EntradaMercancias", "IDProveedor", "dbo.Proveedores");
            DropForeignKey("dbo.EntradaMercancias", "IDProducto", "dbo.Productos");
            DropIndex("dbo.EntradaMercancias", new[] { "IDProveedor" });
            DropIndex("dbo.EntradaMercancias", new[] { "IDProducto" });
            DropTable("dbo.EntradaMercancias");
        }
    }
}
