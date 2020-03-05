using System;
using System.Collections.Generic;
using System.Text;

namespace MediaPlayers
{ 
    public interface IStreamingDevice
    {
        public string DeviceName { get; set; }
        public bool IsPlaying { get; set; } 
        public bool IsPaused { get; set; }
        bool Play();
        void Pause();
        void Ffwd();
        void Rewind();
        bool Stop();
    }

    class MediaPlayers
    {
    }

    public class DVDPlayer : IStreamingDevice
    {
        public DVDPlayer()
        {
            DeviceName = "My DVD Player";
            IsPlaying = false;
            IsPaused = false;
        }
        
        public string DeviceName { get; set; }

        public bool IsPlaying { get; set;}
        public bool IsPaused { get; set;}

        public void Ffwd()
        {
            Console.WriteLine($"FFwd {DeviceName}");
        }

        public void Pause()
        {
            if(IsPlaying) Console.WriteLine($"{DeviceName} paused.");
            else Console.WriteLine($"{DeviceName} stopped.");
        }

        public bool Play()
        {
            Console.WriteLine($"Play {DeviceName}");
            IsPlaying = true;
            IsPaused = false;
            return IsPlaying;

        }

        public void Rewind()
        {
            Console.WriteLine($"Recind {DeviceName}");
        }

        public bool Stop()
        {
            Console.WriteLine($"Stop {DeviceName}");
            IsPlaying = false;
            return IsPlaying;
        }
    }

}
