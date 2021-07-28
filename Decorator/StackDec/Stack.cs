using System;
using System.Collections.Generic;

namespace Design_Pattern.Decorator.StackDec
{
    public class Stack : IStack
    {
        List<int> _ = new List<int>();

        public int? Pop()
        {
            if (_.Count == 0)
            {
                Console.WriteLine("Null Pointer!");
                return null;
            }

            int index = _.Count - 1;
            int item = _[index];
            _.RemoveAt(index);
            return item;
        }
        public void Push(int value)
        {
            _.Add(value);
        }
        public void Show() => _.ForEach(x => Console.WriteLine(x));
    }
}