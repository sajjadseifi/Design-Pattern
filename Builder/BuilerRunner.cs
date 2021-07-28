using design_pattern;

namespace Design_Pattern.Builder
{
    public class BuilerRunner : IRun
    {
        public void Run()
        {
            // Builder builder = new QueryBuilder();
            // Builder builder = new FormBodyBuilder();
            // Builder builder = new DictanoryBodyBuilder();
            Builder builder = new HttpHeaderBuilder();
            builder
                    .Add("make", "lada")
                    .Add("color", "red")
                    .Add("year", 2080.ToString())
                    .Build();
        }
    }
}