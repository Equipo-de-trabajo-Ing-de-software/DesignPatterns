namespace ABSTRACTFACTORY.Interfaces
{
    public interface IVehicleFactory
    {
        ICar CreateCar();
        IMotorcycle CreateMotorcycle();
    }
}
