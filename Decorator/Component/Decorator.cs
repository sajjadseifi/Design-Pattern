using System;
using design_pattern;

namespace Design_Pattern.Decorator
{
    public class Decorator : IRun
    {
        public void Run()
        {
            var cmp = new Component("Simple Text");
            var cmpDec = new ComponentUppercaseDecorator(cmp);

            Console.WriteLine($"Component Info => {cmp.GetInfo()}");
            Console.WriteLine($"ComponentUppercaseDecorator Info => {cmpDec.GetInfo()}");
        }
    }
}