using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "";
            p1.IncreseCount();

            Person p2 = new Person();
            p2.IncreseCount();

            Console.WriteLine(Person.Count);
            Person.Print("Nimur") ;
            Console.ReadKey();
            


        }
    }
}
