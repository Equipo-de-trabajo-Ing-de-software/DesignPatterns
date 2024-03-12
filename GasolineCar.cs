using ABSTRACTFACTORY.Interfaces;

namespace ABSTRACTFACTORY.Products
{
    public class GasolineCar : ICar
    {
        public string ShowDetails() => "Carro de gasolina";
    }
}
