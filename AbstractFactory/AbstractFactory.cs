using System;
using design_pattern;

namespace Design_Pattern.AbstractFactory
{
    public class AbstractFactory : IRun
    {
        public void Run()
        {
            var fs = new FactorySimple();
            Console.WriteLine();
            Console.WriteLine("**<< Simple >>**");
            fs.Build();

            var fm = new FactoryModern();
            Console.WriteLine();
            Console.WriteLine("**<< Modern >>**");
            fm.Build();

            var fh = new FactoryHonari();
            Console.WriteLine();
            Console.WriteLine("**<< Honari >>**");
            fh.Build();
        }
    }
}