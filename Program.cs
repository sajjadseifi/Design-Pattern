using design_pattern.Interpreter;

namespace design_pattern
{
   class Program
   {
      static void Main(string[] args)
      {
         // Itrator itrator = new Itrator();
         //  itrator.Run();
         Interpret interpreter = new Interpret();
         interpreter.Run();
      }
   }
}
