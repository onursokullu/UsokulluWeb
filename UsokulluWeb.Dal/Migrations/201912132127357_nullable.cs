namespace UsokulluWeb.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nullable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Patients", "BloodGroupId", "dbo.BloodGroups");
            DropIndex("dbo.Patients", new[] { "BloodGroupId" });
            AlterColumn("dbo.Patients", "BloodGroupId", c => c.Int());
            AlterColumn("dbo.Patients", "PrescriptionId", c => c.Int());
            AlterColumn("dbo.Patients", "TreatmentId", c => c.Int());
            AlterColumn("dbo.Patients", "AppointmentId", c => c.Int());
            CreateIndex("dbo.Patients", "BloodGroupId");
            AddForeignKey("dbo.Patients", "BloodGroupId", "dbo.BloodGroups", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Patients", "BloodGroupId", "dbo.BloodGroups");
            DropIndex("dbo.Patients", new[] { "BloodGroupId" });
            AlterColumn("dbo.Patients", "AppointmentId", c => c.Int(nullable: false));
            AlterColumn("dbo.Patients", "TreatmentId", c => c.Int(nullable: false));
            AlterColumn("dbo.Patients", "PrescriptionId", c => c.Int(nullable: false));
            AlterColumn("dbo.Patients", "BloodGroupId", c => c.Int(nullable: false));
            CreateIndex("dbo.Patients", "BloodGroupId");
            AddForeignKey("dbo.Patients", "BloodGroupId", "dbo.BloodGroups", "Id", cascadeDelete: true);
        }
    }
}
