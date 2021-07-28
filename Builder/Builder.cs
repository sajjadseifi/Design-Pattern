using System.Collections.Generic;
using System.Text;

namespace Design_Pattern.Builder
{
    public class KeyValue
    {
        public string value;
        public string key;

        public KeyValue(string key, string value)
        {
            this.key = key;
            this.value = value;
        }
    }
    public abstract class Builder : IKeyValueCollectionBiuilder
    {
        protected StringBuilder _strBuilder;
        protected List<KeyValue> _kevls;
        public Builder()
        {
            _strBuilder = new StringBuilder();
            _kevls = new List<KeyValue>();
        }
        public virtual IKeyValueCollectionBiuilder Add(string key, string value)
        {
            _kevls.Add(new KeyValue(key, value));
            return this;
        }
        public abstract void Build();
    }
}