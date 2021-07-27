using System;

namespace Design_Pattern.Strategy
{
    public class StrategyA : IStrategy
    {
        private Context _context;
        public StrategyA() { }
        public StrategyA(Context context) => _context = context;
        public void Algoritm()
        {
            if (_context == null)
            {
                Console.WriteLine("Algoritm A");
                return;
            }
            Console.WriteLine($"Algoritm A Get ${_context.x}");
        }
    }
    public class StrategyB : IStrategy
    {
        private Context _context;
        public StrategyB(Context context) => _context = context;
        public void Algoritm()
        {
            _context.x = "B";
            Console.WriteLine("Algoritm B Set X");
        }
    }
}