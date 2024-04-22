using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public interface IEngine
    {
         string Model { set; get; }
        void Start();
        void Stop();

        //defult implementation
        public double GetSpeed()
        {
            return 0;
        }

    }
}
