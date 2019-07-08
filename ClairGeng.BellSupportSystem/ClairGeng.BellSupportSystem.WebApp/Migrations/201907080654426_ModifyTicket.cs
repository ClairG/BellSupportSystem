namespace ClairGeng.BellSupportSystem.WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyTicket : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Ticket_Id", c => c.Int());
            CreateIndex("dbo.Employees", "Ticket_Id");
            AddForeignKey("dbo.Employees", "Ticket_Id", "dbo.Tickets", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Ticket_Id", "dbo.Tickets");
            DropIndex("dbo.Employees", new[] { "Ticket_Id" });
            DropColumn("dbo.Employees", "Ticket_Id");
        }
    }
}
