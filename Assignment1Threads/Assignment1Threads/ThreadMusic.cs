using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using System.Threading;

namespace Assignment1Threads
{
    public class ThreadMusic
    {
        private SoundPlayer snd = null;
        private string path = string.Empty;

        public ThreadMusic(string path)
        {
            this.path = path;
        }
        public void PlayMusic()
        {
            try
            {
                snd = new SoundPlayer();
                snd.SoundLocation = path;
                snd.Load();
                snd.Play();
                while (true) ;
            }
            catch (ThreadAbortException)
            {
                snd.Stop();
                //System.Windows.Forms.MessageBox.Show("Abort");
                throw;
            }
        }
    }
}
