using System;

namespace Design_Pattern.AbstractFactory
{
    //Simple
    public class Chair : IChair
    {
        public Chair() => Console.WriteLine("Chair");
    }
    public class CoffeTable : ICoffeTable
    {
        public CoffeTable() => Console.WriteLine("CoffeTable");

    }
    public class Sofa : ISofa
    {
        public Sofa() => Console.WriteLine("Sofa");

    }
    //Honari
    public class ChairHonari : IChair
    {
        public ChairHonari() => Console.WriteLine("ChairHonari");

    }
    public class CoffeTableHonari : ICoffeTable
    {
        public CoffeTableHonari() => Console.WriteLine("CoffeTableHonari");

    }
    public class SofaHonari : ISofa
    {
        public SofaHonari() => Console.WriteLine("SofaHonari");

    }
    //Modern
    public class ChairModern : IChair
    {
        public ChairModern() => Console.WriteLine("ChairModern");

    }
    public class CoffeTableModern : ICoffeTable
    {
        public CoffeTableModern() => Console.WriteLine("CoffeTableModern");

    }
    public class SofaModern : ISofa
    {
        public SofaModern() => Console.WriteLine("SofaModern");

    }
}