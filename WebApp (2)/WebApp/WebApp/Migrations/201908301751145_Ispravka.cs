namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ispravka : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TicketPrices", "PricelistId", "dbo.Pricelists");
            DropForeignKey("dbo.TicketPrices", "TicketTypeId", "dbo.TicketTypes");
            DropForeignKey("dbo.SerialNumberSLs", "LineId", "dbo.Lines");
            DropForeignKey("dbo.SerialNumberSLs", "StationId", "dbo.Stations");
            DropForeignKey("dbo.Tickets", "Type_Id", "dbo.TicketTypes");
            DropForeignKey("dbo.Timetables", "DayTypeId", "dbo.DayTypes");
            DropForeignKey("dbo.Timetables", "LineId", "dbo.Lines");
            DropForeignKey("dbo.VehicleTimetables", "Vehicle_Id", "dbo.Vehicles");
            DropForeignKey("dbo.VehicleTimetables", "Timetable_Id", "dbo.Timetables");
            DropIndex("dbo.TicketPrices", new[] { "PricelistId" });
            DropIndex("dbo.TicketPrices", new[] { "TicketTypeId" });
            DropIndex("dbo.SerialNumberSLs", new[] { "LineId" });
            DropIndex("dbo.SerialNumberSLs", new[] { "StationId" });
            DropIndex("dbo.Tickets", new[] { "Type_Id" });
            DropIndex("dbo.Timetables", new[] { "LineId" });
            DropIndex("dbo.Timetables", new[] { "DayTypeId" });
            DropIndex("dbo.VehicleTimetables", new[] { "Vehicle_Id" });
            DropIndex("dbo.VehicleTimetables", new[] { "Timetable_Id" });
            CreateTable(
                "dbo.Depatures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepatureTime = c.String(),
                        ScheduleId = c.Int(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Schedules", t => t.ScheduleId, cascadeDelete: true)
                .Index(t => t.ScheduleId);
            
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Day = c.Int(nullable: false),
                        LineId = c.Int(nullable: false),
                        Duration = c.Time(nullable: false, precision: 7),
                        Version = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lines", t => t.LineId, cascadeDelete: true)
                .Index(t => t.LineId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        AppUserId = c.String(maxLength: 128),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        UserType = c.Int(nullable: false),
                        Approved = c.Boolean(nullable: false),
                        Checked = c.Boolean(nullable: false),
                        postedImage = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.AspNetUsers", t => t.AppUserId)
                .Index(t => t.AppUserId);
            
            CreateTable(
                "dbo.Discounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        Discount = c.Double(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Version = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.PayPals", "TransactionId", c => c.String());
            AddColumn("dbo.PayPals", "TicketId", c => c.Int(nullable: false));
            AddColumn("dbo.PayPals", "PayerId", c => c.String());
            AddColumn("dbo.PayPals", "UpdateTime", c => c.String());
            AddColumn("dbo.PayPals", "Status", c => c.String());
            AddColumn("dbo.Pricelists", "ticketType", c => c.Int(nullable: false));
            AddColumn("dbo.Pricelists", "price", c => c.Double(nullable: false));
            AddColumn("dbo.Pricelists", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Pricelists", "Version", c => c.Double(nullable: false));
            AddColumn("dbo.Tickets", "Type", c => c.Int(nullable: false));
            AlterColumn("dbo.PayPals", "CreateTime", c => c.String());
            DropColumn("dbo.PayPals", "PayementId");
            DropColumn("dbo.PayPals", "PayerName");
            DropColumn("dbo.PayPals", "PayerSurname");
            DropColumn("dbo.PayPals", "CurrencyCode");
            DropColumn("dbo.PayPals", "Value");
            DropColumn("dbo.Pricelists", "StartOfValidity");
            DropColumn("dbo.Pricelists", "EndOfValidity");
            DropColumn("dbo.Tickets", "Type_Id");
            DropTable("dbo.PassengerTypes");
            DropTable("dbo.TicketPrices");
            DropTable("dbo.TicketTypes");
            DropTable("dbo.SerialNumberSLs");
            DropTable("dbo.Timetables");
            DropTable("dbo.DayTypes");
            DropTable("dbo.Vehicles");
            DropTable("dbo.VehicleTimetables");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.VehicleTimetables",
                c => new
                    {
                        Vehicle_Id = c.Int(nullable: false),
                        Timetable_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Vehicle_Id, t.Timetable_Id });
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DayTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
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
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TicketTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
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
            
            AddColumn("dbo.Tickets", "Type_Id", c => c.Int());
            AddColumn("dbo.Pricelists", "EndOfValidity", c => c.DateTime());
            AddColumn("dbo.Pricelists", "StartOfValidity", c => c.DateTime());
            AddColumn("dbo.PayPals", "Value", c => c.Double(nullable: false));
            AddColumn("dbo.PayPals", "CurrencyCode", c => c.String());
            AddColumn("dbo.PayPals", "PayerSurname", c => c.String());
            AddColumn("dbo.PayPals", "PayerName", c => c.String());
            AddColumn("dbo.PayPals", "PayementId", c => c.String());
            DropForeignKey("dbo.Users", "AppUserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Depatures", "ScheduleId", "dbo.Schedules");
            DropForeignKey("dbo.Schedules", "LineId", "dbo.Lines");
            DropIndex("dbo.Users", new[] { "AppUserId" });
            DropIndex("dbo.Schedules", new[] { "LineId" });
            DropIndex("dbo.Depatures", new[] { "ScheduleId" });
            AlterColumn("dbo.PayPals", "CreateTime", c => c.DateTime());
            DropColumn("dbo.Tickets", "Type");
            DropColumn("dbo.Pricelists", "Version");
            DropColumn("dbo.Pricelists", "RowVersion");
            DropColumn("dbo.Pricelists", "price");
            DropColumn("dbo.Pricelists", "ticketType");
            DropColumn("dbo.PayPals", "Status");
            DropColumn("dbo.PayPals", "UpdateTime");
            DropColumn("dbo.PayPals", "PayerId");
            DropColumn("dbo.PayPals", "TicketId");
            DropColumn("dbo.PayPals", "TransactionId");
            DropTable("dbo.Discounts");
            DropTable("dbo.Users");
            DropTable("dbo.Schedules");
            DropTable("dbo.Depatures");
            CreateIndex("dbo.VehicleTimetables", "Timetable_Id");
            CreateIndex("dbo.VehicleTimetables", "Vehicle_Id");
            CreateIndex("dbo.Timetables", "DayTypeId");
            CreateIndex("dbo.Timetables", "LineId");
            CreateIndex("dbo.Tickets", "Type_Id");
            CreateIndex("dbo.SerialNumberSLs", "StationId");
            CreateIndex("dbo.SerialNumberSLs", "LineId");
            CreateIndex("dbo.TicketPrices", "TicketTypeId");
            CreateIndex("dbo.TicketPrices", "PricelistId");
            AddForeignKey("dbo.VehicleTimetables", "Timetable_Id", "dbo.Timetables", "Id", cascadeDelete: true);
            AddForeignKey("dbo.VehicleTimetables", "Vehicle_Id", "dbo.Vehicles", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Timetables", "LineId", "dbo.Lines", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Timetables", "DayTypeId", "dbo.DayTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Tickets", "Type_Id", "dbo.TicketTypes", "Id");
            AddForeignKey("dbo.SerialNumberSLs", "StationId", "dbo.Stations", "StationNum", cascadeDelete: true);
            AddForeignKey("dbo.SerialNumberSLs", "LineId", "dbo.Lines", "Id", cascadeDelete: true);
            AddForeignKey("dbo.TicketPrices", "TicketTypeId", "dbo.TicketTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.TicketPrices", "PricelistId", "dbo.Pricelists", "Id", cascadeDelete: true);
        }
    }
}
