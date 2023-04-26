namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllTableDoneV10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PaidAmt = c.Double(nullable: false),
                        BillDate = c.DateTime(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Cid = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        Phone = c.String(nullable: false, maxLength: 11),
                        Balance = c.Double(nullable: false),
                        Gender = c.String(nullable: false),
                        Status = c.String(),
                        Address = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Cid);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TotalAmt = c.Double(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        Status = c.String(nullable: false),
                        EmpId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmpId, cascadeDelete: true)
                .Index(t => t.EmpId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        Phone = c.String(nullable: false, maxLength: 11),
                        Password = c.String(nullable: false, maxLength: 25),
                        JoinDate = c.DateTime(nullable: false),
                        EmpType = c.String(nullable: false),
                        Address = c.String(nullable: false, maxLength: 200),
                        Status = c.String(nullable: false),
                        Salary = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UnitPrice = c.Double(nullable: false),
                        Qty = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                        MedId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Medicines", t => t.MedId, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.MedId);
            
            CreateTable(
                "dbo.Medicines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        GenericName = c.String(nullable: false, maxLength: 100),
                        BuyPrice = c.Single(nullable: false),
                        SalePrice = c.Single(nullable: false),
                        TotalStock = c.Int(nullable: false),
                        ExpireDate = c.DateTime(nullable: false),
                        Status = c.String(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        PurchaseId = c.Int(nullable: false),
                        RackId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.PurchaseMedicines", t => t.PurchaseId, cascadeDelete: true)
                .ForeignKey("dbo.Racks", t => t.RackId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.PurchaseId)
                .Index(t => t.RackId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Description = c.String(nullable: false, maxLength: 200),
                        Status = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
            
            CreateTable(
                "dbo.DistributorCompanies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DistName = c.String(nullable: false, maxLength: 100),
                        CompName = c.String(nullable: false, maxLength: 100),
                        Phone = c.String(nullable: false, maxLength: 11),
                        Email = c.String(nullable: false, maxLength: 100),
                        Address = c.String(nullable: false, maxLength: 200),
                        Status = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Racks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Status = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bills", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderDetails", "MedId", "dbo.Medicines");
            DropForeignKey("dbo.Medicines", "RackId", "dbo.Racks");
            DropForeignKey("dbo.Medicines", "PurchaseId", "dbo.PurchaseMedicines");
            DropForeignKey("dbo.PurchaseMedicines", "DistributorId", "dbo.DistributorCompanies");
            DropForeignKey("dbo.Medicines", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Orders", "EmpId", "dbo.Employees");
            DropForeignKey("dbo.Bills", "CustomerId", "dbo.Customers");
            DropIndex("dbo.PurchaseMedicines", new[] { "DistributorId" });
            DropIndex("dbo.Medicines", new[] { "RackId" });
            DropIndex("dbo.Medicines", new[] { "PurchaseId" });
            DropIndex("dbo.Medicines", new[] { "CategoryId" });
            DropIndex("dbo.OrderDetails", new[] { "MedId" });
            DropIndex("dbo.OrderDetails", new[] { "OrderId" });
            DropIndex("dbo.Orders", new[] { "EmpId" });
            DropIndex("dbo.Bills", new[] { "OrderId" });
            DropIndex("dbo.Bills", new[] { "CustomerId" });
            DropTable("dbo.Racks");
            DropTable("dbo.DistributorCompanies");
            DropTable("dbo.PurchaseMedicines");
            DropTable("dbo.Categories");
            DropTable("dbo.Medicines");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Employees");
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
            DropTable("dbo.Bills");
        }
    }
}
