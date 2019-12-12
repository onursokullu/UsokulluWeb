namespace UsokulluWeb.Dal.Entity
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using UsokulluWeb.Model;

    public class UsokulluContext : DbContext
    {
        // Your context has been configured to use a 'UsokulluContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'UsokulluWeb.Dal.Entity.UsokulluContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'UsokulluContext' 
        // connection string in the application configuration file.
        public UsokulluContext()
            : base("name=UsokulluContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Appointments> Appointment { get; set; }
        public virtual DbSet<Blog> Blog { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<BlogComment> BlogComment { get; set; }
        public virtual DbSet<BloodGroups> BloodGroups { get; set; }
        public virtual DbSet<Contact> ContactForm { get; set; }
        public virtual DbSet<Expenses> Expenses { get; set; }
        public virtual DbSet<Images> Images { get; set; }
        public virtual DbSet<Medicines> Medicines { get; set; }
        public virtual DbSet<Patients> Patients { get; set; }
        public virtual DbSet<Prescription> Prescriptions { get; set; }
        public virtual DbSet<Subscribers> Subscribers { get; set; }
        public virtual DbSet<Treatments> Treatments { get; set; }
        public virtual DbSet<Users> Users { get; set; }


    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}