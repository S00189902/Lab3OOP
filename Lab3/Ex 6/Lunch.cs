using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_6
{
   public class Lunch
    {
        public string Entree { get; set; }

        public string Side { get; set; }


        public string Drink { get; set; }

      public  static void Display(params Lunch[] lunches)
        {
            

            foreach(Lunch lunch in lunches)
            {
                Console.WriteLine("Entree : {0} \nSide : {1} \nDrink : {2} ",lunch.Entree, lunch.Side, lunch.Drink);
            }
        }
    }
}
