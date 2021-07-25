using System;
using System.Collections.Generic;

namespace design_pattern.Observer
{
   public class Subject<T>
   {
      private List<Observer<T>> _observers;
      private T _state;
      public Subject() => _observers = new List<Observer<T>>();

      public void Add(Observer<T> observer) => _observers.Add(observer);
      public void SetState(T value)
      {
         _state = value;
         Console.WriteLine("State Changed...");
         Execute();
      }
      public T GetState() => _state;

      protected void Execute() => _observers.ForEach(o => o.Update(this));
   }
}