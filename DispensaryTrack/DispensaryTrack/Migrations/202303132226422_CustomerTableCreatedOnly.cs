namespace DispensaryTrack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerTableCreatedOnly : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
