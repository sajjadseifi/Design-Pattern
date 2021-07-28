using System;

namespace Design_Pattern.Composite
{
    public class Manager : Emolpyee
    {
        public Manager(string name, int salary) : base(name, salary) { }
        public override void Add(IEmployee employee) => _employees.Add(employee);
        public override void Remove(IEmployee employee) => _employees.Add(employee);
    }
}