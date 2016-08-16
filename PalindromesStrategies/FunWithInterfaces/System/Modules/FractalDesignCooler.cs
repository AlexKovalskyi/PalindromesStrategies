using FunWithInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithInterfaces.System.Modules
{
    public class FractalDesignCooler : IApi
    {
        public void Initialize()
        {
            Console.WriteLine("Fractal Design Coller started with speed 100 %");
        }
    }
}
