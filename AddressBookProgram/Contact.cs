using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact(string firstName, string lastName, string address, string city, string state, int zip, int phone, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            PhoneNumber = phone;
            Email = email;

        }
        public override string ToString()
        {
            return string.Format("Name: {0} {1}\nAddress: {2}, {3}, {4} - {5}\nPhone Number: {6}\nEmail: {7}", FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email);
        }
    }
    class AddressBook
    {
        private List<Contact> contacts;

        public AddressBook()
        {
            contacts = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

        public void EditContact(string firstName, string lastName)
        {
            Contact contact = FindContact(firstName, lastName);
            if (contact == null)
            {
                Console.WriteLine("Contact not found.");
            }
            else
            {
                Console.WriteLine("Enter new details:");
                Console.Write("Address: ");
                contact.Address = Console.ReadLine();
                Console.Write("City: ");
                contact.City = Console.ReadLine();
                Console.Write("State: ");
                contact.State = Console.ReadLine();
                Console.Write("Zip: ");
                contact.Zip = int.Parse(Console.ReadLine());
                Console.Write("Phone: ");
                contact.PhoneNumber = int.Parse(Console.ReadLine());
                Console.Write("Email: ");
                contact.Email = Console.ReadLine();
            }
        }

        public void DeleteContact(string firstName, string lastName)
        {
            Contact contact = FindContact(firstName, lastName);
            if (contact == null)
            {
                Console.WriteLine("Contact not found.");
            }
            else
            {
                contacts.Remove(contact);
                Console.WriteLine("Contact deleted.");
            }
        }

        private Contact FindContact(string firstName, string lastName)
        {
            foreach (Contact contact in contacts)
            {
                if (contact.FirstName == firstName && contact.LastName == lastName)
                {
                    return contact;
                }
            }
            return null;
        }
        public List<Contact> GetAllContacts()
        {
            return contacts;
        }
    }

}
