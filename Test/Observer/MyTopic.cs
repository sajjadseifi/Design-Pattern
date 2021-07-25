using System;
using System.Collections.Generic;

namespace design_pattern.Test.Observer
{
   public class MyTopic : ISubject
   {
      private readonly List<IObserver> _observers;
      private string _message;
      private bool _changed;
      private static object _checklock = new object();
      public MyTopic()
      {
         _observers = new List<IObserver>();
      }
      public object GetUpdate() => _message;
      public void Notify()
      {
         List<IObserver> observersLocal;
         lock (_checklock)
         {
            if (!_changed) return;
            observersLocal = new List<IObserver>(_observers);
            _changed = false;
         }
         observersLocal.ForEach(o => o.Update(this));
      }

      public void Register(IObserver obj)
      {
         if (obj == null)
            throw new NullReferenceException("Null Observer");
         lock (_checklock)
         {
            AddToObservers(obj);
         }

      }
      public void Registers(params IObserver[] objs)
      {
         if (objs == null)
            throw new NullReferenceException("Null Observer");
         lock (_checklock)
         {
            foreach (var obj in objs)
               AddToObservers(obj);
         }

      }
      private void AddToObservers(IObserver observer)
      {
         if (_observers.Contains(observer))
            return;

         this.PostMessage($"{observer.name} Joined in chat!");
         _observers.Add(observer);
      }

      public void UnRegister(IObserver obj)
      {
         lock (_checklock)
         {
            if (_observers.Contains(obj))
               _observers.Remove(obj);
         }
      }

      public void PostMessage(string message)
      {
         Console.WriteLine("Message Protected : " + message);
         _message = message;
         _changed = true;
         Notify();
      }
   }
}