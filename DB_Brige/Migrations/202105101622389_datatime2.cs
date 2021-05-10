namespace DB_Brige.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datatime2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tickets", "DepartureTime", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.TimeTables", "DepartureTime", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TimeTables", "DepartureTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Tickets", "DepartureTime", c => c.DateTime(nullable: false));
        }
    }
}
