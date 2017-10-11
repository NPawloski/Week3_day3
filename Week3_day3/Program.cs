using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_day3
{
    class Program
    {
        static void Main(string[] args)
        {

            Vehicle Dinghy = new Vehicle(4, 500, "Red", 12.4);


            Dinghy.Move();
            Dinghy.Move();
            Console.WriteLine(Dinghy.DistanceTraveled);
            





        }
    }
}
