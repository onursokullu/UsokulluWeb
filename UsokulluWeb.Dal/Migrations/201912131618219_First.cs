namespace UsokulluWeb.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Subscribers", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Subscribers", "Email", c => c.Int(nullable: false));
        }
    }
}
