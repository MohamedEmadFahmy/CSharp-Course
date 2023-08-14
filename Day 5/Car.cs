using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_5
{
    public class Car : IComparable, ICloneable
    {
        int id;
        string model;
        int currentSpeed;

        public int Id { get => id; set => id = value; }
        public string Model { get => model; set => model = value; }
        public int CurrentSpeed { get => currentSpeed; set => currentSpeed = value; }



        public Car(int id, string model, int currentSpeed)
        {
            this.id = id;
            this.model = model;
            this.currentSpeed = currentSpeed;
        }
        public Car(int id, string model) : this(id, model, 60)
        {
            // this.id = id;
            // this.model = model;
            // this.currentSpeed = 60;
        }
        public Car(int id) : this(id, "Fiat", 60)
        {
            // this.id = id;
            // this.model = "Fiat";
            // this.currentSpeed = 60;
        }
        public Car(Car oldCar)
        {
            this.id = oldCar.id;
            this.model = oldCar.model;
            this.currentSpeed = oldCar.currentSpeed;
        }



        public override string ToString()
        {
            return $"{id}::{model}::{currentSpeed}";
        }

        public int CompareTo(object? obj)
        {
            Car right = (Car)obj;

            return this.currentSpeed.CompareTo(right?.currentSpeed);
        }

        public object Clone()
        {
            return new Car(this);
            // return new Car(id, model, currentSpeed);
        }
    }
}