using Microsoft.AspNetCore.Mvc;
using WebApplication1.Clasess;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactsController : Controller
    {
        [HttpGet]
        public IActionResult GetContacts()
        {
            return Ok(ContactData.contacts);
        }

        [HttpGet("{id}")]
        public IActionResult GetContactById(int id)
        {
            var contact = ContactData.contacts
                .FirstOrDefault(c => c.Id == id);

            if (contact == null)
            {
                return NotFound("no sach contact");
            }

            return Ok(contact);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteContactById(int id)
        {
            var contact = ContactData.contacts
                .FirstOrDefault(c => c.Id == id);

            if (contact == null)
            {
                return NotFound("no sach contact to Delete");
            }
            ContactData.contacts.Remove(contact);
            return Ok(new
            {
                message = "Contact deleted successfully",
                deletedId = id
            });
        }
        [HttpPut("{id}")]
        public IActionResult UpdateContact(int id, [FromBody] Contact updatedContact)
        {
            var contact = ContactData.contacts
                .FirstOrDefault(c => c.Id == id);

            if (contact == null)
            {
                return NotFound(new
                {
                    message = "Contact was not found",
                    id
                });
            }

            contact.FirstName = updatedContact.FirstName;
            contact.LastName = updatedContact.LastName;
            contact.Email = updatedContact.Email;
            contact.Phone = updatedContact.Phone;
            contact.Status = updatedContact.Status;

            return Ok(new
            {
                message = "Contact updated successfully",
                contact
            });
        }

        [HttpPost]
        public IActionResult AddContact([FromBody] Contact contact)
        {
            contact.Id = ContactData.contacts.Any()
                ? ContactData.contacts.Max(c => c.Id) + 1
                : 1;

            ContactData.contacts.Add(contact);

            return CreatedAtAction(
                nameof(GetContactById),
                new { id = contact.Id },
                contact);
        }
    }

}
