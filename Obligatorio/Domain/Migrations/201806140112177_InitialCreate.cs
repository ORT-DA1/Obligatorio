namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administrators",
                c => new
                    {
                        AdministratorId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Name = c.String(),
                        Surname = c.String(),
                        RegistrationDate = c.DateTime(nullable: false),
                        LastAccess = c.DateTime(),
                    })
                .PrimaryKey(t => t.AdministratorId);
            
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
                "dbo.DecorativeColumns",
                c => new
                    {
                        DecorativeColumnId = c.Int(nullable: false, identity: true),
                        Grid_GridId = c.Int(),
                    })
                .PrimaryKey(t => t.DecorativeColumnId)
                .ForeignKey("dbo.Grids", t => t.Grid_GridId)
                .Index(t => t.Grid_GridId);
            
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
            
            CreateTable(
                "dbo.Doors",
                c => new
                    {
                        DoorId = c.Int(nullable: false, identity: true),
                        Grid_GridId = c.Int(),
                    })
                .PrimaryKey(t => t.DoorId)
                .ForeignKey("dbo.Grids", t => t.Grid_GridId)
                .Index(t => t.Grid_GridId);
            
            CreateTable(
                "dbo.Grids",
                c => new
                    {
                        GridId = c.Int(nullable: false, identity: true),
                        GridName = c.String(),
                        Height = c.Int(nullable: false),
                        Width = c.Int(nullable: false),
                        Client_ClientId = c.Int(),
                    })
                .PrimaryKey(t => t.GridId)
                .ForeignKey("dbo.Clients", t => t.Client_ClientId)
                .Index(t => t.Client_ClientId);
            
            CreateTable(
                "dbo.WallBeams",
                c => new
                    {
                        WallBeamId = c.Int(nullable: false, identity: true),
                        Grid_GridId = c.Int(),
                    })
                .PrimaryKey(t => t.WallBeamId)
                .ForeignKey("dbo.Grids", t => t.Grid_GridId)
                .Index(t => t.Grid_GridId);
            
            CreateTable(
                "dbo.Walls",
                c => new
                    {
                        WallId = c.Int(nullable: false, identity: true),
                        Grid_GridId = c.Int(),
                    })
                .PrimaryKey(t => t.WallId)
                .ForeignKey("dbo.Grids", t => t.Grid_GridId)
                .Index(t => t.Grid_GridId);
            
            CreateTable(
                "dbo.Windows",
                c => new
                    {
                        WindowId = c.Int(nullable: false, identity: true),
                        Grid_GridId = c.Int(),
                    })
                .PrimaryKey(t => t.WindowId)
                .ForeignKey("dbo.Grids", t => t.Grid_GridId)
                .Index(t => t.Grid_GridId);
            
            CreateTable(
                "dbo.Signatures",
                c => new
                    {
                        SignatureId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Architect_ArchitectId = c.Int(),
                    })
                .PrimaryKey(t => t.SignatureId)
                .ForeignKey("dbo.Architectes", t => t.Architect_ArchitectId)
                .Index(t => t.Architect_ArchitectId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Signatures", "Architect_ArchitectId", "dbo.Architectes");
            DropForeignKey("dbo.Windows", "Grid_GridId", "dbo.Grids");
            DropForeignKey("dbo.Walls", "Grid_GridId", "dbo.Grids");
            DropForeignKey("dbo.WallBeams", "Grid_GridId", "dbo.Grids");
            DropForeignKey("dbo.Doors", "Grid_GridId", "dbo.Grids");
            DropForeignKey("dbo.DecorativeColumns", "Grid_GridId", "dbo.Grids");
            DropForeignKey("dbo.Grids", "Client_ClientId", "dbo.Clients");
            DropIndex("dbo.Signatures", new[] { "Architect_ArchitectId" });
            DropIndex("dbo.Windows", new[] { "Grid_GridId" });
            DropIndex("dbo.Walls", new[] { "Grid_GridId" });
            DropIndex("dbo.WallBeams", new[] { "Grid_GridId" });
            DropIndex("dbo.Grids", new[] { "Client_ClientId" });
            DropIndex("dbo.Doors", new[] { "Grid_GridId" });
            DropIndex("dbo.DecorativeColumns", new[] { "Grid_GridId" });
            DropTable("dbo.Signatures");
            DropTable("dbo.Windows");
            DropTable("dbo.Walls");
            DropTable("dbo.WallBeams");
            DropTable("dbo.Grids");
            DropTable("dbo.Doors");
            DropTable("dbo.Designers");
            DropTable("dbo.DecorativeColumns");
            DropTable("dbo.Clients");
            DropTable("dbo.Architectes");
            DropTable("dbo.Administrators");
        }
    }
}
