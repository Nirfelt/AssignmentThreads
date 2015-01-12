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
    /// Class to handle writing to buffer
    /// </summary>
    public class Writer
    {
        //Variables
        private CharacterBuffer cBuffer;
        private char[] cToWrite;
        Random rnd;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="cBuffer"></param>
        /// <param name="c"></param>
        public Writer(CharacterBuffer cBuffer, char[] c)
        {
            this.cBuffer = cBuffer;
            this.cToWrite = c;
            rnd = new Random();
        }

        /// <summary>
        /// Method for handling synchonized writing to buffer
        /// </summary>
        public void Write()
        {
            for (int i = 0; i < cToWrite.Length; i++)
            {
                cBuffer.Write(cToWrite[i]);
                Thread.Sleep(rnd.Next(100, 200));
            }
        }
    }
}
