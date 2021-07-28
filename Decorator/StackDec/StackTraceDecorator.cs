using System;

namespace Design_Pattern.Decorator.StackDec
{
    public class StackTraceDecorator : IStack
    {
        private readonly IStack _stack;
        public StackTraceDecorator(IStack stack) => _stack = stack;

        public int? Pop()
        {

            int? result = _stack.Pop();
            if (result != null)
                Console.WriteLine(result.ToString() + ":Pop()");
            return result;
        }

        public void Push(int value)
        {

            _stack.Push(value);
            Console.WriteLine("Push (" + value.ToString() + ")");
        }
    }
}