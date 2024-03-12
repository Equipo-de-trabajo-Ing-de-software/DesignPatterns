using ABSTRACTFACTORY.Interfaces;
using ABSTRACTFACTORY.Products;

namespace ProgramAbstractFactory.Factories
{
    public class ElectricVehicleFactory : IVehicleFactory
    {
        public ICar CreateCar() => new ElectricCar();
        public IMotorcycle CreateMotorcycle() => new ElectricMotorcycle();
    }
}
