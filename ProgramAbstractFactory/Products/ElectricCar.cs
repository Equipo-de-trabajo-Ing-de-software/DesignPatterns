using ABSTRACTFACTORY.Interfaces;

namespace ABSTRACTFACTORY.Products
{
    public class ElectricCar : ICar
    {
        public string ShowDetails() => "Carro eléctrico";
    }
}