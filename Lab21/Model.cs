using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace lab21;
    public class Person
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public int Age { get; set; }
}


public class ApplicationDbContext : DbContext
{
    public DbSet<Person> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Configure the database connection here
        optionsBuilder.UseSqlServer("Server = DESKTOP-2NNALVV\\SQLEXPRESS01; Database = consolecrud; Integrated Security = true; TrustServerCertificate = True; Encrypt = False ");

    }
}


