using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2Threads
{
    /// <summary>
    /// Class handling the readerthread
    /// </summary>
    public class Reader
    {
        //variables
        private CharacterBuffer cBuffer;
        private int size;
        private Random rnd;
        private string output;
        public event EventHandler<ReaderDone> Done;

        /// <summary>
        /// Constructor that sets inputvalues for reader
        /// </summary>
        /// <param name="cBuffer"></param>
        /// <param name="size"></param>
        public Reader(CharacterBuffer cBuffer, int size)
        {
            this.cBuffer = cBuffer;
            this.size = size;
            rnd = new Random();
            output = string.Empty;
        }

        /// <summary>
        /// Method handling synchronized reading
        /// </summary>
        public void Read()
        {
            for (int i = 0; i < size; i++)
            {
                char c = cBuffer.Read();
                output += c.ToString();
                Thread.Sleep(rnd.Next(100, 200));
            }
            OnDone(new ReaderDone(output));
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
