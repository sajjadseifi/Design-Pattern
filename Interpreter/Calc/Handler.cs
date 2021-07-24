namespace design_pattern.Interpreter.Calc
{
   public class Handler
   {
      public class Add : IExpertion<int>
      {
         private readonly IExpertion<int> _left;
         private readonly IExpertion<int> _right;

         public Add(IExpertion<int> left, IExpertion<int> right)
         {
            _right = right;
            _left = left;
         }
         public int interpret(Context context) => _left.interpret(context) + _right.interpret(context);
      }
      public class Sub : IExpertion<int>
      {
         private readonly IExpertion<int> _left;
         private readonly IExpertion<int> _right;

         public Sub(IExpertion<int> left, IExpertion<int> right)
         {
            _right = right;
            _left = left;
         }
         public int interpret(Context context) => _left.interpret(context) - _right.interpret(context);
      }
   }
}