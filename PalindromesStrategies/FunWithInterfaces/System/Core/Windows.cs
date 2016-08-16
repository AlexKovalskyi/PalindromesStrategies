using FunWithInterfaces.Interfaces;
using FunWithInterfaces.System.Modules;
using System;

namespace FunWithInterfaces.System.Core
{
    public class Windows
    {
        private IApi _cooler;
        private IVideoAdapter _videoAdapter;
        private IAudioAdapter _audioAdapter;

        public Windows(IApi cooler, IVideoAdapter video, IAudioAdapter audio)
        {
            _cooler = cooler;
            _videoAdapter = video;
            _audioAdapter = audio;
        }

        public void Start()
        {
            foreach (IApi api in new IApi[] {_cooler, _videoAdapter, _audioAdapter })
            {
                api.Initialize();
            }

            Console.WriteLine("Getting start...");
        }

        public void VolumeOff()
        {
            while (0 != _audioAdapter.VolumeDec()) ;
        }

        public void VolumeMax()
        {
            while (100 != _audioAdapter.VolumeInc()) ;
        }

        public void Shutdown()
        {
            Console.WriteLine("Getting down...");
        }
    }
}
