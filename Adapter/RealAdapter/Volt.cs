namespace Design_Pattern.Adapter.RealAdapter
{
    public class Volt
    {
        private int _volt;
        public Volt(int volt) => _volt = volt;
        public void SetVolt(int volt) => _volt = volt;
        public int GetVolts() => _volt;
    }
}