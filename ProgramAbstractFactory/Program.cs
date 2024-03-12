using ABSTRACTFACTORY.Factories;
using ABSTRACTFACTORY.Interfaces;
using ProgramAbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramAbstractFactory
{
    internal class Program
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
