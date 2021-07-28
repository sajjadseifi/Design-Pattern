namespace Design_Pattern.Builder
{
    public interface IKeyValueCollectionBiuilder
    {
        void Build();
        IKeyValueCollectionBiuilder Add(string key, string value);
    }
}