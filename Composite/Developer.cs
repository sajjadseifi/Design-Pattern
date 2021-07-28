using System;

namespace Design_Pattern.Composite
{
    public class Developer : Emolpyee
    {
        public Developer(string name, int salary) : base(name, salary) { }

        public override void Add(IEmployee employee)
        {
            Console.WriteLine("Develper Cant Not Add emplooye to child");
        }
        public override void Remove(IEmployee employee)
        {
            Console.WriteLine("Develper Cant Not Remove emplooye to child");
        }
    }
}