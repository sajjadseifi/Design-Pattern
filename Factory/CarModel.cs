namespace Design_Pattern.Factory
{
    public class CarModelS : ICar<string>
    {
        protected string model = "S";
        public string GeModel() => model;
    }
    public class CarModelR : ICar<string>
    {
        protected string model = "R";
        public string GeModel() => model;
    }
}