using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    public class ContactPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
   
    }
    public class AddressBook
    {
         List<ContactPerson> contacts;

        public AddressBook()
        {
            contacts = new List<ContactPerson>();
        }

        public void AddContact(ContactPerson contact)
        {
            contacts.Add(contact);
        }

        public void EditContact(string firstName, string lastName, ContactPerson updatedContact)
        {
            ContactPerson contact = FindContact(firstName, lastName);
            if (contact != null)
            {
                contact.FirstName = updatedContact.FirstName;
                contact.LastName = updatedContact.LastName;
                contact.Address = updatedContact.Address;
                contact.City = updatedContact.City;
                contact.State = updatedContact.State;
                contact.Zip = updatedContact.Zip;
                contact.PhoneNumber = updatedContact.PhoneNumber;
                contact.Email = updatedContact.Email;
            }
        }

        public ContactPerson FindContact(string firstName, string lastName)
        {
            foreach (ContactPerson contact in contacts)
            {
                if (contact.FirstName == firstName && contact.LastName == lastName)
                {
                    return contact;
                }
            }
            return null;
        }
    }
}
