using FunWithInterfaces.Interfaces;
using System;
using FunWithInterfaces.System.Core;

namespace FunWithInterfaces.System.Modules
{
    public class MSIVideoAdapter : IVideoAdapter
    {

        private bool _forceMode;

        public void Initialize()
        {
            _forceMode = true;
            Console.WriteLine("");
        }

        public Image ForcedModeScreen()
        {
            _forceMode = !_forceMode;
            Console.WriteLine($"[{(_forceMode ? "+" : "-")}]MSI Force Mode Active - {_forceMode}");

            return new Image();
        }

        public Image ShowScreen()
        {
            Console.WriteLine("Drawing picture with 75 Hz.");

            return new Image();
        }

        public void OffColler()
        {
            Console.WriteLine("Cooler was disabled.");
        }

        public void OnColler()
        {
            Console.WriteLine("Cooler was enabled.");
        }
    }
}
