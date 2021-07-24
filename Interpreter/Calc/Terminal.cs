namespace design_pattern.Interpreter.Calc
{
   public class Terminal : IExpertion<int>
   {
      private readonly string _number;
      public Terminal(string number) => _number = number;
      public int interpret(Context context) => context.getIntFormat(_number);

   }
}