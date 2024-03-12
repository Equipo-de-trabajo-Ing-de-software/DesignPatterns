namespace Pizzeria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConcreteBuilder();

            builder.BuildMasa("Thin Crust");
            builder.BuildSalsa("Barbecue");
            builder.BuildQueso("Cheddar");
            builder.AddTopping("Chicken");
            builder.AddTopping("Onions");
           
            var customPizza = builder.GetPizza();
            Console.WriteLine("Custom Pizza: " + customPizza);
        }
    }
}
