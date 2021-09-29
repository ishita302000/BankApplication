using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Program : Account
    {
        static void Main(string[] args)
        {
            int num, n; 
            Account bank = new Account();
            do
            {
                Console.Write("\n\n\nMain Menu");
                Console.Write("\n\t 01. New Account");
                Console.Write("\n\t 02. Deposit Amount");
                Console.Write("\n\t 03. WithDraw Amount");
                Console.Write("\n\t 04. Balance Enquiry");
                Console.Write("\n\t 05. All Account Holder List ");
                Console.Write("\n\t 06. Modify Account ");
                Console.Write("\n\t 06. Exit ");
                Console.Write("\n\t Select an option from 1-7 : ");
                n = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (n)
                {
                    case 1:
                        {
                            Console.Clear();
                            bank.createaccount();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            bank.accountdeposit();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            bank.accountWithdraw();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            bank.account_report();
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            bank.showAccount();
                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            Console.Write("\n\nEnter the Account no. : ");
                            num = int.Parse(Console.ReadLine());
                            bank.modify_account();
                            break;
                        }
                }
            }
            while (n != 7);
        }
    }

}

