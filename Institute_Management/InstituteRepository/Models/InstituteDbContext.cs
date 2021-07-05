using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InstituteRepository.Models
{
    class InstituteDbContext:DbContext
    {
        public InstituteDbContext()
        {

        }
        public InstituteDbContext(DbContextOptions<InstituteDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Batch> Batches { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("data source=(localdb)\\MSSQLLocalDB; database=InsituteDb; integrated security=true");
            }
        }
    }
}
