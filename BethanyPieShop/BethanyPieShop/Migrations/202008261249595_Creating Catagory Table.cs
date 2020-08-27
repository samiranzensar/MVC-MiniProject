namespace BethanyPieShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatingCatagoryTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Catagories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PieType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.ProductDetails", "CatagoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.ProductDetails", "CatagoryId");
            AddForeignKey("dbo.ProductDetails", "CatagoryId", "dbo.Catagories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductDetails", "CatagoryId", "dbo.Catagories");
            DropIndex("dbo.ProductDetails", new[] { "CatagoryId" });
            DropColumn("dbo.ProductDetails", "CatagoryId");
            DropTable("dbo.Catagories");
        }
    }
}
