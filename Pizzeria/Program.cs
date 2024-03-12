namespace Pizzeria
{
    internal class Program
    {
        //Se requeire poder crear pizzas personbalizadas, el cliente debe poder escoger la masa, la salsa, el tipo de queso 
        //y puede ponerle todos los toppings que quiera

        //el patrón Builder aplica en este caso porque permite crear multiples objetos complejos paso a paso, se pueden construir 
        //difertentes tipos  y representaciones de ese mismo objeto usando el mismo código
        
        static void Main(string[] args)
        {
            var builder = new ConcreteBuilder();

            builder.BuildMasa("Gruesa");
            builder.BuildSalsa("Pasta Tomate");
            builder.BuildQueso("Mozzarella");
            builder.AddTopping("Pollo");
            builder.AddTopping("Cebolla");
           
            var customPizza = builder.GetPizza();
            Console.WriteLine("Pizz Personalizada: " + customPizza);
        }
    }
}
