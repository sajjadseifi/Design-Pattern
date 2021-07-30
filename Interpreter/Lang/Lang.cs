using System.Collections.Generic;
using design_pattern;

namespace Design_Pattern.Interpreter.Lang
{
    public class Lang : IRun
    {
        public void Run()
        {
            Context context = new Context();

            List<AbstractExpression> list = new List<AbstractExpression>();

            list.Add(new TerminalExpression());
            list.Add(new NonTerminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());

            foreach (var exp in list)
                exp.Interpret(context);
        }
    }
}