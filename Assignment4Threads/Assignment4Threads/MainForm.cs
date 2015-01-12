using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4Threads
{
    public partial class MainForm : Form
    {
        //Variables
        private ToyFactory tf1;
        private ToyFactory tf2;
        private Santa santa;
        private Buffer buffer;
        private bool santaAwake;
        private Thread santaThread;
        private Thread factory1Thread;
        private Thread factory2Thread;
        private object lockObj;

        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            lockObj = new object();
            buffer = new Buffer(lstbBag, lblWV);
            tf1 = new ToyFactory(buffer, lockObj);
            tf2 = new ToyFactory(buffer, lockObj);
            santa = new Santa(buffer, lstbActivities, lockObj);
            santaThread = new Thread(new ThreadStart(santa.DeliverToys));
            santaAwake = false;
            btnStopFactory1.Enabled = false;
            btnStopFactory2.Enabled = false;
        }

        /// <summary>
        /// Starts factorythread 1
        /// If santa i sleeping he gets awakened
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFactory1_Click(object sender, EventArgs e)
        {
            btnFactory1.Enabled = false;
            btnStopFactory1.Enabled = true;
            factory1Thread = new Thread(new ThreadStart(tf1.GenerateToys));
            factory1Thread.Start();
            WakeSanta();
        }

        /// <summary>
        /// Starts factorythread 2
        /// If santa i sleeping he gets awakened
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFactory2_Click(object sender, EventArgs e)
        {
            btnFactory2.Enabled = false;
            btnStopFactory2.Enabled = true;
            factory2Thread = new Thread(new ThreadStart(tf2.GenerateToys));
            factory2Thread.Start();
            WakeSanta();
        }

        /// <summary>
        /// Stops factorythread 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopFactory1_Click(object sender, EventArgs e)
        {
            btnFactory1.Enabled = true;
            btnStopFactory1.Enabled = false;
            factory1Thread.Abort();
        }

        /// <summary>
        /// Stops factorythread 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopFactory2_Click(object sender, EventArgs e)
        {
            btnFactory2.Enabled = true;
            btnStopFactory2.Enabled = false;
            factory2Thread.Abort();
        }

        /// <summary>
        /// Wakes santa if sleeping
        /// </summary>
        private void WakeSanta()
        {
            if (!santaAwake)
            {
                santaThread.Start();
                santaAwake = true;
            }
        }

        /// <summary>
        /// Method to override exitbutton to close all threads befor exiting
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
    }
}
