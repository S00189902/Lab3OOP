using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_1_2
{
    public class Car
    {
        private string make;

        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private int speed;

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        private double size;

        public double Size
        {
            get { return size; }
            set { size = value; }
        }

        public void DisplayCarInfo()
        {
            Console.WriteLine("Make : {0} \nModel : {1}\nSpeed : {2}\nEngine Size : {3}", Make, Model, Speed, Size);


        }
        public override string ToString()
        {
            return
                $"Car Make : { Make}" + $"\nCar Model : {Model}" + $"\nCurrent Speed : {Speed}" + $"\nEngine Size : {Size}";
        }
        public void Accelerate()
        {
            Speed += 10;
            Console.WriteLine("Current car speed is {0}", Speed);
        }



    }
}
