namespace Design_Pattern.Visitor
{
    public interface IElementVisitor
    {
        void Visit(Manager manager);
        void Visit(Employee employee);
        void Visit(Worker worker);
    }
}