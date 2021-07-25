namespace design_pattern.Test.Command
{
   /// <summary>
   //ConcreteCommand
   /// </summary>

   /// <summary>
   //SellCommand
   /// </summary>
   public class SellOrder : Order
   {
      public SellOrder(Stock stock) : base(stock) { }
      public override void Execute() => _stock.sell();
   }
   /// <summary>
   //BuyCommand
   /// </summary>
   public class BuyOrder : Order
   {
      public BuyOrder(Stock stock) : base(stock) { }
      public override void Execute() => _stock.buy();
   }
   public class DestroyOrder : Order
   {
      public DestroyOrder(Stock stock) : base(stock) { }
      public override void Execute() => _stock.destroy();
   }
   public class CreateOrder : Order
   {
      public CreateOrder(Stock stock) : base(stock) { }
      public override void Execute() => _stock.create();
   }
}