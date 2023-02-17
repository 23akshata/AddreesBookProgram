using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    public class AddressBook
    {
        Contact contact = new Contact();
        List<Contact> contactList = new List<Contact>();
        public void CreateContact()
        {
            Contact contact = new Contact();
            Console.WriteLine("Enter the First Name:");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter the Last Name:");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter the Email:");
            contact.Email = Console.ReadLine();
            Console.WriteLine("Enter the City:");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter the PhoneNumber:");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter the Address:");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter the State:");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter the Zip:");
            contact.Zip = Convert.ToInt64(Console.ReadLine());

            contactList.Add(contact);


        }
        public void Display()
        {
            foreach (var contact in contactList)
                Console.WriteLine("Contact Details" + "\n" + "FirstName:" + contact.FirstName + "\n" + "LastName" +
                    ":" + contact.LastName + "\n" + "Email:" + contact.Email + "\n" + "City:" + contact.City + "\n" + "PhoneNumber:" + contact.PhoneNumber + "\n" +
                    "Address:" + contact.Address + "\n" + "State:" + contact.State + "\n" + "Zip:" + contact.Zip + "\n");
        }
        public void EditContact(string name)
        {
            foreach (var contact in contactList)
            {
                if (contact.FirstName.Equals(name))
                {
                    Console.WriteLine("1.Address \n 2.FirstName \n 3.LastName \n 4.Email \n 5.City \n 6:PhoneNumber \n 7:State");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter the new address");
                            contact.Address = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter the new First Name");
                            contact.FirstName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter the new Last Name");
                            contact.LastName = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter the new Email");
                            contact.Email = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter the new City");
                            contact.City = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter the new PhoneNumber");
                            contact.PhoneNumber = Console.ReadLine();
                            break;
                        case 7:
                            Console.WriteLine("Enter the new State");
                            contact.State = Console.ReadLine();
                            break;
                        case 8:
                            Console.WriteLine("Enter the new Zip");
                            contact.Zip = Convert.ToInt64(Console.ReadLine());
                            break;

                    }
                }
            }
        }
        public void DeleteContact()
        {
            Console.WriteLine("Enter the First Name");
            string name = Console.ReadLine();
            Contact deleteContact = new Contact();
            foreach (var contact in contactList.ToList())
            {
                if (contact.FirstName.Equals(name))
                {
                    deleteContact = contact;
                }
                contactList.Remove(deleteContact);
                Console.WriteLine("Contact Deleted successfully");
            }
        }
    }
}