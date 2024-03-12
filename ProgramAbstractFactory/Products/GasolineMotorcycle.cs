using ABSTRACTFACTORY.Interfaces;

namespace ABSTRACTFACTORY.Factories;

public class GasolineMotorcycle : IMotorcycle
{
    public string ShowDetails() => "Motocicleta de gasolina";
}
