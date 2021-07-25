namespace design_pattern.Observer
{
   public class TestObserver : IRun
   {
      public void Run()
      {
         //observers
         var a = new ObserverA();
         var b = new ObserverB();
         var c = new ObserverC();

         //subject
         var subject = new Subject<object>();

         subject.Add(a);
         subject.Add(b);
         subject.Add(c);


         subject.SetState(10);
         subject.SetState("sallam");
         subject.SetState(new { Sajjad = 10, Alias = 20 });
      }
   }
}