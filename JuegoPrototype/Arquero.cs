using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPrototype
{
    
    public class Arquero : Personaje
    {
        public int RangoAtaque { get; private set; }

        public Arquero(string nombre, int vida, int rangoAtaque) : base(nombre, vida)
        {
            RangoAtaque = rangoAtaque;
        }

      
        public override Personaje Clone()
        {
            return (Personaje)this.MemberwiseClone();
        }
    }
}
