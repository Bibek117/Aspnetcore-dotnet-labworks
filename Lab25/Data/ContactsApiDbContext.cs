using Microsoft.EntityFrameworkCore;
using Lab25.Models;
namespace Lab25.Data;

public class ContactsApiDbContext : DbContext
{
    public ContactsApiDbContext(DbContextOptions<ContactsApiDbContext> options)
        : base(options)
    {
    }

    public DbSet<Contact> Contacts { get; set; } = null!;
}