using System.Collections.Generic;

namespace Design_Pattern.Adapter.Employee
{
    public class EmployeeAdapter : IEmployee
    {
        public void PrintEmployee(List<string> empList) => EmployeeDetail.ListEmployee(empList);
    }
}