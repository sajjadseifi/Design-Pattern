namespace Design_Pattern.Bridg
{
    public class Device : IDevice
    {
        public void desable() => throw new System.NotImplementedException();
        public void enable() => throw new System.NotImplementedException();
        public int getChannel() => throw new System.NotImplementedException();
        public int getVolume() => throw new System.NotImplementedException();
        public bool isEnabled() => throw new System.NotImplementedException();
        public void setChannel(int channel) => throw new System.NotImplementedException();
        public void setVolume(int volume) => throw new System.NotImplementedException();
    }
    public class Radio : IDevice
    {
        public void desable() => throw new System.NotImplementedException();
        public void enable() => throw new System.NotImplementedException();
        public int getChannel() => throw new System.NotImplementedException();
        public int getVolume() => throw new System.NotImplementedException();
        public bool isEnabled() => throw new System.NotImplementedException();
        public void setChannel(int channel) => throw new System.NotImplementedException();
        public void setVolume(int volume) => throw new System.NotImplementedException();
    }
    public class TV : IDevice
    {
        public void desable() => throw new System.NotImplementedException();
        public void enable() => throw new System.NotImplementedException();
        public int getChannel() => throw new System.NotImplementedException();
        public int getVolume() => throw new System.NotImplementedException();
        public bool isEnabled() => throw new System.NotImplementedException();
        public void setChannel(int channel) => throw new System.NotImplementedException();
        public void setVolume(int volume) => throw new System.NotImplementedException();
    }
}
