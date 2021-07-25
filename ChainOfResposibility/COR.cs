using System;

namespace design_pattern.ChainOfResposibility
{
   public class COR
   {
      public class Sup
      {
         public int X { get; set; }
         public int Y { get; set; }
         public int Z { get; set; }
      }

      public abstract class Handler
      {
         protected Handler _proccess;
         public abstract bool Check(Sup sup);

         public void Next(Handler newProcc, Sup sup)
         {
            if (_proccess.Check(sup))
            {
               _proccess.Next(newProcc, sup);
            }
         }
         public void setProccess(Handler proccess) => _proccess = proccess;
      }

      public class Leve1 : Handler
      {
         public override bool Check(Sup sup)
         {
            if (sup.X % 4 == 3)
               return false;

            Console.WriteLine($"Task Level1 Is Complet");
            return true;
         }
      }
      public class Leve2 : Handler
      {
         public override bool Check(Sup sup)
         {
            if (sup.Y % 4 == 3)
               return false;

            Console.WriteLine($"Task Level1 Is Complet");
            return true;
         }
      }
   }
}