namespace design_pattern.Test.Command
{
   //Command
   public abstract class Order
   {
      protected Stock _stock;
      public Order(Stock stock) => _stock = stock;

      public abstract void Execute();
   }
}