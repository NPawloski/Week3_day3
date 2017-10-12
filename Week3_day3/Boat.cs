using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_day3
{
    class Boat : Vehicle
    {
        private double waterDrag;


        public Boat()
        {

        }

        public Boat(int seats,int carryingCapacity,String color,double moveSpeed,double waterDrag)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.moveSpeed = moveSpeed;
            this.waterDrag = waterDrag;
        }

        public override void Move()
        {
            distanceTraveled += moveSpeed * waterDrag;
        }





    }
}
