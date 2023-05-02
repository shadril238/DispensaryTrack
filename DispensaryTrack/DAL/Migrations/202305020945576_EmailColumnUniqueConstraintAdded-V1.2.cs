namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmailColumnUniqueConstraintAddedV12 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Employees", "Email", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Employees", new[] { "Email" });
        }
    }
}
