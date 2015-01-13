using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5Threads
{
    public partial class MainForm : Form
    {
        private bool q1Pressed;
        private bool q2Pressed;
        private bool q3Pressed;
        private bool q4Pressed;

        public MainForm()
        {
            InitializeComponent();
            q1Pressed = false;
            q2Pressed = false;
            q3Pressed = false;
            q4Pressed = false;
        }

        /// <summary>
        /// Method to override exitbutton to close all threads befor exiting
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void btnQueue1_Click(object sender, EventArgs e)
        {
            if (q1Pressed)
            {
                btnQueue1.Text = "OPEN";
            }
            else
            {
                btnQueue1.Text = "CLOSE";
            }
            q1Pressed = !q1Pressed;
        }

        private void btnQueue2_Click(object sender, EventArgs e)
        {
            if (q2Pressed)
            {
                btnQueue2.Text = "OPEN";
            }
            else
            {
                btnQueue2.Text = "CLOSE";
            }
            q2Pressed = !q2Pressed;
        }

        private void btnQueue3_Click(object sender, EventArgs e)
        {
            if (q3Pressed)
            {
                btnQueue3.Text = "OPEN";
            }
            else
            {
                btnQueue3.Text = "CLOSE";
            }
            q3Pressed = !q3Pressed;
        }

        private void btnQueue4_Click(object sender, EventArgs e)
        {
            if (q4Pressed)
            {
                btnQueue4.Text = "OPEN";
            }
            else
            {
                btnQueue4.Text = "CLOSE";
            }
            q4Pressed = !q4Pressed;
        }
    }
}
