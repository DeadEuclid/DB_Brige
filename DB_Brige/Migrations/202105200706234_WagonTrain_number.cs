namespace Viewer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WagonTrain_number : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trains", "Number", c => c.Int(nullable: false));
            AddColumn("dbo.Wagons", "Number", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Wagons", "Number");
            DropColumn("dbo.Trains", "Number");
        }
    }
}
