using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public interface IPizzaBuilder
    {
        void Reset();
        void BuildMasa(string type);
        void BuildSalsa(string type);
        void BuildQueso(string type);
        void AddTopping(string topping);
        Pizza GetPizza();
    }
}
