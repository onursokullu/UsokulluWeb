namespace UsokulluWeb.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        AppointmentDate = c.DateTime(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TcNo = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        Telephone = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        PrescriptionId = c.Int(),
                        TreatmentId = c.Int(),
                        BloodGroup = c.String(),
                        AppointmentId = c.Int(),
                        Gender = c.String(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Prescriptions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        MedicineId = c.Int(nullable: false),
                        Content = c.String(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.Medicines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MedicineName = c.String(nullable: false),
                        Dosage = c.String(),
                        PrescriptionId = c.Int(nullable: false),
                        Description = c.String(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Treatments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        ToothNumber = c.Int(nullable: false),
                        TreatmentDescription = c.String(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoriId = c.Int(nullable: false),
                        CommentId = c.Int(nullable: false),
                        Title = c.String(nullable: false),
                        Content = c.String(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoriId, cascadeDelete: true)
                .Index(t => t.CategoriId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BlogId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BlogComments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BlogId = c.Int(nullable: false),
                        NameSur = c.String(nullable: false),
                        ComTitle = c.String(nullable: false),
                        ComContent = c.String(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Blogs", t => t.BlogId, cascadeDelete: true)
                .Index(t => t.BlogId);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Subject = c.String(nullable: false),
                        Message = c.String(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Expenses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExpenseType = c.String(nullable: false),
                        ExpenseDescription = c.String(nullable: false),
                        Payment = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreateDate = c.DateTime(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImagePath = c.String(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Subscribers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserEmail = c.String(),
                        Password = c.String(),
                        UserType = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MedicinesPrescriptions",
                c => new
                    {
                        Medicines_Id = c.Int(nullable: false),
                        Prescription_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Medicines_Id, t.Prescription_Id })
                .ForeignKey("dbo.Medicines", t => t.Medicines_Id, cascadeDelete: true)
                .ForeignKey("dbo.Prescriptions", t => t.Prescription_Id, cascadeDelete: true)
                .Index(t => t.Medicines_Id)
                .Index(t => t.Prescription_Id);
            
            CreateTable(
                "dbo.TreatmentsPatients",
                c => new
                    {
                        Treatments_Id = c.Int(nullable: false),
                        Patients_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Treatments_Id, t.Patients_Id })
                .ForeignKey("dbo.Treatments", t => t.Treatments_Id, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.Patients_Id, cascadeDelete: true)
                .Index(t => t.Treatments_Id)
                .Index(t => t.Patients_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BlogComments", "BlogId", "dbo.Blogs");
            DropForeignKey("dbo.Blogs", "CategoriId", "dbo.Categories");
            DropForeignKey("dbo.TreatmentsPatients", "Patients_Id", "dbo.Patients");
            DropForeignKey("dbo.TreatmentsPatients", "Treatments_Id", "dbo.Treatments");
            DropForeignKey("dbo.Prescriptions", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.MedicinesPrescriptions", "Prescription_Id", "dbo.Prescriptions");
            DropForeignKey("dbo.MedicinesPrescriptions", "Medicines_Id", "dbo.Medicines");
            DropForeignKey("dbo.Appointments", "PatientId", "dbo.Patients");
            DropIndex("dbo.TreatmentsPatients", new[] { "Patients_Id" });
            DropIndex("dbo.TreatmentsPatients", new[] { "Treatments_Id" });
            DropIndex("dbo.MedicinesPrescriptions", new[] { "Prescription_Id" });
            DropIndex("dbo.MedicinesPrescriptions", new[] { "Medicines_Id" });
            DropIndex("dbo.BlogComments", new[] { "BlogId" });
            DropIndex("dbo.Blogs", new[] { "CategoriId" });
            DropIndex("dbo.Prescriptions", new[] { "PatientId" });
            DropIndex("dbo.Appointments", new[] { "PatientId" });
            DropTable("dbo.TreatmentsPatients");
            DropTable("dbo.MedicinesPrescriptions");
            DropTable("dbo.Users");
            DropTable("dbo.Subscribers");
            DropTable("dbo.Images");
            DropTable("dbo.Expenses");
            DropTable("dbo.Contacts");
            DropTable("dbo.BlogComments");
            DropTable("dbo.Categories");
            DropTable("dbo.Blogs");
            DropTable("dbo.Treatments");
            DropTable("dbo.Medicines");
            DropTable("dbo.Prescriptions");
            DropTable("dbo.Patients");
            DropTable("dbo.Appointments");
        }
    }
}
