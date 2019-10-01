using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCashRegister
{
    class Program
    {
        static void Main(string[] args)
        {

            CashRegister c1 = new CashRegister();

            Console.WriteLine("New item worth 12.80 to the First cash Register");
            Console.WriteLine("New item worth 22.50 to the First cash Register");
            Console.WriteLine("New item worth 38.65 to the First cash Register");

            c1.AddItem(12.80);
            c1.AddItem(22.50);
            c1.AddItem(38.65);

            CashRegister c2 = new CashRegister();

            Console.WriteLine("New item worth 3.78 to the second cash register");
            Console.WriteLine("New item worth 5.68 to the second cash register");
            Console.WriteLine("New item worth 56.12 to the second cash register");
            Console.WriteLine("New item worth 89.45 to the second cash register");
            Console.WriteLine("New item worth 19.23 to the second cash register");

            c2.AddItem(3.78);
            c2.AddItem(5.68);
            c2.AddItem(56.12);
            c2.AddItem(89.45);
            c2.AddItem(19.23);

            Console.WriteLine("First cash register total : {0}", c1.Total);
            Console.WriteLine("First cash register Number of items : {0}", c1.NumberOfItems);

            Console.WriteLine("Second cash register total : {0}", c2.Total);
            Console.WriteLine("Second cash register Number of items : {0}", c2.NumberOfItems);
        }
    }
}
