using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastractExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehical vehical = new car();
            vehical.Color = "red";
            vehical.Start();

            Plan plan = new Plan();
            plan.Start();
            Console.ReadKey();

            var type = Console.ReadLine();
            //Vehical v = GetVehicle(type);

            //Vehical GetVehicle(string type)
            //{
            //    if (type == "car")
            //        return new car();
            //    else
            //        return new Plan();
                
            //}
        }
    }
}
