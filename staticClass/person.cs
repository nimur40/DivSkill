using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticClass
{
    class Person
    {
        public string Name { set; get; }
        public static int Count { set; get; }

        public void IncreseCount()
        {
            Count++;
        }
        public static void Print( string message) 
        {
            Console.WriteLine(message);
        }
    }
}
