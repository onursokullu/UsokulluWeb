namespace UsokulluWeb.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.BloodGroups", "PatientId");
            DropColumn("dbo.BloodGroups", "CreateDate");
            DropColumn("dbo.BloodGroups", "IsDelete");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BloodGroups", "IsDelete", c => c.Boolean(nullable: false));
            AddColumn("dbo.BloodGroups", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.BloodGroups", "PatientId", c => c.Int(nullable: false));
        }
    }
}
