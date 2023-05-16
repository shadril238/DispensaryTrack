namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StockTablePurchaseTable_PkFkFixed_1to1V34 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.PurchaseMedicines", name: "StockId", newName: "StockMedicineId");
            RenameIndex(table: "dbo.PurchaseMedicines", name: "IX_StockId", newName: "IX_StockMedicineId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.PurchaseMedicines", name: "IX_StockMedicineId", newName: "IX_StockId");
            RenameColumn(table: "dbo.PurchaseMedicines", name: "StockMedicineId", newName: "StockId");
        }
    }
}
