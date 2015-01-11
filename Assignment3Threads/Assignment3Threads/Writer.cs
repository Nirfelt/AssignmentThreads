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
    public class Writer
    {
        //Variables
        private List<string> textToWrite;
        private CircleBuffer buffer;

        /// <summary>
        /// Constructor
        /// Gets input variables
        /// </summary>
        /// <param name="bufferIn"></param>
        /// <param name="textIn"></param>
        public Writer(CircleBuffer bufferIn, List<string> textIn)
        {
            this.textToWrite = textIn;
            this.buffer = bufferIn;
        }

        /// <summary>
        /// Loops buffer.WriteData()
        /// </summary>
        public void Write()
        {
            for (int i = 0; i < textToWrite.Count; i++)
            {
                buffer.WriteData(textToWrite[i]);
            }
        }
    }
}
