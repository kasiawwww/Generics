using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenericMethods
    {
        public T GetSum<T> (T first, T second)
        {
            dynamic f = first;
            dynamic s = second;
            return f + s;
        }

        public T ReturnT<T>() where T : new() //new() -> obiekt klasy która ma konstruktor bezparametrowy
        {
            return new T();
        }
    }
}
