/*
 * Author: Sebastian Nirfelt
 * Date: 2015-01-11
*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3Threads
{
    public class CircleBuffer
    {
        //Variables
        private string[] buffer;
        private int bufferSize;
        private int writePos;
        private int readPos;
        private int findPos;
        private RichTextBox rtxBox;
        private string findstring;
        private string replacestring;
        private int start;
        private int nbrReplacements;
        private bool notify;
        //Semaphores to control writing, reading and modifying
        public static Semaphore empty;
        public static Semaphore checkedTxt;
        public static Semaphore newTxt;
        //Event to be cast when something is modified
        public event EventHandler<ModifierDone> ModDone;

        /// <summary>
        /// Constructor
        /// Gets input variables
        /// </summary>
        /// <param name="elements"></param>
        /// <param name="rt"></param>
        /// <param name="notify"></param>
        /// <param name="find"></param>
        /// <param name="replace"></param>
        public CircleBuffer(int elements, RichTextBox rt, bool notify, string find, string replace)
        {
            this.bufferSize = elements;
            this.buffer = new string[bufferSize];
            this.rtxBox = rt;
            this.notify = notify;
            this.findstring = find;
            this.replacestring = replace;
            //Create semaphores, only free for writing
            empty = new Semaphore(bufferSize, bufferSize);
            checkedTxt = new Semaphore(0, bufferSize);
            newTxt = new Semaphore(0, bufferSize);
            //All positions set to 0
            writePos = 0;
            readPos = 0;
            findPos = 0;
            nbrReplacements = 0;
            start = 0;
        }

        /// <summary>
        /// Writes data to buffer
        /// </summary>
        /// <param name="input"></param>
        public void WriteData(string input)
        {
            empty.WaitOne();
            try
            {
                buffer[writePos] = input;
                writePos = (writePos + 1) % bufferSize;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                checkedTxt.Release();
            }
        }

        /// <summary>
        /// Reads data from buffer
        /// </summary>
        /// <returns></returns>
        public string ReadData()
        {
            newTxt.WaitOne();
            try
            {
                return buffer[readPos];
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                readPos = (readPos + 1) % bufferSize;
                empty.Release();
            }
        }

        /// <summary>
        /// Modifies data
        /// </summary>
        public void ModifyData()
        {
            checkedTxt.WaitOne();
            try
            {
                string tmp = buffer[findPos];
                string output = string.Empty;
                while (tmp.Contains(findstring))
                {
                    start += tmp.IndexOf(findstring);
                    if (rtxBox.InvokeRequired)
                    {
                        rtxBox.Invoke(new MethodInvoker(delegate
                        {
                            //Highlights change to be made
                            rtxBox.SelectionStart = start;
                            rtxBox.SelectionLength = findstring.Length;
                            rtxBox.SelectionBackColor = Color.LightCoral;
                            DialogResult result = DialogResult.Yes;
                            if (notify)//Asks user if change is t be made
                            {
                                result = MessageBox.Show("Replace " + findstring + " with " + replacestring + "?", "Replace...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            }
                            if (result == DialogResult.Yes)
                            {
                                //Makes change
                                output += tmp.Substring(0, tmp.IndexOf(findstring));
                                output += replacestring;
                                rtxBox.SelectionStart = start;
                                rtxBox.SelectionLength = findstring.Length;
                                rtxBox.SelectionBackColor = Color.LightGreen;
                                nbrReplacements++;
                                OnDone(new ModifierDone(start));//Casts events notifying MainForm that a change has been made
                            }
                            else
                            {
                                //Leaves change as it was
                                output += tmp.Substring(0, tmp.IndexOf(findstring) + findstring.Length);
                                rtxBox.SelectionStart = start;
                                rtxBox.SelectionLength = findstring.Length;
                                rtxBox.SelectionBackColor = Color.LightSkyBlue;
                            }
                        }));
                    }
                    int first = tmp.IndexOf(findstring) + findstring.Length;
                    int second = tmp.Length - (tmp.IndexOf(findstring) + findstring.Length);
                    start += findstring.Length;
                    tmp = tmp.Substring(first, second);
                }
                start += tmp.Length + "\n".Length;
                output += tmp;
                buffer[findPos] = output;
                
                findPos = (findPos + 1) % bufferSize;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                newTxt.Release();
            }
        }

        /// <summary>
        /// Event to be cast on finish
        /// </summary>
        /// <param name="e"></param>
        public void OnDone(ModifierDone e)
        {
            if (ModDone != null)
                ModDone(this, e);
        }
    }
}
