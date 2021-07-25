using design_pattern.ChainOfResposibility;
using design_pattern.Interpreter;
using design_pattern.Interpreter.Calc;

namespace design_pattern
{
   class Program
   {
      static void Main(string[] args)
      {
         // Itrator itrator = new Itrator();
         //  itrator.Run();
         // Interpret interpreter = new Interpret();
         // interpreter.Run();
         // Calc calc = new Calc();
         // calc.Run();
         ChainOfResposibile cor = new ChainOfResposibile();
         cor.Run();
      }
   }
}
