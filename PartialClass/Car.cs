using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class Car
    {
        public string Color { get; set; }
        public string Name { get; set; }

        public Car()
        {
            Color = "red";
        }
    }
}
