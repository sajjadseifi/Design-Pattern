using design_pattern;

namespace Design_Pattern.Factory
{
    public class Factory : IRun
    {
        public void Run()
        {
            var car = new CarOrder();
            car.AddOrder("s");
            car.AddOrder("r");
            car.AddOrder("r");
            car.AddOrder("s");
            car.AddOrder("s");
            car.AddOrder("s");
            car.AddOrder("s");
            car.AddOrder("r");

            car.Show();
        }
    }
}