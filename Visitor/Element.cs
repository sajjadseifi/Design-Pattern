namespace Design_Pattern.Visitor
{
    public class Manager : IElement
    {
        public int WorkingHour = 8;
        public int Wife = 1;
        public int Children = 3;
        public int OffDays = 6;
        public int OverHours = 12;

        public void Accept(IElementVisitor visitor) => visitor.Visit(this);

    }
    public class Employee : IElement
    {
        public int WorkingHour = 8;
        public int Wife = 1;
        public int Children = 3;
        public int OffDays = 6;
        public int OverHours = 12;

        public void Accept(IElementVisitor visitor) => visitor.Visit(this);

    }
    public class Worker : IElement
    {
        public int WorkingHour = 8;
        public int Wife = 1;
        public int Children = 3;
        public int OffDays = 6;
        public int OverHours = 12;

        public void Accept(IElementVisitor visitor) => visitor.Visit(this);

    }
}