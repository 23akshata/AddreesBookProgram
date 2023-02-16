﻿using System;
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
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter 1: For Creating Contact \n 2:Editing Contact");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Console.WriteLine();
                        addressBook.CreateContact();
                        addressBook.Display();
                        break;

                    case 2:
                        Console.WriteLine("Edit Contact");
                        addressBook.EditContact("Akshata");
                        addressBook.Display();
                        break;

                    case 3:
                        flag = false;
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
