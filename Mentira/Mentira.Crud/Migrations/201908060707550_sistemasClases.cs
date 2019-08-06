namespace Mentira.Crud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sistemasClases : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        TipoClienteId = c.Int(nullable: false),
                        RFC = c.String(),
                    })
                .PrimaryKey(t => t.ClienteId)
                .ForeignKey("dbo.TipoClientes", t => t.TipoClienteId, cascadeDelete: true)
                .Index(t => t.TipoClienteId);
            
            CreateTable(
                "dbo.TipoClientes",
                c => new
                    {
                        TipoClienteId = c.Int(nullable: false, identity: true),
                        NombreTipo = c.String(),
                    })
                .PrimaryKey(t => t.TipoClienteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clientes", "TipoClienteId", "dbo.TipoClientes");
            DropIndex("dbo.Clientes", new[] { "TipoClienteId" });
            DropTable("dbo.TipoClientes");
            DropTable("dbo.Clientes");
        }
    }
}
