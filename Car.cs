using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car machine = new Car("BMW","A102","Red",200);
            Console.WriteLine(machine.Info());

            Car vehicle = new Bus("BMW", "A102", "Red",150,20);
            Console.WriteLine(vehicle.Info());
        }
    }
    class Car
    {
        public string Brand;
        public string Model;
        public string Color;
        public int MaxSpeed;

        public Car()
        {
            Console.WriteLine("Car Created");
        }

        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }
        public Car(string brand, string model, string color, int maxSpeed):this(brand,model)
        { 
            Color = color;
            MaxSpeed = maxSpeed;
        }

        public virtual string Info()
        {
            return $"Marka: {Brand} Model: {Model}  Color: {Color} Maximum Speed: {MaxSpeed}";
        }

    }

    class Bus:Car
    {
        public int PassengerCount;
        public Bus(string brand, string model, string color, int maxSpeed,int passengerCount):base(brand, model, color, maxSpeed)
        {
            PassengerCount = passengerCount;
        }

        public override string Info()
        {
            return $"Marka: {Brand} Model: {Model}  Color: {Color} Maximum Speed: {MaxSpeed} Passenger Count : {PassengerCount}";
        }
    }
}
