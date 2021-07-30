namespace Design_Pattern.Interpreter.CodeGate
{
    public abstract class AbsExpression : IExpression
    {
        public IExpression Expr1 { get; set; } = null;
        public IExpression Expr2 { get; set; } = null;
        public AbsExpression(IExpression expr1, IExpression expr2)
        {
            Expr1 = expr1;
            Expr2 = expr2;
        }
        public abstract bool Interpret(string context);
    }
}