using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<School> schools = new List<School>();

            for(int i =0; i < 5; i++)
            {
                Console.Write("Please enter a school name : ");
                string name = Console.ReadLine();

                Console.Write("How many students are enrolled : ");
                int num = Convert.ToInt32(Console.ReadLine());

                schools.Add(new School(name,num));
                
            }

            schools.Sort();

            for(int i =0; i < 5;i++)
            {
                Console.WriteLine("{0} school has {1} students",schools[i].SchoolName,schools[i].NumberStudents);
            }
                
            

        }
       
    }
}
