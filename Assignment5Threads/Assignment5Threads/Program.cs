using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5Threads
{
    public class Program
    {
        

        static void Main(string[] args)
        {
            House house = new House();
            HouseController hc = new HouseController(house);
            CarGenerator cg = new CarGenerator(house);

            hc.Start();
            cg.Start();

            Console.ReadKey();
        }
    }
}
