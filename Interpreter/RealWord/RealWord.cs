using System;
using System.Collections.Generic;
using design_pattern;

namespace Design_Pattern.Interpreter.RealWord
{
    public class RealWord : IRun
    {
        public void Run()
        {
            string roman = "MCMXXXVIII";
            Context context = new Context(roman);
            // Build the 'parse tree'
            List<Expression> tree = new List<Expression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());
            // Interpret
            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }
            Console.WriteLine("{0} = {1}",
                roman, context.Output);
            // Wait for user

        }
    }
}