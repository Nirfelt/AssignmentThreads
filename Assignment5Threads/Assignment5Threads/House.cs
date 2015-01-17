using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment5Threads
{
    public class House
    {
        //Varables
        private const int maxSpots = 20;
        private const int parkStart = 1;
        private const int parkStop = 50;
        private const int qLength = 50;

        private Queue<Car> q1;
        private Queue<Car> q2;
        private Queue<Car> q3;
        private Queue<Car> q4;

        private Car[] house;

        private object lockObj;

        private Random rnd;

        private int count;
        private bool houseFull;

        //Properties
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public int Size
        {
            get { return house.Length; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public House()
        {
            house = new Car[maxSpots];

            q1 = new Queue<Car>();
            q2 = new Queue<Car>();
            q3 = new Queue<Car>();
            q4 = new Queue<Car>();

            lockObj = new object();

            rnd = new Random();

            houseFull = false;
        }

        /// <summary>
        /// Adds car to queue 1
        /// </summary>
        /// <param name="c"></param>
        public void AddToQ1(Car c)
        {
            if (q1.Count < qLength)
            {
                lock (lockObj)
                {
                    q1.Enqueue(c);
                    UpdateConsole();
                }
            }
        }

        /// <summary>
        /// Adds car to queue 2
        /// </summary>
        /// <param name="c"></param>
        public void AddToQ2(Car c)
        {
            if (q2.Count < qLength)
            {
                lock (lockObj)
                {
                    q2.Enqueue(c);
                    UpdateConsole();
                }
            }
        }

        /// <summary>
        /// Adds car to queue 3
        /// </summary>
        /// <param name="c"></param>
        public void AddToQ3(Car c)
        {
            if (q3.Count < qLength)
            {
                lock (lockObj)
                {
                    q3.Enqueue(c);
                    UpdateConsole();
                }
            }
        }

        /// <summary>
        /// Adds car to queue 4
        /// </summary>
        /// <param name="c"></param>
        public void AddToQ4(Car c)
        {
            if (q4.Count < qLength)
            {
                lock (lockObj)
                {
                    q4.Enqueue(c);
                    UpdateConsole();
                }
            }
        }

        /// <summary>
        /// Checks the house for cars to be removed
        /// Sets houseFull = false if car is removed
        /// </summary>
        public void CheckHouse()
        {
            for (int i = 0; i < house.Length; i++)
            {
                lock (lockObj)
                {
                    if (house[i] == null)
                        return;
                    if (!CheckCar(house[i]))
                    {
                        UpdateConsole();
                        house[i] = null;
                        count--;
                        houseFull = false;
                        Monitor.Pulse(lockObj);
                    }
                }
            }
        }

        /// <summary>
        /// Check if a specific car is to be removed
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private bool CheckCar(Car c)
        {
            int result = DateTime.Compare(c.ParkingTime, DateTime.Now);

            if (result <= 0)
                return false;
            else
                return true;
        }

        public void ParkCar(int q)
        {
            switch (q)
            {
                case 1://Queue 1
                    lock (lockObj)
                    {
                        if (q1.Count == 0)
                            return;
                        Car c = q1.Dequeue();
                        while (houseFull)
                            Monitor.Wait(lockObj);
                        int spot;
                        if (FindSpot(out spot))
                        {
                            c.ParkingTime = DateTime.Now.AddSeconds(rnd.Next(parkStart, parkStop));
                            house[spot] = c;
                            UpdateConsole();
                            count++;
                        }
                    }
                    break;
                case 2://Queue 2
                    lock (lockObj)
                    {
                        if (q2.Count == 0)
                            return;
                        Car c = q2.Dequeue();
                        while (houseFull)
                            Monitor.Wait(lockObj);
                        int spot;
                        if (FindSpot(out spot))
                        {
                            c.ParkingTime = DateTime.Now.AddSeconds(rnd.Next(parkStart, parkStop));
                            house[spot] = c;
                            UpdateConsole();
                            count++;
                        }
                    }
                    break;
                case 3://Queue 3
                    lock (lockObj)
                    {
                        if (q3.Count == 0)
                            return;
                        Car c = q3.Dequeue();
                        while (houseFull)
                            Monitor.Wait(lockObj);
                        int spot;
                        if (FindSpot(out spot))
                        {
                            c.ParkingTime = DateTime.Now.AddSeconds(rnd.Next(parkStart, parkStop));
                            house[spot] = c;
                            UpdateConsole();
                            count++;
                        }
                    }
                    break;
                case 4://Queue 4
                    lock (lockObj)
                    {
                        if (q4.Count == 0)
                            return;
                        Car c = q4.Dequeue();
                        while (houseFull)
                            Monitor.Wait(lockObj);
                        int spot;
                        if (FindSpot(out spot))
                        {
                            c.ParkingTime = DateTime.Now.AddSeconds(rnd.Next(parkStart, parkStop));
                            house[spot] = c;
                            UpdateConsole();
                            count++;
                        }
                    }
                    break;
                default:
                    break;
            }

        }

        /// <summary>
        /// Searches house for empty spot
        /// Sets houseFull = true if no spots free
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private bool FindSpot(out int i)
        {
            for (i = 0; i < house.Length; i++)
            {
                lock (lockObj)
                {
                    if (house[i] == null)
                        return true;
                }
            }
            lock (lockObj)
            {
                houseFull = true;
            }
            return false;
        }

        /// <summary>
        /// Writes output to console
        /// </summary>
        private void UpdateConsole()
        {
            string output = string.Empty;
            output += string.Format("++++++++++++++++++++++++Parking House++++++++++++++++++++++++\n");
            output += string.Format("+                                                           +\n");
            output += string.Format("+                        Queue 1: {0, -3}                       +\n", q1.Count.ToString());
            output += string.Format("+                        Queue 2: {0, -3}                       +\n", q2.Count.ToString());
            output += string.Format("+                        Queue 3: {0, -3}                       +\n", q3.Count.ToString());
            output += string.Format("+                        Queue 4: {0, -3}                       +\n", q4.Count.ToString());
            output += string.Format("+                     Free spots: {0, -5}                     +\n", (maxSpots - count).ToString());
            output += string.Format("+                                                           +\n");
            output += string.Format("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n\n");
            output += string.Format("Spots: {0}\n", maxSpots.ToString());
            output += string.Format("Parking time: {0} - {1} seconds\n", parkStart.ToString(), parkStop.ToString());
            output += string.Format("Max queue length: {0} cars\n\n", qLength.ToString());
            output += string.Format("Author: Sebastian Nirfelt\n\n");
            output += string.Format("Press any key to exit...");
            Console.Clear();
            Console.WriteLine(output);
        }
    }
}
