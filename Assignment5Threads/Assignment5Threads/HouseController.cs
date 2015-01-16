using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5Threads
{
    public class HouseController
    {
        private bool q1;
        private bool q2;
        private bool q3;
        private bool q4;

        private Task t1;
        private Task t2;
        private Task t3;
        private Task t4;
        private Task t5;

        private House house;

        public HouseController(House house)
        {
            q1 = true;
            q2 = true;
            q3 = true;
            q4 = true;

            this.house = house;
        }

        public void Start()
        {
            t1 = new Task(new Action(ParkQ1));
            t2 = new Task(new Action(ParkQ2));
            t3 = new Task(new Action(ParkQ3));
            t4 = new Task(new Action(ParkQ4));
            t5 = new Task(new Action(RemoveCars));
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
        }

        private void ParkQ1()
        {
            while (q1)
            {
                house.ParkCar(1);
            }
        }

        private void ParkQ2()
        {
            while (q2)
            {
                house.ParkCar(2);
            }
        }

        private void ParkQ3()
        {
            while (q3)
            {
                house.ParkCar(3);
            }
        }

        private void ParkQ4()
        {
            while (q4)
            {
                house.ParkCar(4);
            }
        }

        private void RemoveCars()
        {
            while (true)
            {
                house.CheckHouse();
            }
        }
    }
}
