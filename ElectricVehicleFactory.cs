using ABSTRACTFACTORY.Interfaces;
using ABSTRACTFACTORY.Products;

namespace ProjectRoot.Factories
{
    public class ElectricVehicleFactory : IVehicleFactory
    {
        public ICar CreateCar() => new ElectricCar();
        public IMotorcycle CreateMotorcycle() => new ElectricMotorcycle();
    }
}
