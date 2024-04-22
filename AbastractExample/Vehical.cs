using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastractExample
{
    public abstract class Vehical
    {
        public string Color { set; get; }
        public string Speed { set; get; }
        public string PannengerCount { set; get; }
        public string Weight { set; get; }

        public abstract void Start();
        public abstract void Stop();

        public void Wash()
        {
            Console.WriteLine("washing") ;
        }

    }
}
