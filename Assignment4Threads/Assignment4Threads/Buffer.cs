using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4Threads
{
    public class Buffer
    {
        //Variables
        private Queue<Toy>buffer;
        private object lockObj;
        private const int maxNr = 20;
        private const int maxWeight = 500;
        private const int maxVolume = 400;
        private int currentWeight;
        private int currentVolume;
        private ListBox lstbBag;
        private bool bagFull;
        private Label lblWV;

        /// <summary>
        /// Property bag full bool
        /// </summary>
        public bool BagFull
        {
            get { return bagFull; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="lstbBag"></param>
        /// <param name="lblWV"></param>
        public Buffer(ListBox lstbBag, Label lblWV)
        {
            buffer = new Queue<Toy>();
            lockObj = new object();
            this.lstbBag = lstbBag;
            this.lblWV = lblWV;
            bagFull = false;
        }

        /// <summary>
        /// Method for santa to deliver toys
        /// Empties santas bag
        /// </summary>
        /// <returns></returns>
        public List<Toy> DeliverToys()
        {
            lock (lockObj)
            {
                List<Toy> lToy = new List<Toy>();
                int c = buffer.Count;
                for (int i = 0; i < c; i++)
                {
                    lToy.Add(buffer.Dequeue());
                    Thread.Sleep(100);
                    ClearMessage();
                }
                currentWeight = 0;
                currentVolume = 0;
                bagFull = false;
                return lToy;
            }
        }

        /// <summary>
        /// Method for toyfactories to add toys to santas bag
        /// </summary>
        /// <param name="toy"></param>
        public void AddToys(Toy toy)
        {
            lock (lockObj)
            {
                if (buffer.Count + 1 > maxNr || currentWeight + toy.Weight > maxWeight || currentVolume + toy.Volume > maxVolume)
                {
                    bagFull = true;
                }
                else
                {
                    currentWeight += toy.Weight;
                    currentVolume += toy.Volume;
                    buffer.Enqueue(toy);
                    AddMessage(buffer.Count.ToString() + ": " + toy.Name + " added to bag! W: " + toy.Weight + " V: " + toy.Volume, "Weight: " + currentWeight.ToString() + " Volume: " + currentVolume.ToString());
                }
            }
        }

        /// <summary>
        /// Adding a string to listbox and label
        /// </summary>
        /// <param name="str"></param>
        /// <param name="lblstr"></param>
        private void AddMessage(string str, string lblstr)
        {
            if (lstbBag.InvokeRequired)
            {
                lstbBag.Invoke(new MethodInvoker(delegate
                {
                    lblWV.Text = lblstr;
                    lstbBag.Items.Add(str);
                }));
            }
            else
            {
                lblWV.Text = lblstr;
                lstbBag.Items.Add(str);
            } 
        }

        /// <summary>
        /// Resetting the label anf clearing listbox
        /// </summary>
        private void ClearMessage()
        {
            if (lstbBag.InvokeRequired)
            {
                lstbBag.Invoke(new MethodInvoker(delegate
                {
                    lstbBag.Items.Clear();
                    lblWV.Text = "Weight: 0 Volume: 0";
                }));
            }
            else
            {
                lstbBag.Items.Clear();
                lblWV.Text = "Weight: 0 Volume: 0";
            }
        }
    }
}
