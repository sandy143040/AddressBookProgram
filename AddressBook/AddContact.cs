using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddContact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }

        public static void ContactDataManupulation()
        {
            List<AddContact> contacts = new List<AddContact>();

            Console.WriteLine("Enter the contact details:");
            AddContact newContact = new AddContact();

            Console.Write("First Name: ");
            newContact.FirstName = Console.ReadLine();

            Console.Write("Last Name: ");
            newContact.LastName = Console.ReadLine();

            Console.Write("Address: ");
            newContact.Address = Console.ReadLine();

            Console.Write("City: ");
            newContact.City = Console.ReadLine();

            Console.Write("State: ");
            newContact.State = Console.ReadLine();

            Console.Write("Zip: ");
            newContact.Zip = int.Parse(Console.ReadLine());

            Console.Write("Phone: ");
            newContact.Phone = int.Parse(Console.ReadLine());

            Console.Write("Email: ");
            newContact.Email = Console.ReadLine();

            contacts.Add(newContact);

            //Adding New Contact details
            Console.WriteLine("Enter the 2nd contact details");
            AddContact addContact = new AddContact();


            Console.Write("First Name: ");
            addContact.FirstName = Console.ReadLine();

            Console.Write("Last Name: ");
            addContact.LastName = Console.ReadLine();

            Console.Write("Address: ");
            addContact.Address = Console.ReadLine();

            Console.Write("City: ");
            addContact.City = Console.ReadLine();

            Console.Write("State: ");
            addContact.State = Console.ReadLine();

            Console.Write("Zip: ");
            addContact.Zip = int.Parse(Console.ReadLine());

            Console.Write("Phone: ");
            addContact.Phone = int.Parse(Console.ReadLine());

            Console.Write("Email: ");
            addContact.Email = Console.ReadLine();
            contacts.Add(addContact);
            foreach (AddContact contact in contacts)
            {
                Console.WriteLine(" First Name:{0}\n Last Name: {1}\n Address:{2}\n City:{3}\n State:{4}\n Zip:{5}\n Phone:{6}\n Email:{7}\n", "result:" + contact.FirstName, contact.LastName, contact.Address, contact.City, contact.State, contact.Zip, contact.Phone, contact.Email);
            }
        }
    }
}

