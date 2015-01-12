using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment4Threads
{
    public class ToyFactory
    {
        //Variables
        private Buffer buffer;
        private Random rnd;
        private object lockObj;
        //Toy-info
        private string[] toyNames = {   "Doll", "Pony", "Car", "Raspberry PI", "Teddybear", "Playstation", "Xbox",
                                        "Cookie", "Puppy", "Tie", "LEGO", "Magazine", "Chessboard", "Fryingpan",
                                        "Movies", "Slippers", "Pillow", "Book", "Alarmclock", "C# guidebook", "Gym-membership"};
        private int[] weights = {   3, 300, 2, 1, 4, 5, 5,
                                    1, 7, 1, 5, 1, 2, 12,
                                    2, 3, 2, 2, 3, 72, 1 };
        private int[] volumes = {    5, 200, 4, 1, 5, 6, 6,
                                    1, 13, 1, 9, 3, 4, 7,
                                    6, 4, 15, 6, 6, 6, 1 };

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="lockObj"></param>
        public ToyFactory(Buffer buffer, object lockObj)
        {
            this.buffer = buffer;
            rnd = new Random();
            this.lockObj = lockObj;
        }

        /// <summary>
        /// Synchronized genaretion of toys for santas bag
        /// </summary>
        public void GenerateToys()
        {
            while (true)
            {
                lock (lockObj)
                {
                    while (buffer.BagFull)
                        Monitor.Wait(lockObj);
                    buffer.AddToys(CreateToy());
                    Monitor.Pulse(lockObj);
                }
                Thread.Sleep(rnd.Next(300, 1000));
            }
        }

        /// <summary>
        /// Creates a random toy
        /// </summary>
        /// <returns></returns>
        private Toy CreateToy()
        {
            int n = rnd.Next(0, toyNames.Length);
            Toy toy = new Toy(toyNames[n], weights[n], volumes[n]);
            return toy;
        }
    }
}
