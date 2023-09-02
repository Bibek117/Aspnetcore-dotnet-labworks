using System;
using System.Linq;
namespace lab21;
class Program
{
    static void Main(string[] args)
    {
        using var context = new ApplicationDbContext();

        // Create
        var newPerson = new Person { Name = "Bibek Angdembe", Age = 22 };
        context.People.Add(newPerson);
        context.SaveChanges();

        // Read
        var personToRead = context.People.FirstOrDefault(p => p.Name == "Bibek Angdembe");
        Console.WriteLine($"Read: {personToRead?.Name}, Age: {personToRead?.Age}");

        // Update
        if (personToRead != null)
        {
            personToRead.Age = 31;
            context.SaveChanges();
            Console.WriteLine("Update: Age updated to 31");
        }

        // Delete
        if (personToRead != null)
        {
            context.People.Remove(personToRead);
            context.SaveChanges();
            Console.WriteLine("Delete: Record deleted");
        }
    }
}

