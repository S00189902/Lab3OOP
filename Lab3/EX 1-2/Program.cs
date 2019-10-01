using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Ford";
            car1.Model = "Escort";
            car1.Speed = 55;
            car1.Size = 2.0;
            

            Car car2 = new Car();
            car2.Make = "Mitsubishi";
            car2.Model = "Lancer Evolution";
            car2.Speed = 68;
            car2.Size = 2.1;

            Console.WriteLine("Car 1 is a {0} {1} moving at a speed of {2} miles per hour with an engine size of {3} litres", car1.Make, car1.Model, car1.Speed, car1.Size);
            Console.WriteLine("Car 2 is a {0} {1} moving at a speed of {2} miles per hour with an engine size of {3} litres", car2.Make, car2.Model, car2.Speed, car2.Size);

            car1.DisplayCarInfo();

            Console.WriteLine(car2);

            for(int i =0; i <10;i++)
            {
                car1.Accelerate();
                car2.Accelerate();
            }
            Console.WriteLine(car1);
            car2.DisplayCarInfo();
        }
    }
}
