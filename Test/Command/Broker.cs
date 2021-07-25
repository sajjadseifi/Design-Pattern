using System.Collections.Generic;

namespace design_pattern.Test.Command
{
   /// <summary>
   /// Invoker
   /// </summary>
   public class Broker
   {
      private readonly List<Order> _orders;
      public Broker() => _orders = new List<Order>();
      public void AddOrder(Order order) => _orders.Add(order);

      public void placeOrders() => _orders.ForEach(o => o.Execute());
   }
}