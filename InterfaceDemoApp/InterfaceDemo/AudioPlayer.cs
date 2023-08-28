using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public class AudioPlayer : IMediaPlayer
    {
        public (string name, double length) NowPlaying()
        {
            string nameOfSong = "Time of our lives";
            double lengthOfSong = 0;

            return (nameOfSong, lengthOfSong);
        }

        public void Pause()
        {
            Console.WriteLine("Paused audio");
        }

        public void Play()
        {
            Console.WriteLine("Playing audio");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped audio");
        }
    }
}
