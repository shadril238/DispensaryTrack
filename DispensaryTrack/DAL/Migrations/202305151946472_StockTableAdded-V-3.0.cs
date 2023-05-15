namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StockTableAddedV30 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Medicines", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Medicines", "DistributorId", "dbo.DistributorCompanies");
            DropForeignKey("dbo.Medicines", "PurchaseId", "dbo.PurchaseMedicines");
            DropForeignKey("dbo.Medicines", "RackId", "dbo.Racks");
            DropIndex("dbo.Medicines", new[] { "CategoryId" });
            DropIndex("dbo.Medicines", new[] { "PurchaseId" });
            DropIndex("dbo.Medicines", new[] { "RackId" });
            DropIndex("dbo.Medicines", new[] { "DistributorId" });
            RenameColumn(table: "dbo.Medicines", name: "CategoryId", newName: "Category_Id");
            RenameColumn(table: "dbo.Medicines", name: "DistributorId", newName: "DistributorCompany_Id");
            RenameColumn(table: "dbo.Medicines", name: "PurchaseId", newName: "PurchaseMedicine_Id");
            RenameColumn(table: "dbo.Medicines", name: "RackId", newName: "Rack_Id");
            CreateTable(
                "dbo.StockMedicines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MedicineId = c.Int(nullable: false),
                        BuyPrice = c.Single(nullable: false),
                        SalePrice = c.Single(nullable: false),
                        TotalStock = c.Int(nullable: false),
                        ExpireDate = c.DateTime(nullable: false),
                        Status = c.String(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        PurchaseId = c.Int(nullable: false),
                        RackId = c.Int(nullable: false),
                        DistributorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.DistributorCompanies", t => t.DistributorId, cascadeDelete: true)
                .ForeignKey("dbo.Medicines", t => t.MedicineId, cascadeDelete: true)
                .ForeignKey("dbo.PurchaseMedicines", t => t.PurchaseId, cascadeDelete: true)
                .ForeignKey("dbo.Racks", t => t.RackId, cascadeDelete: true)
                .Index(t => t.MedicineId)
                .Index(t => t.CategoryId)
                .Index(t => t.PurchaseId)
                .Index(t => t.RackId)
                .Index(t => t.DistributorId);
            
            AddColumn("dbo.OrderDetails", "StockMedicine_Id", c => c.Int());
            AlterColumn("dbo.Medicines", "Category_Id", c => c.Int());
            AlterColumn("dbo.Medicines", "PurchaseMedicine_Id", c => c.Int());
            AlterColumn("dbo.Medicines", "Rack_Id", c => c.Int());
            AlterColumn("dbo.Medicines", "DistributorCompany_Id", c => c.Int());
            CreateIndex("dbo.OrderDetails", "StockMedicine_Id");
            CreateIndex("dbo.Medicines", "Category_Id");
            CreateIndex("dbo.Medicines", "DistributorCompany_Id");
            CreateIndex("dbo.Medicines", "PurchaseMedicine_Id");
            CreateIndex("dbo.Medicines", "Rack_Id");
            AddForeignKey("dbo.OrderDetails", "StockMedicine_Id", "dbo.StockMedicines", "Id");
            AddForeignKey("dbo.Medicines", "Category_Id", "dbo.Categories", "Id");
            AddForeignKey("dbo.Medicines", "DistributorCompany_Id", "dbo.DistributorCompanies", "Id");
            AddForeignKey("dbo.Medicines", "PurchaseMedicine_Id", "dbo.PurchaseMedicines", "Id");
            AddForeignKey("dbo.Medicines", "Rack_Id", "dbo.Racks", "Id");
            DropColumn("dbo.Medicines", "BuyPrice");
            DropColumn("dbo.Medicines", "SalePrice");
            DropColumn("dbo.Medicines", "TotalStock");
            DropColumn("dbo.Medicines", "ExpireDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Medicines", "ExpireDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Medicines", "TotalStock", c => c.Int(nullable: false));
            AddColumn("dbo.Medicines", "SalePrice", c => c.Single(nullable: false));
            AddColumn("dbo.Medicines", "BuyPrice", c => c.Single(nullable: false));
            DropForeignKey("dbo.Medicines", "Rack_Id", "dbo.Racks");
            DropForeignKey("dbo.Medicines", "PurchaseMedicine_Id", "dbo.PurchaseMedicines");
            DropForeignKey("dbo.Medicines", "DistributorCompany_Id", "dbo.DistributorCompanies");
            DropForeignKey("dbo.Medicines", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.StockMedicines", "RackId", "dbo.Racks");
            DropForeignKey("dbo.StockMedicines", "PurchaseId", "dbo.PurchaseMedicines");
            DropForeignKey("dbo.OrderDetails", "StockMedicine_Id", "dbo.StockMedicines");
            DropForeignKey("dbo.StockMedicines", "MedicineId", "dbo.Medicines");
            DropForeignKey("dbo.StockMedicines", "DistributorId", "dbo.DistributorCompanies");
            DropForeignKey("dbo.StockMedicines", "CategoryId", "dbo.Categories");
            DropIndex("dbo.StockMedicines", new[] { "DistributorId" });
            DropIndex("dbo.StockMedicines", new[] { "RackId" });
            DropIndex("dbo.StockMedicines", new[] { "PurchaseId" });
            DropIndex("dbo.StockMedicines", new[] { "CategoryId" });
            DropIndex("dbo.StockMedicines", new[] { "MedicineId" });
            DropIndex("dbo.Medicines", new[] { "Rack_Id" });
            DropIndex("dbo.Medicines", new[] { "PurchaseMedicine_Id" });
            DropIndex("dbo.Medicines", new[] { "DistributorCompany_Id" });
            DropIndex("dbo.Medicines", new[] { "Category_Id" });
            DropIndex("dbo.OrderDetails", new[] { "StockMedicine_Id" });
            AlterColumn("dbo.Medicines", "DistributorCompany_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Medicines", "Rack_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Medicines", "PurchaseMedicine_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Medicines", "Category_Id", c => c.Int(nullable: false));
            DropColumn("dbo.OrderDetails", "StockMedicine_Id");
            DropTable("dbo.StockMedicines");
            RenameColumn(table: "dbo.Medicines", name: "Rack_Id", newName: "RackId");
            RenameColumn(table: "dbo.Medicines", name: "PurchaseMedicine_Id", newName: "PurchaseId");
            RenameColumn(table: "dbo.Medicines", name: "DistributorCompany_Id", newName: "DistributorId");
            RenameColumn(table: "dbo.Medicines", name: "Category_Id", newName: "CategoryId");
            CreateIndex("dbo.Medicines", "DistributorId");
            CreateIndex("dbo.Medicines", "RackId");
            CreateIndex("dbo.Medicines", "PurchaseId");
            CreateIndex("dbo.Medicines", "CategoryId");
            AddForeignKey("dbo.Medicines", "RackId", "dbo.Racks", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Medicines", "PurchaseId", "dbo.PurchaseMedicines", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Medicines", "DistributorId", "dbo.DistributorCompanies", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Medicines", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
        }
    }
}
