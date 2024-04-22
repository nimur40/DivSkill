using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class Car
    {
        public void Stop()
        {
            Console.WriteLine("stoping");
        }

        public void Start()
        {
            Console.WriteLine("starting");
        }
        public void PrintColor()
        {
            Console.WriteLine(Color);
        }
    }
}
