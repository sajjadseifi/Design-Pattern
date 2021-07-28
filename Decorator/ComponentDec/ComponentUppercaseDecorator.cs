namespace Design_Pattern.Decorator.ComponentDec
{
    public class ComponentUppercaseDecorator : IComponent
    {
        private readonly IComponent _component;
        public ComponentUppercaseDecorator(IComponent component)
        {
            _component = component;

        }
        public string GetInfo()
        {
            var info = _component.GetInfo();
            return info.ToUpper();
        }
    }
}