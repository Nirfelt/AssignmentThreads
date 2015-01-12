using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4Threads
{
    public class Toy
    {
        //Variables
        private string name;
        private int weight;
        private int volume;

        //Properties
        public string Name
        {
            get { return name; }
        }
        
        public int Weight
        {
            get { return weight; }
        }
        
        public int Volume
        {
            get { return volume; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="weight"></param>
        /// <param name="volume"></param>
        public Toy(string name, int weight, int volume)
        {
            this.name = name;
            this.weight = weight;
            this.volume = volume;
        }
    }
}
