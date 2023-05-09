namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class T : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PurchaseMedicines", "DistributorId", "dbo.DistributorCompanies");
            DropIndex("dbo.PurchaseMedicines", new[] { "DistributorId" });
            AddColumn("dbo.Medicines", "DistributorId", c => c.Int(nullable: false));
            CreateIndex("dbo.Medicines", "DistributorId");
            AddForeignKey("dbo.Medicines", "DistributorId", "dbo.DistributorCompanies", "Id", cascadeDelete: true);
            DropColumn("dbo.PurchaseMedicines", "DistributorId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PurchaseMedicines", "DistributorId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Medicines", "DistributorId", "dbo.DistributorCompanies");
            DropIndex("dbo.Medicines", new[] { "DistributorId" });
            DropColumn("dbo.Medicines", "DistributorId");
            CreateIndex("dbo.PurchaseMedicines", "DistributorId");
            AddForeignKey("dbo.PurchaseMedicines", "DistributorId", "dbo.DistributorCompanies", "Id", cascadeDelete: true);
        }
    }
}
