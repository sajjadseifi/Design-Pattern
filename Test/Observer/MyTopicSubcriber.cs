using System;

namespace design_pattern.Test.Observer
{

   public class MyTopicSubscriber : IObserver
   {
      private string _name;
      public string name => _name;
      public MyTopicSubscriber(string name) => _name = name;

      public void Update(ISubject sub)
      {
         string msg = (string)sub.GetUpdate();
         if (msg == null)
         {
            Console.WriteLine(_name + "  ::  No new message!");
            return;
         }
         Console.WriteLine(_name + "  ::  Consuming message  ::  " + msg);
      }
   }
}