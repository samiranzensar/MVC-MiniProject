namespace BethanyPieShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removingrequiredfromproductname : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProductDetails", "ProductName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProductDetails", "ProductName", c => c.String(nullable: false));
        }
    }
}
