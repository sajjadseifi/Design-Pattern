using System;

namespace design_pattern.Interpreter
{
   public class Interpret : IRun
   {
      public void Run()
      {
         var str = "order x20 'Sajjad Seifi PRODUCT' from Coco";
         GGql q = GGql.Interpreter(str);
         Console.WriteLine($"\n qty={q.qty} \n product={q.product} \n source={q.source}");

      }
   }
}