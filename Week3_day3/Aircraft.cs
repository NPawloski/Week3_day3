using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_day3
{
    class Aircraft :Vehicle
    {

        private double altitude;

        public Aircraft()
        {

        }
         
        public Aircraft(int seats,int carryingCapacity,string color, double moveSpeed)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.moveSpeed = moveSpeed;

            this.altitude = 0.0d;
        }








    }
}
