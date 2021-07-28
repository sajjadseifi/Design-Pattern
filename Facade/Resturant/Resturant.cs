namespace Design_Pattern.Facade.Resturant
{
    public class VegResturant : IResturant
    {
        public Menus GetMenus() => new VegMenus();
    }
    public class NonVegResturant : IResturant
    {
        public Menus GetMenus() => new NonVegMenus();
    }
    public class BothResturant : IResturant
    {
        public Menus GetMenus() => new BothMenus();
    }
}