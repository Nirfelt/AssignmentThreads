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
        private ThreadDisplay display;
        private ThreadMusic music;
        private ThreadTriangle triangle;
        Thread musicThread;

        public MainForm()
        {
            InitializeComponent();
            display = new ThreadDisplay();
            
            triangle = new ThreadTriangle();
        }

        private void btnOpenMusic_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            openFileDialog1.Filter = "music files (*.mp3)(*.wav)|*.mp3;*.wav|All files (*.*)|*.*";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                music = new ThreadMusic(filePath);
                lblFilePath.Text = filePath;
            }
            
        }

        private void btnPlayMusic_Click(object sender, EventArgs e)
        {
            musicThread = new Thread(new ThreadStart(music.PlayMusic));
            musicThread.Start();
        }

        private void btnStopMusic_Click(object sender, EventArgs e)
        {
            musicThread.Abort();
        }

        private void btnStartDisplay_Click(object sender, EventArgs e)
        {

        }

        private void btnStopDisplay_Click(object sender, EventArgs e)
        {

        }

        private void btnStartTriangle_Click(object sender, EventArgs e)
        {

        }

        private void btnStopTriangle_Click(object sender, EventArgs e)
        {

        }
    }
}
