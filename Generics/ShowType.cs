using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class ShowType<T> where T : class
    {
        public void Show()
        {
            Console.WriteLine(typeof(T));
        }


    }
}
