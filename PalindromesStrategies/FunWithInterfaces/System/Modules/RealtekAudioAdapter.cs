using FunWithInterfaces.Interfaces;
using System;

namespace FunWithInterfaces.System.Modules
{
    public class RealtekAudioAdapter : IAudioAdapter
    {
        private int _volume;

        public void GrooveMode()
        {
            Console.WriteLine("Groove OFF.");
        }

        public void Initialize()
        {
            Console.WriteLine("Realtek Awaked...");
        }

        public int VolumeDec()
        {
            return --_volume;
        }

        public int VolumeInc()
        {
            return ++_volume;
        }
    }
}
