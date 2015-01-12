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

namespace Assignment2Threads
{  
    /// <summary>
    /// Class for handling GUI operations and starting threads
    /// </summary>
    public partial class MainForm : Form
    {
        //Variables
        private Thread t1;
        private Thread t2;
        private Writer writer;
        private Reader reader;
        private CharacterBuffer cBuffer;
        private char[] cToTransfer;
         
        /// <summary>
        /// Constructor
        /// Sets starting values for MainForm
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            pnlStatus.BackColor = Color.Black;
            rbtnSync.Checked = true;
        }

        /// <summary>
        /// Handles starting the main function of the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRun_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbStringToTransfer.Text)) return;//do nothing if no input
            ClearGUI();
            cToTransfer = txbStringToTransfer.Text.ToCharArray();//create char array of input
            int size = cToTransfer.Length;
            cBuffer = new CharacterBuffer(lstbWriter, lstbReader, rbtnSync.Checked);//makes new buffer
            writer = new Writer(cBuffer, cToTransfer);
            reader = new Reader(cBuffer, cToTransfer.Length);
            t1 = new Thread(new ThreadStart(writer.Write));
            t2 = new Thread(new ThreadStart(reader.Read));
            t1.Start();
            t2.Start();
            btnRun.Enabled = false;
            btnClear.Enabled = false;
            //add subscriber to readerthread
            reader.Done += CheckMatch;
        }

        /// <summary>
        /// Clears GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearGUI();
        }

        /// <summary>
        /// Method for clearing the GUI
        /// </summary>
        private void ClearGUI()
        {
            lstbWriter.Items.Clear();
            lstbReader.Items.Clear();
            lblTransmitted.Text = string.Empty;
            lblRecieved.Text = string.Empty;
            lblStatus.Text = "Run for match";
            pnlStatus.BackColor = Color.Black;
        }

        /// <summary>
        /// Checks if input matches output
        /// Is run from readerthread when finished
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckMatch(object sender, ReaderDone e)
        {
            if (lblRecieved.InvokeRequired)
            {
                lblRecieved.Invoke(new MethodInvoker(delegate
                {
                    UpdateCheck(e.Output);
                    btnClear.Enabled = true;
                    btnRun.Enabled = true;
                }));
            }
            else
            {
                UpdateCheck(e.Output);
                btnRun.Enabled = true;
                btnClear.Enabled = true;
            }
            if (sender != null)
            {
                Reader reader = (Reader)sender;
                reader.Done -= CheckMatch;
            }
            
        }

        /// <summary>
        /// Updates the GUI to match reader/writer-output
        /// </summary>
        /// <param name="s"></param>
        private void UpdateCheck(string s)
        {
            lblRecieved.Text = s;
            lblTransmitted.Text = MakeString(cToTransfer);
            if (lblTransmitted.Text == lblRecieved.Text)
            {
                lblStatus.Text = "MATCH";
                pnlStatus.BackColor = Color.Green;
            }
            else
            {
                lblStatus.Text = "NO MATCH";
                pnlStatus.BackColor = Color.Red;
            }
        }

        /// <summary>
        /// Makes string from char-array
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private string MakeString(char[] c)
        {
            string output = string.Empty;
            for (int i = 0; i < c.Length; i++)
            {
                output += c[i].ToString();
            }
            return output;
        }
    }

    /// <summary>
    /// Event holding reader output
    /// </summary>
    public class ReaderDone : EventArgs
    {
        private string output;

        public string Output
        {
            get { return output; }
            set { output = value; }
        }

        public ReaderDone(string o)
        {
            this.output = o;
        }
    }
}
