using LibVLCSharp.Shared;
using System;
using System.Diagnostics;

namespace LibVLCSharp.Windows.Net40.Sample
{
    class Program
    {

        private static MediaPlayer mp;
        static void Main(string[] args)
        {
            Core.Initialize();

            using var libVLC = new LibVLC(enableDebugLogs: false);
            using var media = new Media(libVLC, new Uri("http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4"));
            mp = new MediaPlayer(media);
            Debug.WriteLine("Volume after creating mediaplayer: " + mp.Volume);
            Debug.WriteLine("Setting volume to 20 percent");
            mp.Volume = 20;
            mp.Playing += Mp_Playing;
            mp.Play();

            Console.ReadKey();
        }

        private static void Mp_Playing(object sender, EventArgs e)
        {
            Debug.WriteLine("Playing event! Volume: " + mp.Volume);
        }
    }
}
