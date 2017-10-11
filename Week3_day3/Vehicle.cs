using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_day3
{
    class Vehicle
    {
        private int seats;
        private int carryingCapacity;
        private String color;
        private double moveSpeed;
        private float gearRatio;
        private float engineSize;
        private double distanceTraveled;

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



        public void Move()
        {
            distanceTraveled += moveSpeed;
        }













    }
}
