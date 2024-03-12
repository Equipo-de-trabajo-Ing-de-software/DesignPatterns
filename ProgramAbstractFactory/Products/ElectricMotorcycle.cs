using ABSTRACTFACTORY.Interfaces;

namespace ABSTRACTFACTORY.Products
{
    public class ElectricMotorcycle : IMotorcycle
    {
        public string ShowDetails() => "Motocicleta eléctrica";
    }
}