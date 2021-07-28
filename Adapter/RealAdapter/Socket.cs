namespace Design_Pattern.Adapter.RealAdapter
{
    public class Socket
    {
        public Volt GetVolt() => new Volt(120);
        public Volt ConvertVolt(Volt v, int i) => new Volt(v.GetVolts() / i);

    }
}