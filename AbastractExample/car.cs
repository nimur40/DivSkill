using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastractExample
{
    class car : Vehical
    {
        public override void Start()
        {
            Console.WriteLine("car starting");
        }

        public override void Stop()
        {
            Console.WriteLine("car stoping");
        }
    }
}
