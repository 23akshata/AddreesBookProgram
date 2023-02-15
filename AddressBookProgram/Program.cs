using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Contact Details");
            AddressBook addressBook = new AddressBook();
            addressBook.CreateContact();
            addressBook.Display();
            Console.ReadLine();
        }
    }
}
