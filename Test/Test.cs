using design_pattern.Test.Command;

namespace design_pattern.Test
{
   public class TestRuntime : IRun
   {
      public void Run()
      {
         //recever name= "abc"   quantity = 10  and plain action in calss 
         var abcStock = new Stock();

         //order is command
         //concrete_command
         var create = new CreateOrder(abcStock);
         var sell = new SellOrder(abcStock);
         var buy = new BuyOrder(abcStock);
         var destroy = new DestroyOrder(abcStock);

         //invoker
         var broker = new Broker();

         broker.AddOrder(create);
         broker.AddOrder(sell);
         broker.AddOrder(buy);
         broker.AddOrder(destroy);

         broker.placeOrders();
      }
   }
}