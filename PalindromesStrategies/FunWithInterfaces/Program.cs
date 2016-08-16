using FunWithInterfaces.System.Core;
using FunWithInterfaces.System.Modules;

namespace FunWithInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Windows wXP = new Windows(new FractalDesignCooler(), new MSIVideoAdapter(), new PioneerAudioAdapter());

            wXP.Start();
            wXP.VolumeMax();
        }
    }
}
