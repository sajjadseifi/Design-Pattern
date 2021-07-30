namespace Design_Pattern.Interpreter.Lang
{
    public abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }
}