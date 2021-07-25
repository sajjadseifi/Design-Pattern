namespace design_pattern.Test.Command
{
   //IReceiver
   public interface IStock
   {
      //action1
      void buy();
      //action2
      void sell();
   }
   public interface IStockDestroy
   {
      //action3
      void destroy();
   }
   public interface IStockCreate
   {
      //action4
      void create();
   }
}