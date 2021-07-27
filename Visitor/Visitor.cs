using design_pattern;

namespace Design_Pattern.Visitor
{
    public class Visitor : IRun
    {
        public void Run()
        {

            IElement manager = new Manager();
            IElement employee = new Employee();
            IElement worker = new Worker();

            var fine = new FinancialSystem();
            fine.Attach(manager);
            fine.Attach(employee);
            fine.Attach(worker);

            fine.Accept(new SalaryCalculator());
            fine.Accept(new WageCalculator());
        }
    }
}