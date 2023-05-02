namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeTable_PKEmail_UpdatedV20 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "EmpId", "dbo.Employees");
            DropForeignKey("dbo.Tokens", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.Orders", new[] { "EmpId" });
            DropIndex("dbo.Employees", new[] { "Email" });
            DropIndex("dbo.Tokens", new[] { "EmployeeId" });
            RenameColumn(table: "dbo.Orders", name: "EmpId", newName: "EmpMail");
            RenameColumn(table: "dbo.Tokens", name: "EmployeeId", newName: "EmpMail");
            DropPrimaryKey("dbo.Employees");
            AlterColumn("dbo.Orders", "EmpMail", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Tokens", "EmpMail", c => c.String(nullable: false, maxLength: 100));
            AddPrimaryKey("dbo.Employees", "Email");
            CreateIndex("dbo.Orders", "EmpMail");
            CreateIndex("dbo.Tokens", "EmpMail");
            AddForeignKey("dbo.Orders", "EmpMail", "dbo.Employees", "Email", cascadeDelete: true);
            AddForeignKey("dbo.Tokens", "EmpMail", "dbo.Employees", "Email", cascadeDelete: true);
            DropColumn("dbo.Employees", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Tokens", "EmpMail", "dbo.Employees");
            DropForeignKey("dbo.Orders", "EmpMail", "dbo.Employees");
            DropIndex("dbo.Tokens", new[] { "EmpMail" });
            DropIndex("dbo.Orders", new[] { "EmpMail" });
            DropPrimaryKey("dbo.Employees");
            AlterColumn("dbo.Tokens", "EmpMail", c => c.Int(nullable: false));
            AlterColumn("dbo.Orders", "EmpMail", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Employees", "Id");
            RenameColumn(table: "dbo.Tokens", name: "EmpMail", newName: "EmployeeId");
            RenameColumn(table: "dbo.Orders", name: "EmpMail", newName: "EmpId");
            CreateIndex("dbo.Tokens", "EmployeeId");
            CreateIndex("dbo.Employees", "Email", unique: true);
            CreateIndex("dbo.Orders", "EmpId");
            AddForeignKey("dbo.Tokens", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Orders", "EmpId", "dbo.Employees", "Id", cascadeDelete: true);
        }
    }
}
