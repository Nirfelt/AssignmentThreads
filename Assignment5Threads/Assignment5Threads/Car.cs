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

        public DateTime ParkingTime
        {
            get { return parkingTime; }
            set { parkingTime = value; }
        }

        public Car()
        {
            parkingTime = DateTime.Now;
        }
    }
}
