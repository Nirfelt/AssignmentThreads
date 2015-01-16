using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment5Threads
{
    public class CarGenerator
    {
        private const int intervalStart = 500;
        private const int intervalStop = 2000;

        private House house;
        private Task t1;
        private Task t2;
        private Task t3;
        private Task t4;
        private Random rnd;

        private bool gen1;
        private bool gen2;
        private bool gen3;
        private bool gen4;

        public CarGenerator(House house)
        {
            this.house = house;
            rnd = new Random();

            t1 = new Task(new Action(genQ1));
            t2 = new Task(new Action(genQ2));
            t3 = new Task(new Action(genQ3));
            t4 = new Task(new Action(genQ4));
        }

        public void Start()
        {
            gen1 = true;
            gen2 = true;
            gen3 = true;
            gen4 = true;
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
        }

        public void Stop()
        {
            gen1 = false;
            gen2 = false;
            gen3 = false;
            gen4 = false;
        }

        private void genQ1()
        {
            while (gen1)
            {
                Thread.Sleep(rnd.Next(intervalStart, intervalStop));
                house.AddToQ1(new Car());
            }
        }

        private void genQ2()
        {
            while (gen2)
            {
                Thread.Sleep(rnd.Next(intervalStart, intervalStop));
                house.AddToQ2(new Car());
            }
        }

        private void genQ3()
        {
            while (gen3)
            {
                Thread.Sleep(rnd.Next(intervalStart, intervalStop));
                house.AddToQ3(new Car());
            }
        }

        private void genQ4()
        {
            while (gen4)
            {
                Thread.Sleep(rnd.Next(intervalStart, intervalStop));
                house.AddToQ4(new Car());
            }
        }
    }
}
