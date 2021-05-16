namespace Viewer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
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
            
            AddColumn("dbo.Tickets", "LastName", c => c.String());
            AddColumn("dbo.Tickets", "Price", c => c.Double(nullable: false));
            DropColumn("dbo.Tickets", "SecondName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tickets", "SecondName", c => c.String());
            DropColumn("dbo.Tickets", "Price");
            DropColumn("dbo.Tickets", "LastName");
            DropTable("dbo.People");
        }
    }
}
