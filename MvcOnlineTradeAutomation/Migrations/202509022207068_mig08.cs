namespace MvcOnlineTradeAutomation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig08 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Invoices", "TotalAmount", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Invoices", "TotalAmount");
        }
    }
}
