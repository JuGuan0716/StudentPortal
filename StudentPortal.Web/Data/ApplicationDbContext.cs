using Microsoft.EntityFrameworkCore;
using StudentPortal.Web.Models.Entities;

namespace StudentPortal.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        // pointing to student data table with name students
        public DbSet<Student> Students { get; set; }

    }
}
