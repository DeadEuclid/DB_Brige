namespace Viewer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MtoMforStationsRoutesAndLittleFix : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        MiddleName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Routes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Stations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartureTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        PalesNum = c.Int(nullable: false),
                        PassportSeries = c.Int(nullable: false),
                        PassportNum = c.Int(nullable: false),
                        LastName = c.String(),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        ExemType = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Departure_Id = c.Int(),
                        Destination_Id = c.Int(),
                        Trip_Id = c.Int(),
                        Wagon_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stations", t => t.Departure_Id)
                .ForeignKey("dbo.Stations", t => t.Destination_Id)
                .ForeignKey("dbo.Trips", t => t.Trip_Id)
                .ForeignKey("dbo.Wagons", t => t.Wagon_Id)
                .Index(t => t.Departure_Id)
                .Index(t => t.Destination_Id)
                .Index(t => t.Trip_Id)
                .Index(t => t.Wagon_Id);
            
            CreateTable(
                "dbo.Trips",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartureDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        TimeTable_Id = c.Int(),
                        Train_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TimeTables", t => t.TimeTable_Id)
                .ForeignKey("dbo.Trains", t => t.Train_Id)
                .Index(t => t.TimeTable_Id)
                .Index(t => t.Train_Id);
            
            CreateTable(
                "dbo.TimeTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartureTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        WeakTable = c.String(),
                        Route_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Routes", t => t.Route_Id)
                .Index(t => t.Route_Id);
            
            CreateTable(
                "dbo.Trains",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Wagons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SeatsCount = c.Int(nullable: false),
                        WagonClass = c.Int(nullable: false),
                        Train_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Trains", t => t.Train_Id)
                .Index(t => t.Train_Id);
            
            CreateTable(
                "dbo.StationRoutes",
                c => new
                    {
                        Station_Id = c.Int(nullable: false),
                        Route_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Station_Id, t.Route_Id })
                .ForeignKey("dbo.Stations", t => t.Station_Id, cascadeDelete: true)
                .ForeignKey("dbo.Routes", t => t.Route_Id, cascadeDelete: true)
                .Index(t => t.Station_Id)
                .Index(t => t.Route_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "Wagon_Id", "dbo.Wagons");
            DropForeignKey("dbo.Tickets", "Trip_Id", "dbo.Trips");
            DropForeignKey("dbo.Trips", "Train_Id", "dbo.Trains");
            DropForeignKey("dbo.Wagons", "Train_Id", "dbo.Trains");
            DropForeignKey("dbo.Trips", "TimeTable_Id", "dbo.TimeTables");
            DropForeignKey("dbo.TimeTables", "Route_Id", "dbo.Routes");
            DropForeignKey("dbo.Tickets", "Destination_Id", "dbo.Stations");
            DropForeignKey("dbo.Tickets", "Departure_Id", "dbo.Stations");
            DropForeignKey("dbo.StationRoutes", "Route_Id", "dbo.Routes");
            DropForeignKey("dbo.StationRoutes", "Station_Id", "dbo.Stations");
            DropIndex("dbo.StationRoutes", new[] { "Route_Id" });
            DropIndex("dbo.StationRoutes", new[] { "Station_Id" });
            DropIndex("dbo.Wagons", new[] { "Train_Id" });
            DropIndex("dbo.TimeTables", new[] { "Route_Id" });
            DropIndex("dbo.Trips", new[] { "Train_Id" });
            DropIndex("dbo.Trips", new[] { "TimeTable_Id" });
            DropIndex("dbo.Tickets", new[] { "Wagon_Id" });
            DropIndex("dbo.Tickets", new[] { "Trip_Id" });
            DropIndex("dbo.Tickets", new[] { "Destination_Id" });
            DropIndex("dbo.Tickets", new[] { "Departure_Id" });
            DropTable("dbo.StationRoutes");
            DropTable("dbo.Wagons");
            DropTable("dbo.Trains");
            DropTable("dbo.TimeTables");
            DropTable("dbo.Trips");
            DropTable("dbo.Tickets");
            DropTable("dbo.Stations");
            DropTable("dbo.Routes");
            DropTable("dbo.People");
        }
    }
}
