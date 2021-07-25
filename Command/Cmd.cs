using System;

namespace design_pattern.Command
{
   public class Cmd : IRun
   {
      public void Run()
      {
         // Receiver receiver = new Receiver();
         // Command command = new ConcreteCommand(receiver);
         // Invoker invoker = new Invoker(command);
         // invoker.ExecuteCommand();
         // Receiver receiver2 = new Receiver();
         // Command command2 = new ConcreteCommand(receiver2);
         // invoker.SetCommand(command);
         // invoker.ExecuteCommand();

         Console.ReadKey();
      }
   }
}