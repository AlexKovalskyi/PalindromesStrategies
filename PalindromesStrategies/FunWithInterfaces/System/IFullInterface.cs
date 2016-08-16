using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithInterfaces.System
{
    //You can inherit 4 C# members
    public interface IFullInterface
    {
        int Property { get; set; }
        void Method();


        event EventHandler SomethingCanged;
        string this[int index] { get;set; }
    }
}
