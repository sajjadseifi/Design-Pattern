namespace Design_Pattern.Adapter.RealAdapter
{
    public class ReadAdapter
    {
        public static Volt GetVolt(ISocketAdapter socketAdapter, int i)
        {
            switch (i)
            {
                case 3: return socketAdapter.get3Volt();
                case 12: return socketAdapter.get12Volt();
                default: return socketAdapter.get120Volt();
            }
        }
    }
}