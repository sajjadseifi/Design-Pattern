namespace Design_Pattern.state
{
    public interface IState
    {
        int MoveUp(Context context);
        int MoveDown(Context context);
    }
}