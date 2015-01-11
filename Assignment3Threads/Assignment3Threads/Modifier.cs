/*
 * Author: Sebastian Nirfelt
 * Date: 2015-01-11
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment3Threads
{
    public class Modifier
    {
        //Variables
        private int count;
        private CircleBuffer buffer;

        /// <summary>
        /// Constructor
        /// Gets input variables
        /// </summary>
        /// <param name="bufferIn"></param>
        /// <param name="nrOfStrings"></param>
        public Modifier(CircleBuffer bufferIn, int nrOfStrings)
        {
            this.count = nrOfStrings;
            this.buffer = bufferIn;
        }

        /// <summary>
        /// Loops buffer.ModifyData()
        /// </summary>
        public void Modify()
        {
            for (int i = 0; i < count; i++)
            {
                buffer.ModifyData();
            }
        }
    }
}
