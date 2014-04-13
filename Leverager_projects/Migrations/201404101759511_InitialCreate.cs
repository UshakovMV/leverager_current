namespace Leverager_projects.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Descriptions = c.String(),
                        Active = c.Boolean(nullable: false),
                        Master = c.Boolean(nullable: false),
                        ParentID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);

            AddColumn("dbo.AspNetUsers", "Email", c => c.String());
            
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Email");
            DropTable("dbo.Categories");
        }
    }
}
