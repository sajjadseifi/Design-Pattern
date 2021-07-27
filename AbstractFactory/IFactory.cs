namespace Design_Pattern.AbstractFactory
{
    public abstract class IFactoryMobl
    {
        public void Build()
        {
            CreateChair();
            CreateCoffeTable();
            CreateSofa();
        }
        public abstract IChair CreateChair();
        public abstract ICoffeTable CreateCoffeTable();
        public abstract ISofa CreateSofa();
    }
}