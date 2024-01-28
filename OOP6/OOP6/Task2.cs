using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6
{
    public abstract class Vehicle
    {
        protected int maxSpeed;
        protected string type;

        public Vehicle(int maxSpeed, string type)
        {
            this.maxSpeed = maxSpeed;
            this.type = type;
        }

        public int GetMaxSpeed()
        {
            return this.maxSpeed;
        }

        public string GetType()
        {
            return this.type;
        }

        public abstract double CalculateAllowedSpeed();
    }

    public class Car : Vehicle
    {
        public Car(int maxSpeed) : base(maxSpeed, "Машина")
        {
        }

        public override double CalculateAllowedSpeed()
        {
            return GetMaxSpeed() * 0.8;
        }
    }

    public class Bus : Vehicle
    {
        public Bus(int maxSpeed) : base(maxSpeed, "Автобус")
        {
        }

        public override double CalculateAllowedSpeed()
        {
            return GetMaxSpeed() * 0.6;
        }
    }

    public class SpeedCalculation
    {
        public double CalculateAllowedSpeed(Vehicle vehicle)
        {
            return vehicle.CalculateAllowedSpeed();
        }
    }
}
