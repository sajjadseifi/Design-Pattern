using System.Collections.Generic;

namespace Design_Pattern.Visitor
{
    public class FinancialSystem
    {
        public readonly List<IElement> _elements;
        public FinancialSystem() => _elements = new List<IElement>();
        public void Attach(IElement element) => _elements.Add(element);
        public void DeAttach(IElement element) => _elements.Remove(element);
        public void Accept(IElementVisitor visitor) => _elements.ForEach(el => el.Accept(visitor));
    }
}