using System;
using System.Collections.Generic;
using design_pattern;
using Design_Pattern.Adapter.Bank;
using Design_Pattern.Adapter.Employee;
using Design_Pattern.Adapter.RealAdapter;

namespace Design_Pattern.Adapter
{
    public class Adapter : IRun
    {
        public void Run()
        {
            // CreditCard();
            // ReadAdapter();
            Employee();
        }
        public void Employee()
        {
            List<string> empList = new List<string>();

            empList.Add("Prakash");
            empList.Add("Amit");
            empList.Add("Pankaj");

            IEmployee emp = new EmployeeAdapter();

            emp.PrintEmployee(empList);
        }
        public void RealAdapter()
        {
            ISocketAdapter sockAdapter = new SocketObjectAdapterImpl();
            Volt v3 = ReadAdapter.GetVolt(sockAdapter, 3);
            Volt v12 = ReadAdapter.GetVolt(sockAdapter, 12);
            Volt v120 = ReadAdapter.GetVolt(sockAdapter, 120);
            Console.WriteLine("v3 volts using Object Adapter =" + v3.GetVolts());
            Console.WriteLine("v12 volts using Object Adapter =" + v12.GetVolts());
            Console.WriteLine("v120 volts using Object Adapter =" + v120.GetVolts());

            Console.WriteLine("********");

            sockAdapter = new SocketClassAdapterImpl();
            v3 = ReadAdapter.GetVolt(sockAdapter, 3);
            v12 = ReadAdapter.GetVolt(sockAdapter, 12);
            v120 = ReadAdapter.GetVolt(sockAdapter, 120);
            Console.WriteLine("v3 volts using Class Adapter =" + v3.GetVolts());
            Console.WriteLine("v12 volts using Class Adapter =" + v12.GetVolts());
            Console.WriteLine("v120 volts using Class Adapter =" + v120.GetVolts());

        }
        private void CreditCard()
        {
            ICreditCard targetInterface = new BankCustomer();
            targetInterface.generateBankDetails();
            Console.WriteLine(targetInterface.getCreditCard());
        }
    }
}