
namespace FunWithInterfaces.Interfaces
{
    public interface IAudioAdapter : IApi
    {
        int VolumeInc();
        int VolumeDec();
        void GrooveMode();
    }
}