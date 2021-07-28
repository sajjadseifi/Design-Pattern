using System;
using design_pattern;
using Design_Pattern.Decorator.ComponentDec;
using Design_Pattern.Decorator.StackDec;

namespace Design_Pattern.Decorator
{
    public class Decorator : IRun
    {
        public void Run()
        {
            // this.ComponentRnu();
            this.StackRnu();
        }
        private void ComponentRnu()
        {
            var cmp = new Component("Simple Text");
            var cmpDec = new ComponentUppercaseDecorator(cmp);

            Console.WriteLine($"Component Info => {cmp.GetInfo()}");
            Console.WriteLine($"ComponentUppercaseDecorator Info => {cmpDec.GetInfo()}");
        }
        private void StackRnu()
        {
            //Orginal 
            IStack org = new Stack();
            org.Pop();
            org.Push(2);
            org.Push(3);
            org.Pop();
            org.Push(5);
            org.Push(9);
            org.Pop();
            org.Pop();
            org.Push(5);
            org.Push(5);

            Console.WriteLine("** Original Stack **");
            ((Stack)org).Show();

            //Trace Stack
            IStack traceStack = new StackTraceDecorator(org);
            Console.WriteLine("** Trace Stack **");
            traceStack.Pop();
            traceStack.Push(2);
            traceStack.Push(3);
            traceStack.Pop();
            traceStack.Push(5);
            traceStack.Push(9);
            traceStack.Pop();
            traceStack.Pop();
            traceStack.Push(5);
            traceStack.Push(5);


        }

    }
}