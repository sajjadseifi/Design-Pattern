using System;

namespace Design_Pattern.Facade.Resturant
{
    public class Menus { }
    public class VegMenus : Menus
    {
        public VegMenus() => Console.WriteLine("VegMenus");
    }
    public class NonVegMenus : Menus
    {
        public NonVegMenus() => Console.WriteLine("NonVegMenus");
    }
    public class BothMenus : Menus
    {
        public BothMenus() => Console.WriteLine("BothMenus");
    }
}