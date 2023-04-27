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
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Add contact");
                Console.WriteLine("2. Edit contact");
                Console.WriteLine("3. Exit");

                int option = Convert.ToInt32(Console.ReadLine());
              
                switch (option)
                {
                    case 1:
                        ContactPerson newContact = new ContactPerson();
                        Console.WriteLine("Enter first name:");
                        newContact.FirstName = Console.ReadLine();
                        Console.WriteLine("Enter last name:");
                        newContact.LastName = Console.ReadLine();
                        Console.WriteLine("Enter address:");
                        newContact.Address = Console.ReadLine();
                        Console.WriteLine("Enter city:");
                        newContact.City = Console.ReadLine();
                        Console.WriteLine("Enter state:");
                        newContact.State = Console.ReadLine();
                        Console.WriteLine("Enter zip code:");
                        newContact.Zip = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter phone number:");
                        newContact.PhoneNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter email address:");
                        newContact.Email = Console.ReadLine();
                        addressBook.AddContact(newContact);
                        Console.WriteLine("Contact added.");
                        break;
                    case 2:
                        Console.WriteLine("Enter first name of contact to edit:");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Enter last name of contact to edit:");
                        string lastName = Console.ReadLine();
                        ContactPerson existingContact = addressBook.FindContact(firstName, lastName);
                        if (existingContact == null)
                        {
                            Console.WriteLine("Contact not found.");
                            break;
                        }
                        ContactPerson updatedContact = new ContactPerson();
                        Console.WriteLine("Enter new first name (leave blank to keep current value):");
                        updatedContact.FirstName = Console.ReadLine();
                        Console.WriteLine("Enter new last name (leave blank to keep current value):");
                        updatedContact.LastName = Console.ReadLine();
                        Console.WriteLine("Enter new address (leave blank to keep current value):");
                        updatedContact.Address = Console.ReadLine();
                        Console.WriteLine("Enter new city (leave blank to keep current value):");
                        updatedContact.City = Console.ReadLine();
                        Console.WriteLine("Enter new state (leave blank to keep current value):");
                        updatedContact.State = Console.ReadLine();
                        Console.WriteLine("Enter new zip code (leave blank to keep current value):");
                        updatedContact.Zip = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter new phone number (leave blank to keep current value):");
                        updatedContact.PhoneNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter new email address (leave blank to keep current value):");
                        updatedContact.Email = Console.ReadLine();
                        addressBook.EditContact(firstName, lastName, updatedContact);
                        Console.WriteLine("Contact updated.");
                        break;
                    case 3:
                        Console.WriteLine("Exiting program.");
                        return;
                    default:
                        Console.WriteLine("Invalid option selected.");
                        break;
                     
                }
                   Console.ReadLine();
            }
        }
    }
}
