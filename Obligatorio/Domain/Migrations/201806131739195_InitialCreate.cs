namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Architectes",
                c => new
                    {
                        ArchitectId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Name = c.String(),
                        Surname = c.String(),
                        RegistrationDate = c.DateTime(nullable: false),
                        LastAccess = c.DateTime(),
                    })
                .PrimaryKey(t => t.ArchitectId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        Phone = c.String(),
                        Address = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Name = c.String(),
                        Surname = c.String(),
                        RegistrationDate = c.DateTime(nullable: false),
                        LastAccess = c.DateTime(),
                    })
                .PrimaryKey(t => t.ClientId);
            
            CreateTable(
                "dbo.Designers",
                c => new
                    {
                        DesignerId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Name = c.String(),
                        Surname = c.String(),
                        RegistrationDate = c.DateTime(nullable: false),
                        LastAccess = c.DateTime(),
                    })
                .PrimaryKey(t => t.DesignerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Designers");
            DropTable("dbo.Clients");
            DropTable("dbo.Architectes");
        }
    }
}
