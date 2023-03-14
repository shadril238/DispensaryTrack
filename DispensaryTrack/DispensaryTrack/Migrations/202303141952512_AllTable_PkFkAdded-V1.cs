namespace DispensaryTrack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllTable_PkFkAddedV1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Medicines", "DistId", "dbo.DistributorCompanies");
            DropIndex("dbo.Medicines", new[] { "DistId" });
            CreateTable(
                "dbo.PurchaseMedicines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TotalPrice = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                        DistributorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DistributorCompanies", t => t.DistributorId, cascadeDelete: true)
                .Index(t => t.DistributorId);
            
            AddColumn("dbo.Medicines", "PurchaseId", c => c.Int(nullable: false));
            CreateIndex("dbo.Medicines", "PurchaseId");
            AddForeignKey("dbo.Medicines", "PurchaseId", "dbo.PurchaseMedicines", "Id", cascadeDelete: true);
            DropColumn("dbo.Medicines", "DistId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Medicines", "DistId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Medicines", "PurchaseId", "dbo.PurchaseMedicines");
            DropForeignKey("dbo.PurchaseMedicines", "DistributorId", "dbo.DistributorCompanies");
            DropIndex("dbo.PurchaseMedicines", new[] { "DistributorId" });
            DropIndex("dbo.Medicines", new[] { "PurchaseId" });
            DropColumn("dbo.Medicines", "PurchaseId");
            DropTable("dbo.PurchaseMedicines");
            CreateIndex("dbo.Medicines", "DistId");
            AddForeignKey("dbo.Medicines", "DistId", "dbo.DistributorCompanies", "Id", cascadeDelete: true);
        }
    }
}
