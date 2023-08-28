using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public class VideoPlayer : IMediaPlayer
    {
        public (string name, double length) NowPlaying()
        {
            string nameOfSong = "";
            double lengthOfSong = 0;

            return (nameOfSong, lengthOfSong);
        }

        public void Pause()
        {
            Console.WriteLine("Paused the video");
        }

        public void Play()
        {
            Console.WriteLine("Playing the video");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped the video");
        }
    }
}
