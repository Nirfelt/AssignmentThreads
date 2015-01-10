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
        private Object lockObj;
        private CharacterBuffer cBuffer;
        private int size;
        private Random rnd;
        private ListBox lstbReader;
        private string output;
        public event EventHandler<ReaderDone> Done;

        /// <summary>
        /// Constructor that sets inputvalues for reader
        /// </summary>
        /// <param name="lockObj"></param>
        /// <param name="cBuffer"></param>
        /// <param name="size"></param>
        /// <param name="lstbReader"></param>
        public Reader(Object lockObj, CharacterBuffer cBuffer, int size, ListBox lstbReader)
        {
            this.lockObj = lockObj;
            this.cBuffer = cBuffer;
            this.size = size;
            rnd = new Random();
            this.lstbReader = lstbReader;
            output = string.Empty;
        }

        /// <summary>
        /// Method handling synchronized reading
        /// </summary>
        public void ReadSync()
        {
            for (int i = 0; i < size; i++)
            {
                lock (lockObj)
                {
                    if (!cBuffer.DataExists) AddToListBox();
                    while (!cBuffer.DataExists)
                        Monitor.Wait(lockObj);

                    char c = cBuffer.Read();
                    AddToListBox(c);
                    output += c.ToString();
                    Monitor.Pulse(lockObj);
                }
                Thread.Sleep(rnd.Next(100, 200));
            }
            OnDone(new ReaderDone(output));
        }

        /// <summary>
        /// Method for handling asynchrounus reading
        /// </summary>
        public void ReadAsync()
        {
            for (int i = 0; i < size; i++)
            {
                lock (lockObj)
                {
                    char c = cBuffer.Read();
                    AddToListBox(c);
                    output += c.ToString();
                }
                Thread.Sleep(rnd.Next(100, 300));
            }
            OnDone(new ReaderDone(output));
        }

        /// <summary>
        /// Adds trying to read string to listbox
        /// </summary>
        private void AddToListBox()
        {
            string output = "Trying to read. No data. Reader waits";
            if (lstbReader.InvokeRequired)
            {
                lstbReader.Invoke(new MethodInvoker(delegate
                {
                    lstbReader.Items.Add(output);
                }));
            }
            else
            {
                lstbReader.Items.Add(output);
            }
        }

        /// <summary>
        /// Adds a value to listbox
        /// </summary>
        /// <param name="c"></param>
        private void AddToListBox(char c)
        {
            string output = "Reading " + c.ToString();
            if (lstbReader.InvokeRequired)
            {
                lstbReader.Invoke(new MethodInvoker(delegate
                {
                    lstbReader.Items.Add(output);
                }));
            }
            else
            {
                lstbReader.Items.Add(output);
            }
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
