namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StockTableAdded_FKFixedV32 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderDetails", "MedId", "dbo.Medicines");
            DropForeignKey("dbo.OrderDetails", "StockMedicine_Id", "dbo.StockMedicines");
            DropIndex("dbo.OrderDetails", new[] { "MedId" });
            DropIndex("dbo.OrderDetails", new[] { "StockMedicine_Id" });
            RenameColumn(table: "dbo.OrderDetails", name: "StockMedicine_Id", newName: "StockId");
            AlterColumn("dbo.OrderDetails", "StockId", c => c.Int(nullable: false));
            CreateIndex("dbo.OrderDetails", "StockId");
            AddForeignKey("dbo.OrderDetails", "StockId", "dbo.StockMedicines", "Id", cascadeDelete: true);
            DropColumn("dbo.OrderDetails", "MedId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderDetails", "MedId", c => c.Int(nullable: false));
            DropForeignKey("dbo.OrderDetails", "StockId", "dbo.StockMedicines");
            DropIndex("dbo.OrderDetails", new[] { "StockId" });
            AlterColumn("dbo.OrderDetails", "StockId", c => c.Int());
            RenameColumn(table: "dbo.OrderDetails", name: "StockId", newName: "StockMedicine_Id");
            CreateIndex("dbo.OrderDetails", "StockMedicine_Id");
            CreateIndex("dbo.OrderDetails", "MedId");
            AddForeignKey("dbo.OrderDetails", "StockMedicine_Id", "dbo.StockMedicines", "Id");
            AddForeignKey("dbo.OrderDetails", "MedId", "dbo.Medicines", "Id", cascadeDelete: true);
        }
    }
}
