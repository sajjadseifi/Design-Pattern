using design_pattern;

namespace Design_Pattern.Composite
{
    public class Composite : IRun
    {
        public void Run()
        {
            IEmployee emp1 = new Developer("emp1", 10000);
            IEmployee emp2 = new Developer("emp2", 15000);
            IEmployee manager1 = new Manager("manager1", 25000);
            manager1.Add(emp1);
            manager1.Add(emp2);
            IEmployee emp4 = new Developer("emp4", 10000);
            IEmployee emp5 = new Developer("emp5", 15000);
            IEmployee manager2 = new Manager("manager2", 25000);
            manager2.Add(emp4);
            manager2.Add(emp5);

            IEmployee emp3 = new Developer("emp3", 20000);
            Manager generalManager = new Manager("generalManager", 50000);

            generalManager.Add(emp3);
            generalManager.Add(manager1);
            generalManager.Add(manager2);

            generalManager.Print();
        }
    }
}