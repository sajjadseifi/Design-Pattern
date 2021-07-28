namespace Design_Pattern.Composite
{
    public interface IEmployee
    {
        string GetName();
        double GetSalary();
        void Add(IEmployee employee);
        void Remove(IEmployee employee);
        IEmployee GetChild(int i);
    }
}