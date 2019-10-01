using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount a1 = new BankAccount("189902", "Jordan McGrath", 10000);
            BankAccount a2 = new BankAccount("789541", "John Smith", 25000);

            Console.WriteLine(a1.GetAccountDetails());
            Console.WriteLine(a2.GetAccountDetails());

            Console.WriteLine("Adding 1800 to account 1");
            a1.Deposit(1800);
            Console.WriteLine(a1.GetAccountDetails());

            Console.WriteLine("Withdrawing 2500 from account 2 ");
            a2.WithDraw(2500);
            Console.WriteLine(a2.GetAccountDetails());
        }
    }
}
