namespace Design_Pattern.Decorator
{
    public class Component : IComponent
    {
        private readonly string _txt;
        public Component(string txt)
        {
            _txt = txt;

        }
        public string GetInfo() => _txt;

    }
}