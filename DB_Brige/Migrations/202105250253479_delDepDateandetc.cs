namespace Viewer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class delDepDateandetc : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Routes", "Price", c => c.Int(nullable: false));
            AlterColumn("dbo.Tickets", "Price", c => c.Int(nullable: false));
            DropColumn("dbo.Trips", "DepartureDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Trips", "DepartureDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Tickets", "Price", c => c.Double(nullable: false));
            AlterColumn("dbo.Routes", "Price", c => c.Double(nullable: false));
        }
    }
}
