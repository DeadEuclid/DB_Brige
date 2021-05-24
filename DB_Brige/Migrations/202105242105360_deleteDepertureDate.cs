namespace Viewer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteDepertureDate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tickets", "DepartureTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TimeTables", "DepartureTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Trips", "DepartureDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Trips", "DepartureDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.TimeTables", "DepartureTime", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Tickets", "DepartureTime", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
    }
}
