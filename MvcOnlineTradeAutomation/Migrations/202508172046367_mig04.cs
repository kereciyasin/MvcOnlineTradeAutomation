namespace MvcOnlineTradeAutomation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig04 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "FirstName", c => c.String(nullable: false, maxLength: 30, unicode: false));
            AlterColumn("dbo.Customers", "LastName", c => c.String(nullable: false, maxLength: 30, unicode: false));
            AlterColumn("dbo.Customers", "City", c => c.String(nullable: false, maxLength: 30, unicode: false));
            AlterColumn("dbo.Customers", "Email", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Email", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Customers", "City", c => c.String(maxLength: 30, unicode: false));
            AlterColumn("dbo.Customers", "LastName", c => c.String(maxLength: 30, unicode: false));
            AlterColumn("dbo.Customers", "FirstName", c => c.String(maxLength: 30, unicode: false));
        }
    }
}
