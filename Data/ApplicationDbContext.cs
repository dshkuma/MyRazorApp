namespace StudentApp.Data
{
    using global::StudentApp.Models.StudentApp.Models;
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;
    //using StudentApp.Models;

    namespace StudentApp.Data
    {
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

            public DbSet<Student> Students { get; set; }
        }
    }

}
