namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryMedicine_FKFixedV33 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StockMedicines", "CategoryId", "dbo.Categories");
            DropIndex("dbo.StockMedicines", new[] { "CategoryId" });
            AddColumn("dbo.Medicines", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Medicines", "CategoryId");
            AddForeignKey("dbo.Medicines", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
            DropColumn("dbo.StockMedicines", "CategoryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StockMedicines", "CategoryId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Medicines", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Medicines", new[] { "CategoryId" });
            DropColumn("dbo.Medicines", "CategoryId");
            CreateIndex("dbo.StockMedicines", "CategoryId");
            AddForeignKey("dbo.StockMedicines", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
        }
    }
}
