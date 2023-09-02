using EFCodeFirstA.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCodeFirstA
{
    public class ApplicationDbcontext:DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext>options):base(options) { }

        public DbSet<Student>Students { get; set; }
    }
}
