using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class Pizza
    {
        public string Masa { get; set; }
        public string Salsa { get; set; }
        public string Queso { get; set; }
        public List<string> Toppings { get; set; } = new List<string>();

        public override string ToString()
        {
            return $"Massa: {Masa}, Slasa: {Salsa}, Queso: {Queso}, Toppings: {string.Join(", ", Toppings)}";
        }
    }
}
