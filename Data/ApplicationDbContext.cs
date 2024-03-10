using Microsoft.EntityFrameworkCore;
using StudentPortalApp.Models.Entities;

namespace StudentPortalApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }


    }
    
}
