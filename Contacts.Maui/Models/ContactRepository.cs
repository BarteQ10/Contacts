using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Maui.Models
{
    public static class ContactRepository
    {
        public static List<Contact> _contacts = new List<Contact>()
            {
            new Contact {ContactId=0, Name = "Bartłomiej Paszkowski", Email ="BartlomiejPaszkowski@gmail.com" },
            new Contact {ContactId=1, Name = "John Doe", Email ="JohnDoe@gmail.com" },
            new Contact {ContactId=2, Name = "Tom Hanks", Email ="TomHanks@gmail.com" },
            new Contact {ContactId=3, Name = "Frank Liu", Email ="FrankLiu@gmail.com" },
        };

        public static List<Contact> GetContacts() => _contacts;
        public static Contact GetContactById(int contactId)
        {
            var contact = _contacts.FirstOrDefault(x => x.ContactId == contactId);
            if (contact != null)
            {
                return new Contact
                {
                    ContactId = contactId,
                    Name = contact.Name,
                    Email = contact.Email,
                    Phone = contact.Phone,
                    Address = contact.Address
                };
            }
            return null;
        }
        public static void UpdateContact(int  contactId, Contact contact)
        {
            if (contactId != contact.ContactId) return;
            var contactToUpdate = _contacts.FirstOrDefault(x => x.ContactId == contactId);
            if(contactToUpdate != null)
            {
                contactToUpdate.Address = contact.Address;
                contactToUpdate.Email = contact.Email;
                contactToUpdate.Name = contact.Name;
                contactToUpdate.Phone = contact.Phone;
            }
        }
    }
}
