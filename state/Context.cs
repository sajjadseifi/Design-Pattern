namespace Design_Pattern.state
{
    public class Context
    {
        public const int limit = 10;
        public IState State { get; set; }
        public int Counter = limit;
        public int Request(int n)
        {
            if (n == 2)
                return State.MoveUp(this);
            else
                return State.MoveDown(this);
        }
    }
}