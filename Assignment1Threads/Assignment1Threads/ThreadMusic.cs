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
        //Variables
        private SoundPlayer snd = null;
        private string path = string.Empty;

        /// <summary>
        /// Constructor
        /// Takes path to .wav-file
        /// </summary>
        /// <param name="path"></param>
        public ThreadMusic(string path)
        {
            this.path = path;
        }

        /// <summary>
        /// Method to play chosen .wav-file
        /// </summary>
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
                throw;
            }
        }
    }
}
