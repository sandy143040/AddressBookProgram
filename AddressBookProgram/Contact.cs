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

        public List<Contact> contactsList = new List<Contact>();

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
            contactsList.Add(this);
        }
        public void PrintContacts()
        {
            Console.WriteLine("\nContacts List:");
            foreach (Contact contact in contactsList)
            {
                Console.WriteLine(" First Name:{0}\n Last Name: {1}\n Address:{2}\n City:{3}\n State:{4}\n Zip:{5}\n Phone:{6}\n Email:{7}\n", "result:" + contact.FirstName, contact.LastName, contact.Address, contact.City, contact.State, contact.Zip, contact.Phone, contact.Email);
            }
        }
    }
}
