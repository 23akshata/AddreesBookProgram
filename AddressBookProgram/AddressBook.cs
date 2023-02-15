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
        public void CreateContact()
        {
            contact.FirstName = Console.ReadLine();
            contact.LastName = Console.ReadLine();
            contact.Email = Console.ReadLine();
            contact.City = Console.ReadLine();
            contact.PhoneNumber = Console.ReadLine();
            contact.Address = Console.ReadLine();
            contact.State = Console.ReadLine();
            contact.Zip = Convert.ToInt64(Console.ReadLine());

        }
        public void Display()
        {
            Console.WriteLine("Contact Details" + "\n" + "FirstName" + contact.FirstName + "\n" + "LastName" + contact.LastName + "\n" + "Email" + contact.Email + "\n" + "City" + contact.City + "\n" + "PhoneNumber" + contact.PhoneNumber + "\n" +
                "Address" + contact.Address +"\n" + "State" + contact.State+ "\n" + "Zip" + contact.Zip + "\n");
        }
    }
}
