namespace Design_Pattern.Adapter.RealAdapter
{
    public interface ISocketAdapter
    {
        Volt get120Volt();
        Volt get12Volt();
        Volt get3Volt();
    }
}