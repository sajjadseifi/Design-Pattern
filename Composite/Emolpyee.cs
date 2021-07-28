using System;
using System.Collections.Generic;

namespace Design_Pattern.Composite
{
    public abstract class Emolpyee : IEmployee, IPrint
    {
        protected readonly string name;
        protected readonly int salary;
        protected readonly List<IEmployee> _employees;
        public Emolpyee(string name, int salary)
        {
            this.salary = salary;
            this.name = name;
            _employees = new List<IEmployee>();
        }
        public string GetName() => this.name;
        public double GetSalary() => this.salary;
        public abstract void Add(IEmployee employee);
        public abstract void Remove(IEmployee employee);
        public IEmployee GetChild(int i) => null;
        private void PritWithSpace(int space = 0)
        {
            string spacestr = "";
            for (int i = 0; i < space; i++) spacestr += " ";

            Console.WriteLine(spacestr + "*******");
            Console.WriteLine(spacestr + $"Name = {name}");
            Console.WriteLine(spacestr + $"Salary = {salary}");
            Console.WriteLine(spacestr + "*******");

            if (_employees.Count > 0)
            {
                Console.WriteLine(spacestr + "{");
                _employees.ForEach(emp => ((Emolpyee)emp).PritWithSpace(space + 10));
                Console.WriteLine(spacestr + "}");
            }

        }
        public virtual void Print() => PritWithSpace();
    }
}