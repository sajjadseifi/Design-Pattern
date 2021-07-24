namespace design_pattern.Interpreter.Calc
{
    public interface IExpertion<T>
    {
         T interpret(Context context);
    }
}