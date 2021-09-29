using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Account
    {
        private int acno;
        public int useraccno
        {
            get { return acno; }
            set { acno = value; }
        }
        protected string name;
        internal int deposit;
        protected char type;

        protected void create_account()
        {
            Console.WriteLine("Enter your Account No. : ");
            useraccno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Name of the Account Holder name : ");
            name = Console.ReadLine();
            Console.WriteLine(" Enter the Type of Account(C/S) : ");
            type = char.Parse(Console.ReadLine());
            Console.WriteLine(" Enter the Initial Amount : ");
            deposit = int.Parse(Console.ReadLine());
            Console.WriteLine("Account Created.....");

        }
        public void createaccount()
        {
            create_account();
        }
        protected void show_Account()
        {
            Console.WriteLine("\nAccount No. : {0} ", useraccno);
            Console.WriteLine("\nAccount Holder Name : {0} ", name);
            Console.WriteLine("\nType of Account : {0} ", type);
            Console.WriteLine("\nBalance Amount : {0} ", deposit);
        }
        public void showAccount()
        {
            show_Account();
        }
        internal void modifyaccount()
        {
            Console.WriteLine("\nAccount No. : {0} ", acno);
            Console.WriteLine("\nModify Account Holder Name : {0} ");
            name = Console.ReadLine();
            Console.WriteLine("\nModify Type of Account");
            type = char.Parse(Console.ReadLine());
            Console.WriteLine("\nModify Account Balance ");
            deposit = int.Parse(Console.ReadLine());
        }
        public void modify_account()
        {
            modifyaccount();
        }
        public void accountdeposit()
        {
            int x;
            Console.WriteLine("Enter the amount to be Deposited ::");
            x = int.Parse(Console.ReadLine());
            deposit += x;
            Console.WriteLine(" Current Bank Balance is : {0}", deposit);
        }
        public void accountWithdraw()
        {
            int x;
            Console.WriteLine("Enter the amount to be withdrawen ::");
            x = int.Parse(Console.ReadLine());
            if (x <= deposit && x >0 )
            {
                deposit -= x;
                Console.WriteLine(" Current Bank Balance is : {0}", deposit);
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }
        public void account_report()
        {
            Console.Write("Acno ::{0} \n Name ::{1}  \nType ::{2}  \n Deposit ::{3}\n" , acno , name , type , deposit);
        }
        public int retacno()
        {
            return acno;
        }
        public int retdeposit()
        {
            return deposit;
        }
        public char rettype()
        {
            return type;
        }
    }
}
