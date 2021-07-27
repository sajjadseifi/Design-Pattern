using System;

namespace Design_Pattern.Visitor
{
    public class SalaryCalculator : IElementVisitor
    {
        public void Visit(Manager manager)
        {
            var salary = manager.WorkingHour * 10000;
            salary += manager.Wife * 25000;
            salary += manager.Children * 20000;
            salary -= manager.OffDays * 5000;
            Console.WriteLine("Manager's Salary is " + salary);
        }

        public void Visit(Employee employee)
        {
            var salary = employee.WorkingHour * 7000;
            salary += employee.Wife * 15000;
            salary += employee.Children * 10000;
            salary -= employee.OffDays * 6000;
            Console.WriteLine("Employee's Salary is " + salary);
        }

        public void Visit(Worker worker)
        {
            var salary = worker.WorkingHour * 6000;
            salary += worker.Wife * 5000;
            salary += worker.Children * 2000;
            salary -= worker.OffDays * 7000;
            Console.WriteLine("Worker's Salary is " + salary);
        }
    }
    class WageCalculator : IElementVisitor
    {
        public void Visit(Manager manager)
        {
            var wage = manager.OverHours * 30000;
            Console.WriteLine("Employee's wage is " + wage);
        }

        public void Visit(Employee employee)
        {
            var wage = employee.OverHours * 20000;
            Console.WriteLine("Employee's wage is " + wage);
        }

        public void Visit(Worker worker)
        {
            var wage = worker.OverHours * 15000;
            Console.WriteLine("Employee's wage is " + wage);
        }
    }
}