using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_day3
{
    class Automobile : Vehicle
    {

        private int numberOfWheels;
        private float wheelSize;
        private int numberOfDoors;

        public int NumberOfWheels
        {
            get { return this.numberOfWheels; }
        }


        public Automobile()
        {

        }

        public Automobile(int numberOfWheels, float wheelSize, int numberOfDoors, int seats, int carryingCapacity, String color, double moveSpeed)
        {
            //these fields belong to automobile class
            this.numberOfWheels = numberOfWheels;
            this.wheelSize = wheelSize;
            this.numberOfDoors = numberOfDoors;
            //these fields belong to vehicle class
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.moveSpeed = moveSpeed;
        }


    }
}
