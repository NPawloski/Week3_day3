using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_day3
{
    abstract class Vehicle
    {
        protected int seats;
        protected int carryingCapacity;
        protected String color;
        protected double moveSpeed;
        private float gearRatio;
        private float engineSize;
        protected double distanceTraveled;

        public int Seats
        {
            get { return this.seats; }
        }

        public int CarryingCapacity
        {
            get { return this.carryingCapacity; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }



        public double DistanceTraveled
        {
            get { return this.distanceTraveled; }
        }



        public Vehicle()
        {
        }

        public Vehicle(int seats, int carryingCapacity, string color, double moveSpeed)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.moveSpeed = moveSpeed;
            this.distanceTraveled = 0.0d;

        }



        public virtual void Move()
        {
            distanceTraveled += moveSpeed;
        }


        public virtual string GetDistanceTraveled()
        {
            return "Distance traveled: " + distanceTraveled + "\n";
        }










    }
}
