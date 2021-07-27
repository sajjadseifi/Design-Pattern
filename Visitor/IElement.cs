namespace Design_Pattern.Visitor
{
    public interface IElement
    {
        void Accept(IElementVisitor visitor);
    }
}