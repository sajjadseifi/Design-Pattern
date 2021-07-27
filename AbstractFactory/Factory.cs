namespace Design_Pattern.AbstractFactory
{
    public class FactoryModern : IFactoryMobl
    {
        public override IChair CreateChair() => new ChairModern();
        public override ICoffeTable CreateCoffeTable() => new CoffeTableModern();
        public override ISofa CreateSofa() => new SofaModern();
    }
    public class FactoryHonari : IFactoryMobl
    {


        public override IChair CreateChair() => new ChairHonari();
        public override ICoffeTable CreateCoffeTable() => new CoffeTableHonari();
        public override ISofa CreateSofa() => new SofaHonari();
    }
    public class FactorySimple : IFactoryMobl
    {
        public override IChair CreateChair() => new Chair();
        public override ICoffeTable CreateCoffeTable() => new CoffeTable();
        public override ISofa CreateSofa() => new Sofa();
    }
}