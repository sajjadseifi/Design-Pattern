using System.Collections.Generic;

namespace Design_Pattern.Memento
{
    public class Caretaker<T>
    {
        private static List<Memento<T>> mems = new List<Memento<T>>();
        public static void SaveState(Originator<T> orig) => mems.Add(orig.CreateMemento());
        public static void RestoreState(Originator<T> orig, int stateNumber) => orig.SetMemento(mems[stateNumber]);
    }
}