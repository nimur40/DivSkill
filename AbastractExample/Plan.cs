using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastractExample
{
    class Plan : Vehical
    {
        public override void Start()
        {
            Console.WriteLine("Plan is starting");
        }

        public override void Stop()
        {
            Console.WriteLine("plan is stoping");
        }
    }
}
