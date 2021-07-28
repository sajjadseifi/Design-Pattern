using System;
using System.Collections.Generic;

namespace Design_Pattern.Builder
{
    public class QueryBuilder : Builder
    {
        public override void Build()
        {
            _kevls.ForEach(kv =>
            {
                _strBuilder.Append(kv.key);
                _strBuilder.Append("=");
                _strBuilder.Append(Uri.EscapeDataString(kv.value));
            });
            var res = "?" + _strBuilder.ToString();
            Console.WriteLine(res);
        }
    }
    public class FormBodyBuilder : Builder
    {
        public override void Build()
        {
            var i = 0;
            foreach (var kv in _kevls)
            {
                _strBuilder.Append(kv.key);
                _strBuilder.Append("=");
                _strBuilder.Append(Uri.EscapeDataString(kv.value));
                if (++i != _kevls.Count)
                    _strBuilder.Append("\n");
            }
            var res = _strBuilder.ToString();
            Console.WriteLine(res);
        }
    }
    public class HttpHeaderBuilder : Builder
    {
        public override void Build()
        {
            int i = 0;
            _strBuilder.Append("{");
            _kevls.ForEach(kv =>
            {
                _strBuilder.Append("\n");
                _strBuilder.Append("  ");
                _strBuilder.Append(kv.key);
                _strBuilder.Append(" : ");
                _strBuilder.Append(Uri.EscapeDataString(kv.value));
                if (++i < _kevls.Count)
                    _strBuilder.Append(",");

            });
            _strBuilder.Append("\n");
            _strBuilder.Append("}");

            var res = _strBuilder.ToString();
            Console.WriteLine(res);
        }
    }
    public class DictanoryBodyBuilder : Builder
    {
        private Dictionary<string, string> _dictanory = new Dictionary<string, string>();
        public override void Build() => Console.WriteLine(_dictanory);
        public override IKeyValueCollectionBiuilder Add(string key, string value)
        {
            _dictanory[key] = value;
            return this;
        }
    }
}