using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            
                Customer c = new Customer();
                c.display();
                Interface1 b = new bankdetails();
                b.openAccount();
                b.accDetails();
         }
    }
}
