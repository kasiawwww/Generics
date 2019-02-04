using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        class Person
        {
            public int Name { get; set; }
        }
        static void Main(string[] args)
        {
            //ShowType<string> str = new ShowType<string>();
            //ShowType<int> intObject = new ShowType<int>(); //int -> typ wartościowy

            //str.Show();
            //intObject.Show();

            int a = 1;
            int b = 2;

            GenericMethods genericsMethods = new GenericMethods();
            int c = genericsMethods.GetSum<int>(a, b);
            int c1 = genericsMethods.GetSum(a, b);

            Console.WriteLine(c);
            Console.WriteLine(c1);

            string aa = "kasia";
            string bb = " asia";

            GenericMethods genericsMethods1 = new GenericMethods();
            string c3 = genericsMethods1.GetSum<string>(aa, bb);
            string c4 = genericsMethods1.GetSum(aa, bb);

            var genericMethods = new GenericMethods();
            Person p = genericsMethods.ReturnT<Person>();
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.Read();
        }
    }
}
