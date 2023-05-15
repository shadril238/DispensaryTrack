namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StockTableAdded_FKFixedV31 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Medicines", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Medicines", "DistributorCompany_Id", "dbo.DistributorCompanies");
            DropForeignKey("dbo.Medicines", "PurchaseMedicine_Id", "dbo.PurchaseMedicines");
            DropForeignKey("dbo.Medicines", "Rack_Id", "dbo.Racks");
            DropIndex("dbo.Medicines", new[] { "Category_Id" });
            DropIndex("dbo.Medicines", new[] { "DistributorCompany_Id" });
            DropIndex("dbo.Medicines", new[] { "PurchaseMedicine_Id" });
            DropIndex("dbo.Medicines", new[] { "Rack_Id" });
            DropColumn("dbo.Medicines", "Category_Id");
            DropColumn("dbo.Medicines", "DistributorCompany_Id");
            DropColumn("dbo.Medicines", "PurchaseMedicine_Id");
            DropColumn("dbo.Medicines", "Rack_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Medicines", "Rack_Id", c => c.Int());
            AddColumn("dbo.Medicines", "PurchaseMedicine_Id", c => c.Int());
            AddColumn("dbo.Medicines", "DistributorCompany_Id", c => c.Int());
            AddColumn("dbo.Medicines", "Category_Id", c => c.Int());
            CreateIndex("dbo.Medicines", "Rack_Id");
            CreateIndex("dbo.Medicines", "PurchaseMedicine_Id");
            CreateIndex("dbo.Medicines", "DistributorCompany_Id");
            CreateIndex("dbo.Medicines", "Category_Id");
            AddForeignKey("dbo.Medicines", "Rack_Id", "dbo.Racks", "Id");
            AddForeignKey("dbo.Medicines", "PurchaseMedicine_Id", "dbo.PurchaseMedicines", "Id");
            AddForeignKey("dbo.Medicines", "DistributorCompany_Id", "dbo.DistributorCompanies", "Id");
            AddForeignKey("dbo.Medicines", "Category_Id", "dbo.Categories", "Id");
        }
    }
}
