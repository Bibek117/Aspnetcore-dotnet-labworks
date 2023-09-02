using Microsoft.AspNetCore.Mvc;
using Lab25.Data; // You may need to include the namespace for your ContactsApiDbContext and Contact models.
using System.Linq;
using Lab25.Models;
using System;
using System.Threading.Tasks;

namespace Lab25.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactsController : Controller
    {
        private readonly ContactsApiDbContext dbContext;

        public ContactsController(ContactsApiDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetContacts()
        {
            return Ok(dbContext.Contacts.ToList());
        }

        [HttpPost]
        public async Task<IActionResult> AddContact(AddContactRequest addContactRequest)
        {
            var contact = new Contact()
            {
                Id = Guid.NewGuid(),
                Fullname = addContactRequest.Fullname,
                Phone = addContactRequest.Phone
            };

            await dbContext.Contacts.AddAsync(contact);
            await dbContext.SaveChangesAsync();

            return Ok(contact);
        }
    }
}
