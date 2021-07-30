namespace Design_Pattern.Interpreter.CodeGate
{
    public interface IExpression
    {
        bool Interpret(string context);
    }
}