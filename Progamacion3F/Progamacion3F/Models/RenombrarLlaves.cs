using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Progamacion3F.Models
{
    public partial class RenombrarLlaves : DbMigration
    {
        public override void Up()
        {
            //DropPrimaryKey("dbo.Clientes", new[] { "ID" });
            //DropColumn("dbo.Clientes", "ID");
            //AddColumn("dbo.Clientes", "IDClientes", c => c.Int(nullable: false, identity: true));
            //AddPrimaryKey("dbo.Clientes", "IDClientes");
        }
    }
}