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

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add contact");
                Console.WriteLine("2. Edit contact");
                Console.WriteLine("3. Delete contact");
                Console.WriteLine("4. Add multiple contacts");
                Console.WriteLine("5. Quit");
                Console.Write("Option: ");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("First name: ");
                        string firstName = Console.ReadLine();
                        Console.Write("Last name: ");
                        string lastName = Console.ReadLine();
                        Console.Write("Address: ");
                        string address = Console.ReadLine();
                        Console.Write("City: ");
                        string city = Console.ReadLine();
                        Console.Write("State: ");
                        string state = Console.ReadLine();
                        Console.Write("Zip: ");
                        int zip = int.Parse(Console.ReadLine());
                        Console.Write("Phone: ");
                        int phone = int.Parse(Console.ReadLine());
                        Console.Write("Email: ");
                        string email = Console.ReadLine();
                        Contact contact = new Contact(firstName, lastName, address, city, state, zip, phone, email);
                        addressBook.AddContact(contact);
                        Console.WriteLine("Contact added.");
                        Console.WriteLine(contact.ToString());
                        break;
                    case 2:
                        Console.Write("First name: ");
                        string editFirstName = Console.ReadLine();
                        Console.Write("Last name: ");
                        string editLastName = Console.ReadLine();
                        addressBook.EditContact(editFirstName, editLastName);
                        break;
                    case 3:
                        Console.Write("First name: ");
                        string deleteFirstName = Console.ReadLine();
                        Console.Write("Last name: ");
                        string deleteLastName = Console.ReadLine();
                        addressBook.DeleteContact(deleteFirstName, deleteLastName);
                        break;
                    case 4:
                        Console.Write("How many contacts do you want to add? ");
                        int count = int.Parse(Console.ReadLine());

                        for (int i = 0; i < count; i++)
                        {
                            Console.Write("First name: ");
                            firstName = Console.ReadLine();
                            Console.Write("Last name: ");
                            lastName = Console.ReadLine();
                            Console.Write("Address: ");
                            address = Console.ReadLine();
                            Console.Write("City: ");
                            city = Console.ReadLine();
                            Console.Write("State: ");
                            state = Console.ReadLine();
                            Console.Write("Zip: ");
                            zip = int.Parse(Console.ReadLine());
                            Console.Write("Phone: ");
                            phone = int.Parse(Console.ReadLine());
                            Console.Write("Email: ");
                            email = Console.ReadLine();

                            contact = new Contact(firstName, lastName, address, city, state, zip, phone, email);
                            addressBook.AddContact(contact);
                            Console.WriteLine("Contact added:");
                            Console.WriteLine(contact.ToString());
                        }
                        break;

                    case 5:
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
