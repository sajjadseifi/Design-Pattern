using System;

namespace design_pattern.Command
{
   class Receiver
   {
      static int i = 0;

      public void Action() => Console.WriteLine($"Called Receiver.Action({++i})");
   }
}