using System;
using System.Media;


namespace RomoTimer.Controller
{
    public class RomoTimerController
    {
        private static SoundPlayer playBeepSound;
        public static void BeepSoundDirectory()
        {
            playBeepSound = new SoundPlayer(@"C:\Users\Rafi\Desktop\RomoTimer\RomoTimer\Resources\Sounds\TimeOverSound.wav");
        }
        public static void PlayBeepSound()
        {
            playBeepSound.Play();
        } 
    }
}
