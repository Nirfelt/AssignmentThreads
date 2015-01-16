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
    /// Bufferclass
    /// </summary>
    public class CharacterBuffer
    {
        //Variables
        private char buffer; //Buffer holding a single char
        private bool dataExists;
        private Semaphore write;
        private Semaphore read;
        private ListBox lstbWriter;
        private ListBox lstbReader;
        private bool sync;
        private object lockObj;

        public bool DataExists
        {
            get { return dataExists; }
            set { dataExists = value; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="lstbWriter"></param>
        /// <param name="lstbReader"></param>
        /// <param name="sync"></param>
        public CharacterBuffer(ListBox lstbWriter, ListBox lstbReader, bool sync)
        {
            buffer = 'x';
            write = new Semaphore(1, 1);
            read = new Semaphore(0, 1);
            this.lstbWriter = lstbWriter;
            this.lstbReader = lstbReader;
            dataExists = false;
            lockObj = new object();
            this.sync = sync;
        }

        /// <summary>
        /// Method to write to buffer
        /// Bool sync true to use semaphores for synchronization
        /// </summary>
        /// <param name="c"></param>
        public void Write(char c)
        {
            if (sync)
            {
                if (dataExists)
                    AddToListBoxWrite("Trying to write. No data. Writer waits");
                write.WaitOne();
            }
            try
            {
                lock (lockObj)
                {
                    AddToListBoxWrite("Writing " + c);
                    buffer = c;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (sync)
                {
                    dataExists = true;
                    read.Release();
                }
            }
        }

        /// <summary>
        /// Mathod to read from buffer
        /// Bool sync true to use semaphores for synchronization
        /// </summary>
        /// <returns></returns>
        public char Read()
        {
            if (sync)
            {
                if (!dataExists)
                    AddToListBoxRead("Trying to read. No data. Reader waits");
                read.WaitOne();
            }
            try
            {
                lock (lockObj)
                {
                    AddToListBoxRead("Reading " + buffer.ToString());
                    return buffer;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (sync)
                {
                    dataExists = false;
                    write.Release();
                }
            }
        }

        /// <summary>
        /// Adds info from writing to listbox
        /// </summary>
        private void AddToListBoxWrite(string output)
        {
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
        /// Adds info from reading to listbox
        /// </summary>
        private void AddToListBoxRead(string output)
        {
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
    }
}
