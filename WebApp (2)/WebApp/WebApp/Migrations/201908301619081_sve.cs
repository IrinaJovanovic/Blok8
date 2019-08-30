namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sve : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LineType = c.Int(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Version = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Stations",
                c => new
                    {
                        StationNum = c.Int(nullable: false, identity: true),
                        LocationId = c.Int(nullable: false),
                        Name = c.String(),
                        Address = c.String(),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Version = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.StationNum)
                .ForeignKey("dbo.Locations", t => t.LocationId, cascadeDelete: true)
                .Index(t => t.LocationId);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Lon = c.Double(nullable: false),
                        Lat = c.Double(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PassengerTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Coefficient = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PayPals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PayementId = c.String(),
                        CreateTime = c.DateTime(),
                        PayerEmail = c.String(),
                        PayerName = c.String(),
                        PayerSurname = c.String(),
                        CurrencyCode = c.String(),
                        Value = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pictures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImageSource = c.Binary(),
                        AppUserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.AppUserId)
                .Index(t => t.AppUserId);
            
            CreateTable(
                "dbo.Pricelists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartOfValidity = c.DateTime(),
                        EndOfValidity = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TicketPrices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Double(nullable: false),
                        Version = c.Int(nullable: false),
                        PricelistId = c.Int(nullable: false),
                        TicketTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pricelists", t => t.PricelistId, cascadeDelete: true)
                .ForeignKey("dbo.TicketTypes", t => t.TicketTypeId, cascadeDelete: true)
                .Index(t => t.PricelistId)
                .Index(t => t.TicketTypeId);
            
            CreateTable(
                "dbo.TicketTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SerialNumberSLs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SerialNumber = c.Int(nullable: false),
                        LineId = c.Int(nullable: false),
                        StationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lines", t => t.LineId, cascadeDelete: true)
                .ForeignKey("dbo.Stations", t => t.StationId, cascadeDelete: true)
                .Index(t => t.LineId)
                .Index(t => t.StationId);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Double(nullable: false),
                        RemainingTime = c.Time(nullable: false, precision: 7),
                        Checked = c.Boolean(nullable: false),
                        CheckedTime = c.String(),
                        UserId = c.String(maxLength: 128),
                        Type_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TicketTypes", t => t.Type_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.Type_Id);
            
            CreateTable(
                "dbo.Timetables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Departures = c.String(),
                        Version = c.Int(nullable: false),
                        LineId = c.Int(nullable: false),
                        DayTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DayTypes", t => t.DayTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Lines", t => t.LineId, cascadeDelete: true)
                .Index(t => t.LineId)
                .Index(t => t.DayTypeId);
            
            CreateTable(
                "dbo.DayTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StationLines",
                c => new
                    {
                        Station_StationNum = c.Int(nullable: false),
                        Line_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Station_StationNum, t.Line_Id })
                .ForeignKey("dbo.Stations", t => t.Station_StationNum, cascadeDelete: true)
                .ForeignKey("dbo.Lines", t => t.Line_Id, cascadeDelete: true)
                .Index(t => t.Station_StationNum)
                .Index(t => t.Line_Id);
            
            CreateTable(
                "dbo.VehicleTimetables",
                c => new
                    {
                        Vehicle_Id = c.Int(nullable: false),
                        Timetable_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Vehicle_Id, t.Timetable_Id })
                .ForeignKey("dbo.Vehicles", t => t.Vehicle_Id, cascadeDelete: true)
                .ForeignKey("dbo.Timetables", t => t.Timetable_Id, cascadeDelete: true)
                .Index(t => t.Vehicle_Id)
                .Index(t => t.Timetable_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VehicleTimetables", "Timetable_Id", "dbo.Timetables");
            DropForeignKey("dbo.VehicleTimetables", "Vehicle_Id", "dbo.Vehicles");
            DropForeignKey("dbo.Timetables", "LineId", "dbo.Lines");
            DropForeignKey("dbo.Timetables", "DayTypeId", "dbo.DayTypes");
            DropForeignKey("dbo.Tickets", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Tickets", "Type_Id", "dbo.TicketTypes");
            DropForeignKey("dbo.SerialNumberSLs", "StationId", "dbo.Stations");
            DropForeignKey("dbo.SerialNumberSLs", "LineId", "dbo.Lines");
            DropForeignKey("dbo.TicketPrices", "TicketTypeId", "dbo.TicketTypes");
            DropForeignKey("dbo.TicketPrices", "PricelistId", "dbo.Pricelists");
            DropForeignKey("dbo.Pictures", "AppUserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Stations", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.StationLines", "Line_Id", "dbo.Lines");
            DropForeignKey("dbo.StationLines", "Station_StationNum", "dbo.Stations");
            DropIndex("dbo.VehicleTimetables", new[] { "Timetable_Id" });
            DropIndex("dbo.VehicleTimetables", new[] { "Vehicle_Id" });
            DropIndex("dbo.StationLines", new[] { "Line_Id" });
            DropIndex("dbo.StationLines", new[] { "Station_StationNum" });
            DropIndex("dbo.Timetables", new[] { "DayTypeId" });
            DropIndex("dbo.Timetables", new[] { "LineId" });
            DropIndex("dbo.Tickets", new[] { "Type_Id" });
            DropIndex("dbo.Tickets", new[] { "UserId" });
            DropIndex("dbo.SerialNumberSLs", new[] { "StationId" });
            DropIndex("dbo.SerialNumberSLs", new[] { "LineId" });
            DropIndex("dbo.TicketPrices", new[] { "TicketTypeId" });
            DropIndex("dbo.TicketPrices", new[] { "PricelistId" });
            DropIndex("dbo.Pictures", new[] { "AppUserId" });
            DropIndex("dbo.Stations", new[] { "LocationId" });
            DropTable("dbo.VehicleTimetables");
            DropTable("dbo.StationLines");
            DropTable("dbo.Vehicles");
            DropTable("dbo.DayTypes");
            DropTable("dbo.Timetables");
            DropTable("dbo.Tickets");
            DropTable("dbo.SerialNumberSLs");
            DropTable("dbo.TicketTypes");
            DropTable("dbo.TicketPrices");
            DropTable("dbo.Pricelists");
            DropTable("dbo.Pictures");
            DropTable("dbo.PayPals");
            DropTable("dbo.PassengerTypes");
            DropTable("dbo.Locations");
            DropTable("dbo.Stations");
            DropTable("dbo.Lines");
        }
    }
}
