using System;

namespace Design_Pattern.state
{
    public class NormalState : IState
    {
        public int MoveDown(Context context)
        {
            context.Counter -= 2;

            if (context.Counter < Context.limit)
            {
                context.State = new FastState();
                Console.Write("|| ");
            }
            return context.Counter;
        }

        public int MoveUp(Context context)
        {
            context.Counter += 2;
            return context.Counter;
        }
    }
    public class FastState : IState
    {
        public int MoveDown(Context context)
        {
            context.Counter -= 5;

            if (context.Counter < Context.limit)
            {
                context.State = new NormalState();
                Console.Write("|| ");
            }
            return context.Counter;
        }

        public int MoveUp(Context context)
        {
            context.Counter += 5;
            return context.Counter;
        }
    }
}