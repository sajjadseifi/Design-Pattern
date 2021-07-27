using System;
using System.Collections.Generic;

namespace Design_Pattern.Factory
{
    public class CarOrder
    {
        protected CarFactory cf;
        protected List<ICar<string>> _orders;
        public CarOrder()
        {
            cf = new CarFactory();
            _orders = new List<ICar<string>>();
        }
        public void AddOrder(string model)
        {
            var car = cf.Make(model);
            _orders.Add(car);
        }
        public void Show()
        {
            _orders.ForEach(o => Console.WriteLine($"Car Model {o.GeModel()} Created."));
        }
    }
}