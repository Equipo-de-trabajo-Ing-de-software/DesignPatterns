using System;


namespace Program
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");
            IVehicleFactory gasolineFactory = new GasolineVehicleFactory();
            ICar gasolineCar = gasolineFactory.CreateCar();
            IMotorcycle gasolineMotorcycle = gasolineFactory.CreateMotorcycle();

            Console.WriteLine(gasolineCar.ShowDetails());
            Console.WriteLine(gasolineMotorcycle.ShowDetails());

            IVehicleFactory electricFactory = new ElectricVehicleFactory();
            ICar electricCar = electricFactory.CreateCar();
            IMotorcycle electricMotorcycle = electricFactory.CreateMotorcycle();

            Console.WriteLine(electricCar.ShowDetails());
            Console.WriteLine(electricMotorcycle.ShowDetails());
        }
    }
}
