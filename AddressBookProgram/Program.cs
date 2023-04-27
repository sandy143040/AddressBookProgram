using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Problem");

            Console.WriteLine("Enter the contact details:");
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Address: ");
            string address = Console.ReadLine();
            Console.Write("City: ");
            string city = Console.ReadLine();
            Console.Write("State: ");
            string state = Console.ReadLine();
            Console.Write("Zip: ");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.Write("Phone: ");
            int phone = Convert.ToInt32(Console.ReadLine());
            Console.Write("Email: ");
            string email = Console.ReadLine();

            // Create a new contact and add it to the list
            Contact contact = new Contact(firstName, lastName, address, city, state, zip, phone, email);

            // Print out the contacts in the list
            contact.PrintContacts();
            Console.ReadLine();
        }
    }
}
