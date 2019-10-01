using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Lunch l1, l2, l3, l4, l5;
            l1 = new Lunch();
            l2 = new Lunch();
            l3 = new Lunch();
            l4 = new Lunch();
            l5 = new Lunch();

            l1.Entree = "Cottage Pie";
            l1.Side = "Chips";
            l1.Drink = "Monster";

            l2.Entree = "Lasagne";
            l2.Side = "Vegatables";
            l2.Drink = "Coke";

            l3.Entree = "Beef";
            l3.Side = "Vegatables";
            l3.Drink = "Water";

            l4.Entree = "Pizza";
            l4.Side = "Mushrooms";
            l4.Drink = "Orange Juice";

            l5.Entree = "Soup";
            l5.Side = "Bread";
            l5.Drink = "Water";

            Lunch.Display(l1, l2, l3);
            Console.WriteLine("------------------------");

            Lunch.Display(l1, l2, l3, l4, l5);
            Console.WriteLine("-----------------------------");
        }
    }
}
