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
        private Object lockObj;
        private CharacterBuffer cBuffer;
        private char[] cToWrite;
        Random rnd;
        ListBox lstbWriter;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="lockObj"></param>
        /// <param name="cBuffer"></param>
        /// <param name="c"></param>
        /// <param name="lstbWriter"></param>
        public Writer(Object lockObj, CharacterBuffer cBuffer, char[] c, ListBox lstbWriter)
        {
            this.lockObj = lockObj;
            this.cBuffer = cBuffer;
            this.cToWrite = c;
            rnd = new Random();
            this.lstbWriter = lstbWriter;
        }

        /// <summary>
        /// Method for handling synchonized writing to buffer
        /// </summary>
        public void WriteSync()
        {
            for (int i = 0; i < cToWrite.Length; i++)
            {
                lock(lockObj)
                {
                    if (cBuffer.DataExists) AddToListBox();
                    while (cBuffer.DataExists)
                        Monitor.Wait(lockObj);

                    cBuffer.Write(cToWrite[i]);
                    AddToListBox(cToWrite[i]);
                    Monitor.Pulse(lockObj);
                }
                Thread.Sleep(rnd.Next(100, 300));
            }
        }

        /// <summary>
        /// Method handling asynchronous writing to buffer
        /// </summary>
        public void WriteAsync()
        {
            for (int i = 0; i < cToWrite.Length; i++)
            {
                lock (lockObj)
                {
                    cBuffer.Write(cToWrite[i]);
                    AddToListBox(cToWrite[i]);
                }
                Thread.Sleep(rnd.Next(100, 200));
            }
        }

        /// <summary>
        /// Adds a trying to write string to listbox
        /// </summary>
        private void AddToListBox()
        {
            string output = "Trying to write. Data exists. Writer waits";
            if (lstbWriter.InvokeRequired)
            {
                lstbWriter.Invoke(new MethodInvoker(delegate
                {
                    lstbWriter.Items.Add(output);
                }));
            }
            else
            {
                lstbWriter.Items.Add(output);
            } 
        }

        /// <summary>
        /// Adds a value to listbox
        /// </summary>
        /// <param name="c"></param>
        private void AddToListBox(char c)
        {
            string output = "Writing " + c.ToString();
            if (lstbWriter.InvokeRequired)
            {
                lstbWriter.Invoke(new MethodInvoker(delegate
                {
                    lstbWriter.Items.Add(output);
                }));
            }
            else
            {
                lstbWriter.Items.Add(output);
            } 
        }
    }
}
