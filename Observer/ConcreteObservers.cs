using System;

namespace design_pattern.Observer
{

   public class ObserverA : Observer<object>
   {
      public override void Update(Subject<object> subject) => Console.WriteLine($"Observer A Alocated ${subject.GetState()}");
   }
   public class ObserverB : Observer<object>
   {
      public override void Update(Subject<object> subject) => Console.WriteLine($"Observer B Alocated ${subject.GetState()}");

   }
   public class ObserverC : Observer<object>
   {
      public override void Update(Subject<object> subject) => Console.WriteLine($"Observer C Alocated ${subject.GetState()}");
   }

}