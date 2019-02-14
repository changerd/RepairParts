namespace RepairParts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ArrivalDocs",
                c => new
                    {
                        ArrivalDocId = c.Int(nullable: false, identity: true),
                        ArrivalDocName = c.String(),
                        ArrivalDocProvider = c.String(),
                        ArrivalDocDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ArrivalDocId);
            
            CreateTable(
                "dbo.Arrivals",
                c => new
                    {
                        ArrivalId = c.Int(nullable: false, identity: true),
                        ArrivalQuantity = c.Int(nullable: false),
                        ArrivalCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ArrivalSum = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PartId = c.Int(nullable: false),
                        ArrivalDocId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ArrivalId)
                .ForeignKey("dbo.ArrivalDocs", t => t.ArrivalDocId, cascadeDelete: true)
                .ForeignKey("dbo.Parts", t => t.PartId, cascadeDelete: true)
                .Index(t => t.PartId)
                .Index(t => t.ArrivalDocId);
            
            CreateTable(
                "dbo.Parts",
                c => new
                    {
                        PartId = c.Int(nullable: false, identity: true),
                        PartName = c.String(),
                        PartUnit = c.String(),
                    })
                .PrimaryKey(t => t.PartId);
            
            CreateTable(
                "dbo.Departures",
                c => new
                    {
                        DepartureId = c.Int(nullable: false, identity: true),
                        DepartureQuantity = c.Int(nullable: false),
                        PartId = c.Int(nullable: false),
                        DepartureDocId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DepartureId)
                .ForeignKey("dbo.DepartureDocs", t => t.DepartureDocId, cascadeDelete: true)
                .ForeignKey("dbo.Parts", t => t.PartId, cascadeDelete: true)
                .Index(t => t.PartId)
                .Index(t => t.DepartureDocId);
            
            CreateTable(
                "dbo.DepartureDocs",
                c => new
                    {
                        DepartureDocId = c.Int(nullable: false, identity: true),
                        DepartureDocName = c.String(),
                        DepartureDocSender = c.String(),
                        DepartureDocRecipient = c.String(),
                        DepartureDocDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.DepartureDocId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Departures", "PartId", "dbo.Parts");
            DropForeignKey("dbo.Departures", "DepartureDocId", "dbo.DepartureDocs");
            DropForeignKey("dbo.Arrivals", "PartId", "dbo.Parts");
            DropForeignKey("dbo.Arrivals", "ArrivalDocId", "dbo.ArrivalDocs");
            DropIndex("dbo.Departures", new[] { "DepartureDocId" });
            DropIndex("dbo.Departures", new[] { "PartId" });
            DropIndex("dbo.Arrivals", new[] { "ArrivalDocId" });
            DropIndex("dbo.Arrivals", new[] { "PartId" });
            DropTable("dbo.DepartureDocs");
            DropTable("dbo.Departures");
            DropTable("dbo.Parts");
            DropTable("dbo.Arrivals");
            DropTable("dbo.ArrivalDocs");
        }
    }
}
