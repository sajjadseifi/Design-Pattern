// using design_pattern.ChainOfResposibility;
// using design_pattern.Command;
// using design_pattern.Interpreter;
// using design_pattern.Interpreter.Calc;
using design_pattern.Observer;
using design_pattern.Test;
using design_pattern.Test.Observer;
using Design_Pattern.Memento;

namespace design_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Itrator itrator = new Itrator();
            //  itrator.Run();
            // Interpret interpreter = new Interpret();
            // interpreter.Run();
            // Calc calc = new Calc();
            // calc.Run();
            // ChainOfResposibile cor = new ChainOfResposibile();
            // cor.Run();
            // Cmd cmd = new Cmd();
            // cmd.Run();
            // var testRun = new TestRuntime();
            // testRun.Run();
            // var Obs = new TestObserver();
            // Obs.Run();
            // Runner runner = new Runner();
            // runner.Run();
            Mem mem = new Mem();
            mem.Run();
        }
    }
}
