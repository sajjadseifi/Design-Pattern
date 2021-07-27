namespace Design_Pattern.Strategy
{
    public class Context
    {
        public string x { get; set; }
        private IStrategy _strategy;
        public Context() { }
        public void SwitchStrategy()
        {
            if (_strategy is StrategyA)
                _strategy = new StrategyB(this);
            else
                _strategy = new StrategyA(this);
        }
        public void Algoritm() => _strategy.Algoritm();
    }
}
