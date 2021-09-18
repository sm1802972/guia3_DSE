namespace MVC_DataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigracionInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.contacto",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombres = c.String(maxLength: 200),
                        primerApellido = c.String(maxLength: 100),
                        segundoApellido = c.String(maxLength: 100),
                        numeroTelefono = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.contacto");
        }
    }
}
