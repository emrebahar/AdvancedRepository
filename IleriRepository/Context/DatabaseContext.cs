using IleriRepository.Concrete;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace IleriRepository.Context
{
    public class DatabaseContext : DbContext
    {
        // Your context has been configured to use a 'DatabaseContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'IleriRepository.Context.DatabaseContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DatabaseContext' 
        // connection string in the application configuration file.
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();//Eklenen Kod
        }

        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Lecturer> Teacher { get; set; }
        public virtual DbSet<Personnel> Personnel { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<Education> Education { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}