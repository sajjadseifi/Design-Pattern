namespace Design_Pattern.Bridg
{
    public class AdvancedRemote : Remote
    {
        public AdvancedRemote(IDevice device) : base(device) { }
        public override void togglePower()
        {

            if (_device.isEnabled())
                _device.desable();
            else
                _device.enable();
        }
        public override void volumeDown()
        {
            int current = _device.getVolume();
            _device.setVolume(current - 1);
        }
        public override void volumeUp()
        {
            int current = _device.getVolume();
            _device.setVolume(current + 1);
        }
        public override void channelUp()
        {
            int old = _device.getChannel();
            _device.setVolume(old + 1);
        }
        public override void channelDown()
        {
            int old = _device.getChannel();
            _device.setVolume(old - 1);
        }
    }
}
