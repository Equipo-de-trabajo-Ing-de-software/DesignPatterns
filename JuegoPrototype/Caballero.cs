using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPrototype
{
    public class Caballero : Personaje
    {
        public int Armadura { get; private set; }

        public Caballero(string nombre, int vida, int armadura) : base(nombre, vida)
        {
            Armadura = armadura;
        }

        public override Personaje Clone()
        {
            return (Personaje)this.MemberwiseClone();
        }
    }
}