using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5Threads
{
    public class Car
    {
        //Variables
        private DateTime parkingTime;

        //Properties
        public DateTime ParkingTime
        {
            get { return parkingTime; }
            set { parkingTime = value; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Car()
        {
            parkingTime = DateTime.Now;
        }
    }
}
