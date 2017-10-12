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

            //Vehicle Dinghy = new Vehicle(4, 500, "Red", 12.4);

            //Dinghy.Move();
            //Dinghy.Move();
            //Console.WriteLine(Dinghy.DistanceTraveled);


            Automobile Jane = new Automobile(4, 19, 5, 5, 1500, "Black", 100d);
            Jane.Move();
            Jane.Move();
            Console.WriteLine("Car " + Jane.GetDistanceTraveled());

            Boat Boaty = new Boat(2, 500, "red", 88.0d, .9d);
            Boaty.Move();
            Boaty.Move();
            Console.WriteLine("Boat " + Boaty.GetDistanceTraveled());


            Aircraft aircraft1 = new Aircraft(70, 10000, "grey", 600);

            aircraft1.Move();
            aircraft1.Move();
            Console.WriteLine("Aircraft " + aircraft1.GetDistanceTraveled());










        }
    }
}
