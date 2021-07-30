using System;

namespace Design_Pattern.Interpreter.CodeGate
{
    public class AndExpression : AbsExpression
    {
        public AndExpression(IExpression expr1, IExpression expr2) : base(expr1, expr2) { }
        public override bool Interpret(string context) => Expr1.Interpret(context) && Expr2.Interpret(context);
    }
    public class OrExpression : AbsExpression
    {
        public OrExpression(IExpression expr1, IExpression expr2) : base(expr1, expr2) { }
        public override bool Interpret(string context) => Expr1.Interpret(context) || Expr2.Interpret(context);
    }
    public class TerminalExpression : IExpression
    {
        private string Data;
        public TerminalExpression(string data) => Data = data;
        public bool Interpret(string context)
        {
            var res = context.Contains(Data);
            Console.WriteLine("{0} is {1} in {2}", Data, res ? "ok" : "not contain", context);
            return res;
        }
    }
}