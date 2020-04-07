namespace Progamacion3F.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClientesClassv1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Clientes");
            DropPrimaryKey("dbo.Productos");
            DropPrimaryKey("dbo.Proveedores");

            DropColumn("dbo.Clientes", "ID");
            DropColumn("dbo.Productos", "ID");
            DropColumn("dbo.Proveedores", "ID");

            AddColumn("dbo.Clientes", "IDClientes", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Productos", "IDProductos", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Proveedores", "IDProveedores", c => c.Int(nullable: false, identity: true));

            AlterColumn("dbo.Clientes", "Nombre", c => c.String(nullable: false));
            AlterColumn("dbo.Clientes", "Telefono", c => c.String(nullable: false));
            AlterColumn("dbo.Productos", "Nombre", c => c.String(nullable: false));
            AlterColumn("dbo.Proveedores", "Nombre", c => c.String(nullable: false));
            AlterColumn("dbo.Proveedores", "Telefono", c => c.String(nullable: false));
            AlterColumn("dbo.Proveedores", "Email", c => c.String(nullable: false));
            AddPrimaryKey("dbo.Clientes", "IDClientes");
            AddPrimaryKey("dbo.Productos", "IDProductos");
            AddPrimaryKey("dbo.Proveedores", "IDProveedores");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Proveedores", "ID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Productos", "ID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Clientes", "ID", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Proveedores");
            DropPrimaryKey("dbo.Productos");
            DropPrimaryKey("dbo.Clientes");
            AlterColumn("dbo.Proveedores", "Email", c => c.String());
            AlterColumn("dbo.Proveedores", "Telefono", c => c.String());
            AlterColumn("dbo.Proveedores", "Nombre", c => c.String());
            AlterColumn("dbo.Productos", "Nombre", c => c.String());
            AlterColumn("dbo.Clientes", "Telefono", c => c.String());
            AlterColumn("dbo.Clientes", "Nombre", c => c.String());
            DropColumn("dbo.Proveedores", "IDProveedores");
            DropColumn("dbo.Productos", "IDProductos");
            DropColumn("dbo.Clientes", "IDClientes");
            AddPrimaryKey("dbo.Proveedores", "ID");
            AddPrimaryKey("dbo.Productos", "ID");
            AddPrimaryKey("dbo.Clientes", "ID");
        }
    }
}
