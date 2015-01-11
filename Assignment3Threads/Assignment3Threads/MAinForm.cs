/*
 * Author: Sebastian Nirfelt
 * Date: 2015-01-11
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3Threads
{
    public partial class MainForm : Form
    {
        //Varables
        private Writer writer;
        private Reader reader;
        private Modifier modifier;
        private CircleBuffer buffer;
        private List<string> textIn;
        private Thread writerThread;
        private Thread readerThread;
        private Thread modifierThread;
        private List<int> changesStart;

        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles creating the destination txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateDestination_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtxtSource.Text))//Checks that source contains text
            {
                MessageBox.Show("No text added!");
                return;
            }
            Clear();//Clears destination
            //Creates objects
            buffer = new CircleBuffer(10, rtxtSource, cBoxNotifyUser.Checked, txtFind.Text, txtReplace.Text);
            writer = new Writer(buffer, textIn);
            reader = new Reader(buffer, textIn.Count);
            modifier = new Modifier(buffer, textIn.Count);
            writerThread = new Thread(new ThreadStart(writer.Write));
            readerThread = new Thread(new ThreadStart(reader.Read));
            modifierThread = new Thread(new ThreadStart(modifier.Modify));
            MarkReplace();//Marks find in source
            //Starts threads
            writerThread.Start();
            readerThread.Start();
            modifierThread.Start();
            //Adds subscriptions
            reader.Done += UpdateWhenDone;
            buffer.ModDone += LogUpdates;
        }

        /// <summary>
        /// Clears destination
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        /// <summary>
        /// Marks find in source
        /// </summary>
        private void MarkReplace()
        {
            if (string.IsNullOrEmpty(txtFind.Text)) return; //Checks if txtFind contains text
            string search = txtFind.Text;
            string tmp = rtxtSource.Text;
            int start = 0;
            while (tmp.Contains(search))
            {
                start += tmp.IndexOf(search);
                //Highlights finds
                rtxtSource.SelectionStart = start;
                rtxtSource.SelectionLength = search.Length;
                rtxtSource.SelectionBackColor = Color.LightSkyBlue;
                start += search.Length;
                tmp = rtxtSource.Text.Substring(start, rtxtSource.Text.Length - start);
            }
        }

        /// <summary>
        /// Clears destination and resets changes
        /// </summary>
        private void Clear()
        {
            rtxtSource.SelectionStart = 0;
            rtxtSource.SelectionLength = rtxtSource.Text.Length;
            rtxtSource.SelectionBackColor = Color.White;
            rtxtDestination.Text = string.Empty;
            changesStart = new List<int>();
            UpdateLblChanges();
        }

        /// <summary>
        /// Runs when reader is done
        /// Marks changes in destination and updates number of changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateWhenDone(object sender, ReaderDone e)
        {
            string tmp = string.Empty;
            for (int i = 0; i < e.Output.Count; i++)
            {
                tmp += e.Output[i] + "\n";
            }
            if (rtxtDestination.InvokeRequired)
            {
                rtxtDestination.Invoke(new MethodInvoker(delegate
                {
                    rtxtDestination.Text = tmp;
                    for (int i = 0; i < changesStart.Count; i++)
                    {
                        rtxtDestination.SelectionStart = changesStart[i] - (i*txtFind.Text.Length) + (i*txtReplace.Text.Length);
                        rtxtDestination.SelectionLength = txtReplace.Text.Length;
                        rtxtDestination.SelectionBackColor = Color.LightGreen;
                    }
                    UpdateLblChanges();
                }));
            }
            else
            {
                rtxtDestination.Text = tmp;
            }
            if (sender != null)
            {
                Reader reader = (Reader)sender;
                reader.Done -= UpdateWhenDone;
                buffer.ModDone -= LogUpdates;
            }
        }

        /// <summary>
        /// Adds start of changes to list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogUpdates(object sender, ModifierDone e)
        {
            changesStart.Add(e.Output);
        }

        /// <summary>
        /// Updates lblChanges
        /// </summary>
        private void UpdateLblChanges()
        {
            lblChanges.Text = changesStart.Count.ToString() + " changes made";
        }

        #region open .txt

        /// <summary>
        /// Gets filepath for file to read
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            DialogResult result = openFileDialog1.ShowDialog();
            string errorMessage = string.Empty;
            if (result == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                if (!ReadFromTextFile(path, out errorMessage))
                {
                    MessageBox.Show(errorMessage);
                }
            }
        }

        /// <summary>
        /// Reads text from chosen file and adds it to source
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        private bool ReadFromTextFile(string fileName, out string errorMessage)
        {
            bool bOk = false;
            StreamReader reader = null;
            rtxtSource.Text = string.Empty;
            textIn = new List<string>();
            errorMessage = string.Empty;

            try
            {
                reader = new StreamReader(fileName);

                while (!reader.EndOfStream)
                {
                    string temp = reader.ReadLine();
                    textIn.Add(temp);
                    rtxtSource.Text += temp + "\n";
                }
                bOk = true;
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
            }
            finally
            {
                reader.Close();
            }
            return bOk;
        }

        #endregion
    }

    /// <summary>
    /// Event holding reader output
    /// </summary>
    public class ReaderDone : EventArgs
    {
        private List<string> output;

        public List<string> Output
        {
            get { return output; }
            set { output = value; }
        }

        public ReaderDone(List<string> o)
        {
            this.output = o;
        }
    }

    /// <summary>
    /// Event holding modifier output
    /// </summary>
    public class ModifierDone : EventArgs
    {
        private int output;

        public int Output
        {
            get { return output; }
            set { output = value; }
        }

        public ModifierDone(int o)
        {
            this.output = o;
        }
    }
}
