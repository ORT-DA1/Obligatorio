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
                "dbo.GeneratedDoors",
                c => new
                    {
                        GeneratedDoorId = c.Int(nullable: false, identity: true),
                        Architect_ArchitectId = c.Int(),
                    })
                .PrimaryKey(t => t.GeneratedDoorId)
                .ForeignKey("dbo.Architectes", t => t.Architect_ArchitectId)
                .Index(t => t.Architect_ArchitectId);
            
            CreateTable(
                "dbo.GeneratedWindows",
                c => new
                    {
                        GeneratedWindowId = c.Int(nullable: false, identity: true),
                        Architect_ArchitectId = c.Int(),
                    })
                .PrimaryKey(t => t.GeneratedWindowId)
                .ForeignKey("dbo.Architectes", t => t.Architect_ArchitectId)
                .Index(t => t.Architect_ArchitectId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        IdentityCard = c.String(),
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
                        width = c.Single(nullable: false),
                        Grid_GridId = c.Int(nullable: false),
                        PriceAndCost_PriceAndCostId = c.Int(),
                        UbicationPoint_PointId = c.Int(),
                    })
                .PrimaryKey(t => t.DecorativeColumnId)
                .ForeignKey("dbo.Grids", t => t.Grid_GridId, cascadeDelete: true)
                .ForeignKey("dbo.PricesAndCosts", t => t.PriceAndCost_PriceAndCostId)
                .ForeignKey("dbo.Points", t => t.UbicationPoint_PointId)
                .Index(t => t.Grid_GridId)
                .Index(t => t.PriceAndCost_PriceAndCostId)
                .Index(t => t.UbicationPoint_PointId);
            
            CreateTable(
                "dbo.Grids",
                c => new
                    {
                        GridId = c.Int(nullable: false, identity: true),
                        GridName = c.String(),
                        Height = c.Int(nullable: false),
                        Width = c.Int(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                        Client_ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GridId)
                .ForeignKey("dbo.Clients", t => t.Client_ClientId, cascadeDelete: true)
                .Index(t => t.Client_ClientId);
            
            CreateTable(
                "dbo.Doors",
                c => new
                    {
                        DoorId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        sense = c.String(),
                        Width = c.Single(nullable: false),
                        Height = c.Single(nullable: false),
                        Architect_ArchitectId = c.Int(),
                        EndPoint_PointId = c.Int(),
                        Grid_GridId = c.Int(nullable: false),
                        PriceAndCost_PriceAndCostId = c.Int(),
                        StartPoint_PointId = c.Int(),
                    })
                .PrimaryKey(t => t.DoorId)
                .ForeignKey("dbo.Architectes", t => t.Architect_ArchitectId)
                .ForeignKey("dbo.Points", t => t.EndPoint_PointId)
                .ForeignKey("dbo.Grids", t => t.Grid_GridId, cascadeDelete: true)
                .ForeignKey("dbo.PricesAndCosts", t => t.PriceAndCost_PriceAndCostId)
                .ForeignKey("dbo.Points", t => t.StartPoint_PointId)
                .Index(t => t.Architect_ArchitectId)
                .Index(t => t.EndPoint_PointId)
                .Index(t => t.Grid_GridId)
                .Index(t => t.PriceAndCost_PriceAndCostId)
                .Index(t => t.StartPoint_PointId);
            
            CreateTable(
                "dbo.Points",
                c => new
                    {
                        PointId = c.Int(nullable: false, identity: true),
                        X = c.Int(nullable: false),
                        Y = c.Int(nullable: false),
                        Wall_WallId = c.Int(),
                    })
                .PrimaryKey(t => t.PointId)
                .ForeignKey("dbo.Walls", t => t.Wall_WallId)
                .Index(t => t.Wall_WallId);
            
            CreateTable(
                "dbo.PricesAndCosts",
                c => new
                    {
                        PriceAndCostId = c.Int(nullable: false, identity: true),
                        Price = c.Int(nullable: false),
                        Cost = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PriceAndCostId);
            
            CreateTable(
                "dbo.Walls",
                c => new
                    {
                        WallId = c.Int(nullable: false, identity: true),
                        endUbicationPoint_PointId = c.Int(),
                        Grid_GridId = c.Int(nullable: false),
                        PriceAndCost_PriceAndCostId = c.Int(),
                        startUbicationPoint_PointId = c.Int(),
                    })
                .PrimaryKey(t => t.WallId)
                .ForeignKey("dbo.Points", t => t.endUbicationPoint_PointId)
                .ForeignKey("dbo.Grids", t => t.Grid_GridId, cascadeDelete: true)
                .ForeignKey("dbo.PricesAndCosts", t => t.PriceAndCost_PriceAndCostId)
                .ForeignKey("dbo.Points", t => t.startUbicationPoint_PointId)
                .Index(t => t.endUbicationPoint_PointId)
                .Index(t => t.Grid_GridId)
                .Index(t => t.PriceAndCost_PriceAndCostId)
                .Index(t => t.startUbicationPoint_PointId);
            
            CreateTable(
                "dbo.WallBeams",
                c => new
                    {
                        WallBeamId = c.Int(nullable: false, identity: true),
                        Grid_GridId = c.Int(nullable: false),
                        PriceAndCost_PriceAndCostId = c.Int(),
                        UbicationPoint_PointId = c.Int(),
                    })
                .PrimaryKey(t => t.WallBeamId)
                .ForeignKey("dbo.Grids", t => t.Grid_GridId, cascadeDelete: true)
                .ForeignKey("dbo.PricesAndCosts", t => t.PriceAndCost_PriceAndCostId)
                .ForeignKey("dbo.Points", t => t.UbicationPoint_PointId)
                .Index(t => t.Grid_GridId)
                .Index(t => t.PriceAndCost_PriceAndCostId)
                .Index(t => t.UbicationPoint_PointId);
            
            CreateTable(
                "dbo.Windows",
                c => new
                    {
                        WindowId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        sense = c.String(),
                        width = c.Single(nullable: false),
                        high = c.Single(nullable: false),
                        distanceFromGround = c.Single(nullable: false),
                        Architect_ArchitectId = c.Int(),
                        EndPoint_PointId = c.Int(),
                        Grid_GridId = c.Int(nullable: false),
                        PriceAndCost_PriceAndCostId = c.Int(),
                        StartPoint_PointId = c.Int(),
                    })
                .PrimaryKey(t => t.WindowId)
                .ForeignKey("dbo.Architectes", t => t.Architect_ArchitectId)
                .ForeignKey("dbo.Points", t => t.EndPoint_PointId)
                .ForeignKey("dbo.Grids", t => t.Grid_GridId, cascadeDelete: true)
                .ForeignKey("dbo.PricesAndCosts", t => t.PriceAndCost_PriceAndCostId)
                .ForeignKey("dbo.Points", t => t.StartPoint_PointId)
                .Index(t => t.Architect_ArchitectId)
                .Index(t => t.EndPoint_PointId)
                .Index(t => t.Grid_GridId)
                .Index(t => t.PriceAndCost_PriceAndCostId)
                .Index(t => t.StartPoint_PointId);
            
            CreateTable(
                "dbo.Signatures",
                c => new
                    {
                        SignatureId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Architect_ArchitectId = c.Int(),
                        Grid_GridId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SignatureId)
                .ForeignKey("dbo.Architectes", t => t.Architect_ArchitectId)
                .ForeignKey("dbo.Grids", t => t.Grid_GridId, cascadeDelete: true)
                .Index(t => t.Architect_ArchitectId)
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DecorativeColumns", "UbicationPoint_PointId", "dbo.Points");
            DropForeignKey("dbo.DecorativeColumns", "PriceAndCost_PriceAndCostId", "dbo.PricesAndCosts");
            DropForeignKey("dbo.DecorativeColumns", "Grid_GridId", "dbo.Grids");
            DropForeignKey("dbo.Signatures", "Grid_GridId", "dbo.Grids");
            DropForeignKey("dbo.Signatures", "Architect_ArchitectId", "dbo.Architectes");
            DropForeignKey("dbo.Doors", "StartPoint_PointId", "dbo.Points");
            DropForeignKey("dbo.Doors", "PriceAndCost_PriceAndCostId", "dbo.PricesAndCosts");
            DropForeignKey("dbo.Windows", "StartPoint_PointId", "dbo.Points");
            DropForeignKey("dbo.Windows", "PriceAndCost_PriceAndCostId", "dbo.PricesAndCosts");
            DropForeignKey("dbo.Windows", "Grid_GridId", "dbo.Grids");
            DropForeignKey("dbo.Windows", "EndPoint_PointId", "dbo.Points");
            DropForeignKey("dbo.Windows", "Architect_ArchitectId", "dbo.Architectes");
            DropForeignKey("dbo.WallBeams", "UbicationPoint_PointId", "dbo.Points");
            DropForeignKey("dbo.WallBeams", "PriceAndCost_PriceAndCostId", "dbo.PricesAndCosts");
            DropForeignKey("dbo.WallBeams", "Grid_GridId", "dbo.Grids");
            DropForeignKey("dbo.Walls", "startUbicationPoint_PointId", "dbo.Points");
            DropForeignKey("dbo.Walls", "PriceAndCost_PriceAndCostId", "dbo.PricesAndCosts");
            DropForeignKey("dbo.Points", "Wall_WallId", "dbo.Walls");
            DropForeignKey("dbo.Walls", "Grid_GridId", "dbo.Grids");
            DropForeignKey("dbo.Walls", "endUbicationPoint_PointId", "dbo.Points");
            DropForeignKey("dbo.Doors", "Grid_GridId", "dbo.Grids");
            DropForeignKey("dbo.Doors", "EndPoint_PointId", "dbo.Points");
            DropForeignKey("dbo.Doors", "Architect_ArchitectId", "dbo.Architectes");
            DropForeignKey("dbo.Grids", "Client_ClientId", "dbo.Clients");
            DropForeignKey("dbo.GeneratedWindows", "Architect_ArchitectId", "dbo.Architectes");
            DropForeignKey("dbo.GeneratedDoors", "Architect_ArchitectId", "dbo.Architectes");
            DropIndex("dbo.Signatures", new[] { "Grid_GridId" });
            DropIndex("dbo.Signatures", new[] { "Architect_ArchitectId" });
            DropIndex("dbo.Windows", new[] { "StartPoint_PointId" });
            DropIndex("dbo.Windows", new[] { "PriceAndCost_PriceAndCostId" });
            DropIndex("dbo.Windows", new[] { "Grid_GridId" });
            DropIndex("dbo.Windows", new[] { "EndPoint_PointId" });
            DropIndex("dbo.Windows", new[] { "Architect_ArchitectId" });
            DropIndex("dbo.WallBeams", new[] { "UbicationPoint_PointId" });
            DropIndex("dbo.WallBeams", new[] { "PriceAndCost_PriceAndCostId" });
            DropIndex("dbo.WallBeams", new[] { "Grid_GridId" });
            DropIndex("dbo.Walls", new[] { "startUbicationPoint_PointId" });
            DropIndex("dbo.Walls", new[] { "PriceAndCost_PriceAndCostId" });
            DropIndex("dbo.Walls", new[] { "Grid_GridId" });
            DropIndex("dbo.Walls", new[] { "endUbicationPoint_PointId" });
            DropIndex("dbo.Points", new[] { "Wall_WallId" });
            DropIndex("dbo.Doors", new[] { "StartPoint_PointId" });
            DropIndex("dbo.Doors", new[] { "PriceAndCost_PriceAndCostId" });
            DropIndex("dbo.Doors", new[] { "Grid_GridId" });
            DropIndex("dbo.Doors", new[] { "EndPoint_PointId" });
            DropIndex("dbo.Doors", new[] { "Architect_ArchitectId" });
            DropIndex("dbo.Grids", new[] { "Client_ClientId" });
            DropIndex("dbo.DecorativeColumns", new[] { "UbicationPoint_PointId" });
            DropIndex("dbo.DecorativeColumns", new[] { "PriceAndCost_PriceAndCostId" });
            DropIndex("dbo.DecorativeColumns", new[] { "Grid_GridId" });
            DropIndex("dbo.GeneratedWindows", new[] { "Architect_ArchitectId" });
            DropIndex("dbo.GeneratedDoors", new[] { "Architect_ArchitectId" });
            DropTable("dbo.Designers");
            DropTable("dbo.Signatures");
            DropTable("dbo.Windows");
            DropTable("dbo.WallBeams");
            DropTable("dbo.Walls");
            DropTable("dbo.PricesAndCosts");
            DropTable("dbo.Points");
            DropTable("dbo.Doors");
            DropTable("dbo.Grids");
            DropTable("dbo.DecorativeColumns");
            DropTable("dbo.Clients");
            DropTable("dbo.GeneratedWindows");
            DropTable("dbo.GeneratedDoors");
            DropTable("dbo.Architectes");
            DropTable("dbo.Administrators");
        }
    }
}
