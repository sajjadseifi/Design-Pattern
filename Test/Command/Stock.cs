using System;

namespace design_pattern.Test.Command
{
   //Reciver
   public class Stock : IStock, IStockDestroy, IStockCreate
   {
      private String name { get; set; } = "ABC";
      private int quantity { get; set; } = 10;
      public void buy() => Console.WriteLine("Stock [ Name: " + name + ", Quantity: " + quantity + " ] bought");
      public void sell() => Console.WriteLine("Stock [ Name: " + name + ", Quantity: " + quantity + " ] sold");
      public void destroy() => Console.WriteLine("Stock [ Name: " + name + ", Quantity: " + quantity + " ] destroy");
      public void create() => Console.WriteLine("Stock [ Name: " + name + ", Quantity: " + quantity + " ] create");
   }
}