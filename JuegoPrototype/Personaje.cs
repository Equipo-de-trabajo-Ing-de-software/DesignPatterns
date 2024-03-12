using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPrototype
{
    [Serializable]
    public abstract class Personaje : IPrototipo<Personaje>
    {
        public string Nombre { get; set; }
        public int Vida { get; set; }

        protected Personaje(string nombre, int vida)
        {
            Nombre = nombre;
            Vida = vida;
        }

        public virtual Personaje Clone()
        {
            return (Personaje)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"{Nombre} (Vida: {Vida})";
        }
    }
}