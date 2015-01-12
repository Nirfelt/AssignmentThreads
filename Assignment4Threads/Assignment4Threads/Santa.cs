using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4Threads
{
    public class Santa
    {
        //Variables
        private Buffer buffer;
        private ListBox lstbActivities;
        private object lockObj;
        private Random rnd;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="lstbActivities"></param>
        /// <param name="lockObj"></param>
        public Santa(Buffer buffer, ListBox lstbActivities, object lockObj)
        {
            this.buffer = buffer;
            this.lstbActivities = lstbActivities;
            this.lockObj = lockObj;
            rnd = new Random();
        }

        /// <summary>
        /// Synchronized method for emptying santas bag
        /// Keeps track of santas activities
        /// </summary>
        public void DeliverToys()
        {
            while (true)
            {
                lock (lockObj)
                {
                    AddMessage("Santa wakes up!");
                    Thread.Sleep(500);
                    while (!buffer.BagFull)
                        Monitor.Wait(lockObj);
                    AddMessage("Delivering gifts...");
                    List<Toy> lToy = buffer.DeliverToys();
                    AddMessage(lToy.Count.ToString() + " toys delivered!");
                    Monitor.Pulse(lockObj);
                }
                
                AddMessage("Santa sleeps!");
                Thread.Sleep(rnd.Next(4000, 6000));
                AddMessage("3...");
                Thread.Sleep(1000);
                AddMessage("2...");
                Thread.Sleep(1000);
                AddMessage("1...");
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// Adds a message to santas listbox
        /// </summary>
        /// <param name="str"></param>
        private void AddMessage(string str)
        {
            if (lstbActivities.InvokeRequired)
            {
                lstbActivities.Invoke(new MethodInvoker(delegate
                {
                    if (lstbActivities.Items.Count >= 23)
                        lstbActivities.Items.RemoveAt(0);
                    lstbActivities.Items.Add(str);
                }));
            }
            else
            {
                lstbActivities.Items.Add(str);
            }
        }
    }
}
