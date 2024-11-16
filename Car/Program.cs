using System;

namespace DGD203
{ 
    public class Car
    {
        public Car(SummerTires, WinterTires, fuel capacity)
 
    {
        void ApplyTireEffect();
    }

    public class SummerTires : ITires
    {
        public void ApplyTireEffect() => Console.WriteLine("Summer tires: Good grip on dry roads.");
    }

    public class WinterTires : ITires
    {
        public void ApplyTireEffect() => Console.WriteLine("Winter tires: Better grip on snow and ice.");
    }

    public class FuelTank
    {
        public float Capacity { get; private set; }
        public float CurrentFuel { get; private set; }

        public FuelTank(float capacity)
        {
            Capacity = capacity;
            CurrentFuel = capacity; // Full tank by default
        }
  
    public class Car
    {
        private FuelTank fuelTank;
        private ITires tires;
        private Drivetrain drivetrain;
        private float speed;

        public string Model { get; private set; }

        public Car(string model, float fuelCapacity, string drivetrainType, ITires tireType)
        {
            Model = model;
            fuelTank = new FuelTank(fuelCapacity);
            drivetrain = new Drivetrain(drivetrainType);
            tires = tireType;
            speed = 0f;
        }
        public void Brake(float amount)
        {
            speed = Math.Max(0, speed - amount);
            Console.WriteLine($"Braking: Speed is now {speed} km/h.");
        }

        public void Drive()
        {
            drivetrain.Drive();
            tires.ApplyTireEffect();
        }

        public void Refuel(float amount)
        {
            fuelTank.Refuel(amount);
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Create a car with winter tires and a front-wheel drive drivetrain
            var car = new Car("SportyCar", 50, "Front-Wheel Drive", new WinterTires());

            // Run the car's actions
            car.Drive();
            car.Accelerate(20); // Accelerate by 20 km/h
            car.Brake(10); // Brake by 10 km/h
            car.Refuel(10); // Refuel with 10 liters of fuel
            car.Accelerate(30); // Accelerate by 30 km/h
        }
            }