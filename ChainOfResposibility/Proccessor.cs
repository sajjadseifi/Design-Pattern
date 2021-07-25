using System;
using design_pattern.Itrator;

namespace design_pattern.ChainOfResposibility
{
   public class Proccessor : IRun
   {

      protected LinkedList<IProccess> Successors;
      public Proccessor(LinkedList<IProccess> successors) => Successors = successors;

      public void Run()
      {
         var itrator = Successors.Itrator;
         var i = 1;
         while (!itrator.Completed)
         {
            var successor = itrator.Next();

            if (!successor.Check())
            {
               Console.WriteLine($"Task {i} Faild");
               break;
            }
            Console.WriteLine($"Task {i++} Completed");
         }
         itrator.Reset();
      }
   }
}