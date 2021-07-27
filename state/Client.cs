using System;
using design_pattern;

namespace Design_Pattern.state
{
    public class ClientState : IRun
    {
        public void Run()
        {
            Context context = new Context();
            context.State = new NormalState();
            Random r = new Random(37);
            for (int i = 0; i <= 20; i++)
            {
                int command = r.Next(3);
                Console.Write(context.Request(command) + " ");
            }
            Console.WriteLine();
        }
    }

}
