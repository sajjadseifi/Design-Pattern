using design_pattern;
using Design_Pattern.Facade.Resturant;
using Design_Pattern.Facade.Shape;

namespace Design_Pattern.Facade
{
    public class Facade : IRun
    {
        public void Run()
        {
            // Shape();
            Resturant();
        }
        public void Resturant()
        {
            ResturantKeeper rk = new ResturantKeeper();

            VegMenus v = rk.GetVegMenus();

            NonVegMenus nv = rk.GetNonVegMenus();

            BothMenus b = rk.GetBothMenus();

        }
        public void Shape()
        {
            ShapeMaker maker = new ShapeMaker();

            maker.DrawCircle();

            maker.DrawRectangle();

            maker.DrawPentagon();
        }
    }
}