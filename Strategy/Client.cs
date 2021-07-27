using System;
using design_pattern;

namespace Design_Pattern.Strategy
{
    public class Client : IRun
    {
        public void Run()
        {
            Context context = new Context();
            context.SwitchStrategy();
            Random r = new Random(37);

            for (int i = 0; i < 20; i++)
            {
                if (r.Next(3) == 2)
                {
                    Console.WriteLine("Changed Strategy");
                    context.SwitchStrategy();
                }
                context.Algoritm();
            }
        }
    }
}