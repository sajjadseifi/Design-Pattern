using design_pattern.Itrator;

namespace design_pattern.ChainOfResposibility
{
   public class ChainOfResposibile : IRun
   {
      class Test1 : IProccess { public bool Check() => true; }
      class Test2 : IProccess { public bool Check() => true; }
      class Test3 : IProccess { public bool Check() => false; }
      public void Run()
      {
         var processes = new LinkedList<IProccess>();
         processes.Add(new Test1());
         processes.Add(new Test2());
         processes.Add(new Test3());
         var Proccessor = new Proccessor(processes);

         Proccessor.Run();

      }
   }
}