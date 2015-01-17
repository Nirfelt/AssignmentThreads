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
        //Variables
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

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="house"></param>
        public CarGenerator(House house)
        {
            this.house = house;
            rnd = new Random();

            t1 = new Task(new Action(genQ1));
            t2 = new Task(new Action(genQ2));
            t3 = new Task(new Action(genQ3));
            t4 = new Task(new Action(genQ4));
        }

        /// <summary>
        /// Starts tasks in CarGenerator
        /// </summary>
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

        /// <summary>
        /// Stops tasks
        /// </summary>
        public void Stop()
        {
            gen1 = false;
            gen2 = false;
            gen3 = false;
            gen4 = false;
        }

        /// <summary>
        /// Generates cars for queue 1
        /// </summary>
        private void genQ1()
        {
            while (gen1)
            {
                Thread.Sleep(rnd.Next(intervalStart, intervalStop));
                house.AddToQ1(new Car());
            }
        }

        /// <summary>
        /// Generates cars for queue 2
        /// </summary>
        private void genQ2()
        {
            while (gen2)
            {
                Thread.Sleep(rnd.Next(intervalStart, intervalStop));
                house.AddToQ2(new Car());
            }
        }

        /// <summary>
        /// Generates cars for queue 3
        /// </summary>
        private void genQ3()
        {
            while (gen3)
            {
                Thread.Sleep(rnd.Next(intervalStart, intervalStop));
                house.AddToQ3(new Car());
            }
        }

        /// <summary>
        /// Generates cars for queue 4
        /// </summary>
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
