namespace BethanyPieShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditingImagecolumn : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProductDetails", "Image", c => c.Binary());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProductDetails", "Image", c => c.Binary(nullable: false));
        }
    }
}
