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

namespace Assignment1Threads
{
    public partial class MainForm : Form
    {
        //Variables
        private ThreadDisplay display;
        private ThreadMusic music;
        private Thread musicThread;
        private Thread displayThread;
        private Thread triangleThread;

        public MainForm()
        {
            InitializeComponent();
            display = new ThreadDisplay();

            btnPlayMusic.Enabled = false;
            btnStopMusic.Enabled = false;
            btnStopTriangle.Enabled = false;
        }

        /// <summary>
        /// Lets the user choose a path for a .wav-file to play with music thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenMusic_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            openFileDialog1.Filter = "music files (*.wav)|*.wav|All files (*.*)|*.*";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                music = new ThreadMusic(filePath);
                lblFilePath.Text = filePath;
                btnPlayMusic.Enabled = true;
            }
            
        }

        /// <summary>
        /// Starts music thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayMusic_Click(object sender, EventArgs e)
        {
            musicThread = new Thread(new ThreadStart(music.PlayMusic));
            musicThread.Start();
            btnStopMusic.Enabled = true;
            btnPlayMusic.Enabled = false;
        }

        /// <summary>
        /// Aborts music thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopMusic_Click(object sender, EventArgs e)
        {
            musicThread.Abort();
            btnPlayMusic.Enabled = true;
            btnStopMusic.Enabled = false;
        }

        private void btnStartDisplay_Click(object sender, EventArgs e)
        {

        }

        private void btnStopDisplay_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Starts triangle thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartTriangle_Click(object sender, EventArgs e)
        {
            triangleThread = new Thread(new ThreadStart(DrawTriangle));
            triangleThread.Start();
            btnStartTriangle.Enabled = false;
            btnStopTriangle.Enabled = true;
        }

        /// <summary>
        /// Handles abort triangle thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopTriangle_Click(object sender, EventArgs e)
        {
            triangleThread.Abort();
            btnStartTriangle.Enabled = true;
            btnStopTriangle.Enabled = false;
        }

        /// <summary>
        /// Method for creating a spinning triangle on pnlTriangle
        /// </summary>
        private void DrawTriangle()
        {
            //Creating points in a circular formation
            Point[] circlePoints = new Point[360];
            int radius = 50;
            int centerX = pnlTriangle.Width / 2;
            int centerY = pnlTriangle.Height / 2;
            for (int i = 0; i < 360; i++)
            {
                circlePoints[i] = new Point(
                    Convert.ToInt32(radius * Math.Cos(i * Math.PI / 180.0f) + centerX),
                    Convert.ToInt32(radius * Math.Sin(i * Math.PI / 180.0f) + centerY));
            }
            //Declaring startingpoints for the triangle
            int p1 = 0;
            int p2 = 120;
            int p3 = 240;
            try
            {
                //Loop to draw and update the triangle position
                while (true)
                {
                    Invoke(new MethodInvoker(() =>
                    {
                        Point[] points = { circlePoints[p1], circlePoints[p2], circlePoints[p3] };
                        IntPtr hwnd = pnlTriangle.Handle;

                        using (Graphics graphics = Graphics.FromHwnd(hwnd))
                        {
                            graphics.FillPolygon(new SolidBrush(Color.Red), points, new System.Drawing.Drawing2D.FillMode());
                        }
                        pnlTriangle.Invalidate();
                        Thread.Sleep(100);
                        Application.DoEvents();
                    }));
                    p1 = incrementPoint(p1);
                    p2 = incrementPoint(p2);
                    p3 = incrementPoint(p3);
                }
            }
            catch(ThreadAbortException) 
            {
                throw;
            }
        }

        /// <summary>
        /// Increments the angle of a given point by one or restarts cykle if angle > 360
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        private int incrementPoint(int point)
        {
            if(point + 1 == 360) return 0;
            return point + 1;
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
