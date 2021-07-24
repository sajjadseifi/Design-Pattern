using System;

namespace design_pattern.Interpreter.Calc
{
   public class Calc : IRun
   {
      public void Run()
      {
         var context = new Context();
         var a = new Terminal("10");
         var b = new Terminal("12");
         var sub = new Handler.Sub(a, b).interpret(context);
         Console.WriteLine($"{a}-{b}={sub}");
         var add = new Handler.Add(a, b).interpret(context);
         Console.WriteLine($"{a}+{b}={add}");
      }
   }
}