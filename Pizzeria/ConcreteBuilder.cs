using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class ConcreteBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();

        public void Reset()
        {
            _pizza = new Pizza();
        }

        public void BuildMasa(string type)
        {
            _pizza.Masa = type;
        }

        public void BuildSalsa(string type)
        {
            _pizza.Salsa = type;
        }

        public void BuildQueso(string type)
        {
            _pizza.Queso = type;
        }

        public void AddTopping(string topping)
        {
            _pizza.Toppings.Add(topping);
        }

        public Pizza GetPizza()
        {
            Pizza result = _pizza;
            Reset(); 
            return result;
        }
    }
}
