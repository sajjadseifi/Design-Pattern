namespace Design_Pattern.Memento
{
    public class Memento<T>
    {
        private T _state;
        public T GetSate()=>_state;
        public T SetSate(T state)=>_state=state;
    }
}