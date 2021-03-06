// using design_pattern.ChainOfResposibility;
// using design_pattern.Command;
// using design_pattern.Interpreter;
// using design_pattern.Interpreter.Calc;
using design_pattern.Observer;
using design_pattern.Test;
using design_pattern.Test.Observer;
using Design_Pattern.AbstractFactory;
using Design_Pattern.Adapter;
using Design_Pattern.Bridg.MultiMailProvider;
using Design_Pattern.Builder;
using Design_Pattern.Composite;
using Design_Pattern.Decorator;
using Design_Pattern.Facade;
using Design_Pattern.Factory;
using Design_Pattern.Interpreter.CodeGate;
using Design_Pattern.Interpreter.Lang;
using Design_Pattern.Interpreter.RealWord;
using Design_Pattern.Memento;
using Design_Pattern.NullObject;
using Design_Pattern.Prototype;
using Design_Pattern.Proxy;
using Design_Pattern.state;
using Design_Pattern.Strategy;
using Design_Pattern.Template;
using Design_Pattern.Visitor;

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
            // Mem mem = new Mem();
            // mem.Run();
            // Client client = new Client();
            // client.Run();
            // ClientState client = new ClientState();
            // client.Run();
            // Visitor visitor = new Visitor();
            // visitor.Run();
            // Template template = new Template();
            // template.Run();
            // Proxy proxy = new Proxy();
            // proxy.Run();
            // Factory factory = new Factory();
            // factory.Run();
            // AbstractFactory absfac = new AbstractFactory();
            // absfac.Run();
            // MultiMailProvider mmp = new MultiMailProvider();
            // mmp.Run();
            // BuilerRunner builder = new BuilerRunner();
            // builder.Run();
            // Decorator decorator = new Decorator();
            // decorator.Run();
            // Adapter adapter = new Adapter();
            // adapter.Run();
            // Prototype prototype = new Prototype();
            // prototype.Run();
            // Composite composite = new Composite();
            // composite.Run();
            // Facade facade = new Facade();
            // facade.Run();
            // NullObject no = new NullObject();
            // no.Run();
            // Lang lng = new Lang();
            // lng.Run();
            // RealWord realWord = new RealWord();
            // realWord.Run();
            CodeGate cg = new CodeGate();
            cg.Run();
        }

    }
}
