using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Contact
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
            List<Contact> contacts = new List<Contact>();
            //{
            //    new Contact() {FirstName = "Sandeep", LastName = "Singh", Address = "Morabadi", City = "Varanasi", State ="Uttarpradesh", Zip =834009, Phone =997368404, Email = "sand72@gmail.com"}
            //};
           

            Console.WriteLine("Enter the contact details:");
            Contact newContact = new Contact();

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



            foreach (Contact contact in contacts)
                {
                    Console.WriteLine(" First Name:{0}\n Last Name: {1}\n Address:{2}\n City:{3}\n State:{4}\n Zip:{5}\n Phone:{6}\n Email:{7}\n", "result:" +contact.FirstName, contact.LastName, contact.Address, contact.City, contact.State, contact.Zip, contact.Phone, contact.Email);
                }
            }
        }
    }


