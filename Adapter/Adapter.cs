using System;
using design_pattern;
using Design_Pattern.Adapter.Bank;

namespace Design_Pattern.Adapter
{
    public class Adapter : IRun
    {
        public void Run()
        {
            ICreditCard targetInterface = new BankCustomer();
            targetInterface.generateBankDetails();
            Console.WriteLine(targetInterface.getCreditCard());
        }
    }
}