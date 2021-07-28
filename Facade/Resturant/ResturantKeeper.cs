namespace Design_Pattern.Facade.Resturant
{
    public class ResturantKeeper
    {
        public VegMenus GetVegMenus()
        {
            VegResturant v = new VegResturant();
            VegMenus veg = (VegMenus)v.GetMenus();
            return veg;
        }
        public NonVegMenus GetNonVegMenus()
        {
            NonVegResturant v = new NonVegResturant();
            NonVegMenus veg = (NonVegMenus)v.GetMenus();
            return veg;
        }
        public BothMenus GetBothMenus()
        {
            BothResturant v = new BothResturant();
            BothMenus veg = (BothMenus)v.GetMenus();
            return veg;
        }
    }
}