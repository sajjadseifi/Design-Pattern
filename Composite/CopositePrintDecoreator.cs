using System;

namespace Design_Pattern.Composite
{
    public class CopositePrintDecoreator : IPrint
    {
        private readonly IPrint _printer;
        public CopositePrintDecoreator(IPrint printer) => _printer = printer;

        public void Print()
        {
            _printer.Print();
        }

    }
}