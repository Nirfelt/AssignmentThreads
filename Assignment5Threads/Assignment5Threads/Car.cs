using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5Threads
{
    public class Car
    {
        private DateTime parkingTime;
        private Brands brand;
        private Colors color;
        private Random rnd;

        public Colors Color
        {
            get { return color; }
        }

        public Brands Brand
        {
            get { return brand; }
        }

        public DateTime ParkingTime
        {
            get { return parkingTime; }
            set { parkingTime = value; }
        }

        public Car()
        {
            rnd = new Random();
            color = (Colors)rnd.Next(0, Enum.GetNames(typeof(Colors)).Length);
            brand = (Brands)rnd.Next(0, Enum.GetNames(typeof(Brands)).Length);
            parkingTime = DateTime.Now;
        }
    }
}
