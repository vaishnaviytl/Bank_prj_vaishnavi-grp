using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Customer
    {
        public void display()
        {
            string username, gender;
            int age;
            long phonenumber;
            Console.WriteLine("enter username");
            username = Console.ReadLine();
            Console.WriteLine("enter gender");
            gender = Console.ReadLine();
            Console.WriteLine("enter age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter phonenumber");
            phonenumber = long.Parse(Console.ReadLine());
        }
    }
}
