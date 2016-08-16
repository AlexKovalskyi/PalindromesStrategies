using FunWithInterfaces.System.Core;

namespace FunWithInterfaces.Interfaces
{
    public interface IVideoAdapter : IApi
    {
        Image ShowScreen();
        Image ForcedModeScreen();
    }
}
