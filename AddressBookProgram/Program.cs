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

            AddressBook addressBook = new AddressBook();

            Console.WriteLine("Add a new contact to Address Book:");
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter Address: ");
            string address = Console.ReadLine();
            Console.Write("Enter City: ");
            string city = Console.ReadLine();
            Console.Write("Enter State: ");
            string state = Console.ReadLine();
            Console.Write("Enter Zip: ");
            int zip = int.Parse(Console.ReadLine());
            Console.Write("Enter Phone Number: ");
            int phone = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Contact newContact = new Contact(firstName, lastName, address, city, state, zip, phone, email);
            addressBook.AddContact(newContact);
            addressBook.PrintAllContacts();
            Console.ReadLine();
        }
    }
}
