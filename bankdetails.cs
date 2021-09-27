using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    

        interface Interface1
        {
            void openAccount();
            void accDetails();
            int deposit();
            void withdrawal();
        }
        class bankdetails : Interface1
        {
            private string accno;

            private long balance;



            public void openAccount()
            {
                Console.WriteLine("enter account no");
                accno = Console.ReadLine();

                Console.WriteLine("Deposit 1000 to create Bank account");
                balance = long.Parse(Console.ReadLine());
            }

            public void accDetails()
            {
            string again;
            do
            {
                Console.WriteLine("___________________________________________________");
                Console.WriteLine("account number:" + accno);
                Console.WriteLine("balance " + balance);
                Console.WriteLine("___________________________________________________");
                Console.WriteLine("Enter 1 to Debit\nenter 2 for credit");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {

                    case 1:
                       
                        deposit();

                        break;
                    case 2:


                        if (balance > 1000)
                            
                        withdrawal();
                       else
                        Console.WriteLine("Insufficient Balance for withdraw");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }
                Console.WriteLine("\n DO YOU WANT TO CONTINUE THIS PROGRAM ?(YES/NO)");
                again = Console.ReadLine();
            } while (again == "yes");

            }

            public int deposit()
            {
                long amt;
                Console.WriteLine("Enter the amount you want to deposit: ");
                amt = long.Parse(Console.ReadLine());
                balance = balance + amt;
                Console.WriteLine("Balance after deposit: " + balance);
                return 0;
            }

            public void withdrawal()
            {
                long amt;
                Console.WriteLine(" Enter the amount you want to withdraw: ");
                amt = long.Parse(Console.ReadLine());
                if (balance >= amt)
                {
                    balance = balance - amt;
                    Console.WriteLine("Balance after withdrawal: " + balance);
                }
                else
                {
                    Console.WriteLine("Your balance is less than " + amt + "\tTransaction failed...!!");
                }
            }
        }
    }
