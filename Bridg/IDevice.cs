namespace Design_Pattern.Bridg
{
    public interface IDevice
    {
        bool isEnabled();
        void enable();
        void desable();
        int getVolume();
        void setVolume(int volume);
        void setChannel(int channel);
        int getChannel();
    }
}