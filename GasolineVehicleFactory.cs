using ABSTRACTFACTORY.Interfaces;
using ABSTRACTFACTORY.Products;

namespace ABSTRACTFACTORY.Factories
{
    public class GasolineVehicleFactory : IVehicleFactory
    {
        public ICar CreateCar() => new GasolineCar();
        public IMotorcycle CreateMotorcycle() => new GasolineMotorcycle();
    }
}
