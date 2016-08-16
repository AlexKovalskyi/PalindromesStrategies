using FunWithInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FunWithInterfaces.System.Modules
{
    public class PioneerAudioAdapter : IAudioAdapter
    {
        private int volume;

        public int Volume
        {
            get
            {
                return volume;
            }
            private set
            {
                if (value >= 100)
                {
                    volume = 100;
                }
                else if (value <= 0)
                {
                    volume = 0;
                }
                else
                {
                    volume = value;
                }
            }
        }

        public void GrooveMode()
        {
            Console.WriteLine("Pioneer groove always enabled.");
        }

        public void Initialize()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Pioneer initialized.");
        }

        public int VolumeDec()
        {
            Volume -= 15;
            Console.WriteLine("Pioneer volume dec.");

            return Volume;
        }

        public int VolumeInc()
        {
            Volume += 15;
            Console.WriteLine("Pioneer volume inc.");

            return Volume;
        }
    }
}
