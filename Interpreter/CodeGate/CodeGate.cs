using System;
using design_pattern;

namespace Design_Pattern.Interpreter.CodeGate
{
    public class CodeGate : IRun
    {
        public void Run()
        {
            string context = "seifi lor ";
            IExpression exp = Get();
            var res = exp.Interpret(context);
            Console.WriteLine("Or Gate Res ={0}", res);
        }
        private IExpression Get()
        {
            IExpression ali = new TerminalExpression("ali");
            IExpression pouya = new TerminalExpression("pouya");
            IExpression julie = new TerminalExpression("julie");
            IExpression robert = new TerminalExpression("robert");
            IExpression sajjad = new TerminalExpression("sajjad");

            IExpression or1 = new OrExpression(robert, julie);
            IExpression or2 = new OrExpression(pouya, or1);
            IExpression or3 = new OrExpression(ali, or2);

            IExpression res = new OrExpression(sajjad, or3);

            return res;
        }
    }
}