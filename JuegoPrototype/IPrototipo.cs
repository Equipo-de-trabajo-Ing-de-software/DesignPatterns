using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPrototype
{
    public interface IPrototipo<T>
    {
        T Clone();
    }
}
