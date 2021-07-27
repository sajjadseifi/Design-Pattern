namespace Design_Pattern.Bridg
{
    public abstract class Remote
    {
        protected IDevice _device;
        public Remote(IDevice device) => _device = device;
        public abstract void togglePower();
        public abstract void volumeDown();
        public abstract void volumeUp();
        public abstract void channelUp();
        public abstract void channelDown();
    }
}