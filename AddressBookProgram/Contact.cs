using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
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
        public int Phone { get; set; }
        public string Email { get; set; }

        public Contact(string firstName, string lastName, string address, string city, string state, int zip, int phone, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            Phone = phone;
            Email = email;

        }
        public override string ToString()
        {
            return string.Format("Name: {0} {1}\nAddress: {2}, {3}, {4} - {5}\nPhone Number: {6}\nEmail: {7}", FirstName, LastName, Address, City, State, Zip, Phone, Email);
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

        public void PrintAllContacts()
        {
            Console.WriteLine("Contacts in Address Book:");
            foreach (Contact contact in contacts)
            {
                Console.WriteLine(contact);
                Console.WriteLine("----------------------------");
            }
        }
    }
}
