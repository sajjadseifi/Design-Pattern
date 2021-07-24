using System;

namespace design_pattern.Itrator
{
   public class Itrat : IRun
   {
      public void Run()
      {
         var list = new LinkedList<int>();
         list.Add(1);
         list.Add(10);
         list.Add(3);
         list.Add(5);
         list.Add(8);
         list.Add(3);
         var itrator = list.Itrator;
         Console.WriteLine("start itrate proccess");
         while (!itrator.Completed)
         {
            var value = itrator.Next();
            Console.WriteLine($"{value}");
         }
         Console.WriteLine("end itrate proccess");
      }
   }
}