using System;
using System.Collections.Generic;

namespace Design_Pattern.Adapter.Employee
{
    public class EmployeeDetail
    {
        public static void ListEmployee(List<string> empList) => empList
            .ForEach(
                emp => Console.WriteLine("Employee Name: " + emp)
            );
    }
}