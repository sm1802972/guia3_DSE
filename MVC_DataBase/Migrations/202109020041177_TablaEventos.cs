namespace MVC_DataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablaEventos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.evento",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false, maxLength: 250),
                        fecha = c.DateTime(nullable: false),                        
                        Contactos_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.contacto", t => t.Contactos_id)
                .Index(t => t.Contactos_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.evento", "Contacto_id", "dbo.contacto");
            DropIndex("dbo.evento", new[] { "Contacto_id" });
            DropTable("dbo.evento");
        }
    }
}
