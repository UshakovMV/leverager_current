namespace Leverager_projects.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        SKU = c.Int(nullable: false),
                        ProductName = c.String(),
                        ProductDescriptions = c.String(),
                        CategoryID = c.Int(nullable: false),
                        SupplierID = c.Int(nullable: false),
                        QuantityPerUnit = c.Int(nullable: false),
                        UnitPrice = c.Int(nullable: false),
                        MSRP = c.Int(nullable: false),
                        AvailableSize = c.Int(nullable: false),
                        AvailableColors = c.Int(nullable: false),
                        Size = c.String(),
                        Colors = c.String(),
                        Discount = c.Int(nullable: false),
                        UnitWeight = c.Single(nullable: false),
                        PictureUrl = c.String(),
                        Ranking = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
