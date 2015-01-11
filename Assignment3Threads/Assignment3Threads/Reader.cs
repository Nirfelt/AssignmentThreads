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
    public class Reader
    {
        //Variables
        private int count;
        private CircleBuffer buffer;
        private List<string> stringlist;
        public event EventHandler<ReaderDone> Done;

        /// <summary>
        /// Constructor
        /// Sets inputvariables
        /// </summary>
        /// <param name="bufferIn"></param>
        /// <param name="nrOfStrings"></param>
        public Reader(CircleBuffer bufferIn, int nrOfStrings)
        {
            this.count = nrOfStrings;
            this.buffer = bufferIn;
            this.stringlist = new List<string>();
        }

        /// <summary>
        /// Loops buffer.ReadData()
        /// Casts event on finish
        /// </summary>
        public void Read()
        {
            for (int i = 0; i < count; i++)
            {
                stringlist.Add(buffer.ReadData());
            }
            OnDone(new ReaderDone(stringlist));
        }

        /// <summary>
        /// Event to be cast on finish
        /// </summary>
        /// <param name="e"></param>
        public void OnDone(ReaderDone e)
        {
            if (Done != null)
                Done(this, e);
        }
    }
}
