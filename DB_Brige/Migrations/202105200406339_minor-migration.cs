namespace Viewer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class minormigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TimeTables", "WeekTable", c => c.String());
            DropColumn("dbo.TimeTables", "WeakTable");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TimeTables", "WeakTable", c => c.String());
            DropColumn("dbo.TimeTables", "WeekTable");
        }
    }
}
