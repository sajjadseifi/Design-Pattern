using System;
using System.Collections.Generic;

namespace design_pattern.Command
{
   // public class CommandTest
   // {
   //    public static class ServiceLocator
   //    {
   //       private readonly static Dictionary<Type, object> services = new Dictionary<Type, object>();
   //       public static T GetService<T>()
   //       {
   //          return (T)ServiceLocator.services[typeof(T)];
   //       }
   //       public static void Register<T>(T service)
   //       {
   //          ServiceLocator.services[typeof(T)] = service;
   //       }
   //       public static void Reset()
   //       {
   //          ServiceLocator.services.Clear();
   //       }
   //    }
   //    interface IReceiver1
   //    {
   //       void Action1();
   //    }
   //    class Receiver1 : IReceiver1
   //    {
   //       public void Action1()
   //       {
   //          Console.WriteLine("Receiver1.Action1()");
   //       }
   //    }
   //    interface IReceiver2
   //    {
   //       void Action2();
   //    }
   //    class Receiver2 : IReceiver2
   //    {
   //       public void Action2()
   //       {
   //          Console.WriteLine("Receiver2.Action2()");
   //       }
   //    }
   //    abstract class Command1
   //    {
   //       public abstract void Execute();
   //    }
   //    class ConcreteCommand1 : Command1
   //    {
   //       private IReceiver1 receiver;
   //       public ConcreteCommand1(IReceiver1 receiver)
   //       {
   //          this.receiver = receiver;
   //       }
   //       public override void Execute()
   //       {
   //          Console.WriteLine("ConcreteCommand1.Execute()");
   //          receiver.Action1();
   //       }
   //    }
   //    class ConcreteCommand2 : Command1
   //    {
   //       public override void Execute()
   //       {
   //          Console.WriteLine("ConcreteCommand2.Execute()");
   //          var receiver = ServiceLocator.GetService<IReceiver2>();
   //          DoSomething();
   //          receiver.Action2();
   //       }
   //       private void DoSomething()
   //       {
   //          Console.WriteLine("ConcreteCommand2.DoSomething()");
   //       }
   //    }
   //    class SimpleInvoker
   //    {
   //       private Command1 command;
   //       public SimpleInvoker(Command1 command)
   //       {
   //          this.command = command;
   //       }
   //       public void Consume()
   //       {
   //          Console.WriteLine("\nSimpleInvoker.Consume()");
   //          command.Execute();
   //       }
   //    }
   //    class ComplexInvoker
   //    {
   //       private List<Command1> commands;
   //       public ComplexInvoker()
   //       {
   //          commands = new List<Command1>();
   //       }
   //       public void AddCommand(Command1 command)
   //       {
   //          commands.Add(command);
   //       }
   //       public void Play()
   //       {
   //          Console.WriteLine("\nComplexInvoker.Play()");
   //          foreach (var command in commands)
   //          {
   //             command.Execute();
   //          }
   //       }
   //    }
   //    class Test
   //    {
   //       static void Main()
   //       {
   //          ServiceLocator.Register<IReceiver1>(new Receiver1());
   //          ServiceLocator.Register<IReceiver2>(new Receiver2());

   //          var receiver1 = ServiceLocator.GetService<IReceiver1>();

   //          var cmd1 = new ConcreteCommand1(receiver1);
   //          var invoker1 = new SimpleInvoker(cmd1);
   //          invoker1.Consume();

   //          var invoker2 = new ComplexInvoker();
   //          invoker2.AddCommand(new ConcreteCommand1(receiver1));
   //          invoker2.AddCommand(new ConcreteCommand2());
   //          invoker2.Play();

   //          Console.ReadKey();
   //       }
   //    }
   // }

}