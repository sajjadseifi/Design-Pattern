using System;

namespace Design_Pattern.Memento
{
    public class Originator<T>
    {
        private T _state;
        public Memento<T> CreateMemento()
        {
            var mem = new Memento<T>();
            mem.SetSate(_state);
            return mem;
        }
        public void SetMemento(Memento<T> mem) => _state = mem.GetSate();
        public void SetSate(T state) => _state = state;
        public void ShowState() => Console.WriteLine(_state.ToString());
    }
}