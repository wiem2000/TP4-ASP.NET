using Microsoft.EntityFrameworkCore;
using tp4asp.Models;

namespace tp4asp.Data
{
    public class UniversityContext : DbContext
    {
        public DbSet<Student> Student { get; set; }


        private static UniversityContext? instance;
        private UniversityContext(DbContextOptions o) : base(o) { }

        public static UniversityContext Instantiate_UniversityContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<UniversityContext>();
            optionsBuilder.UseSqlite(@"Data Source = C:\sqlite\databaseTP4.db");

            return new UniversityContext(optionsBuilder.Options);
        }
        public static UniversityContext Instance()
        {
            if (instance == null)
            {
                instance = Instantiate_UniversityContext();

            }
            return instance;
        }


    }
}

