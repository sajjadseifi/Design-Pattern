namespace design_pattern.Itrator
{
   public class LinkedList<T>
   {
      public Node<T> _next;
      public LinkedListItrator<T> Itrator => new LinkedListItrator<T>(_next);

      public void Add(T value)
      {
         if (_next == null)
            _next = new Node<T> { Value = value };
         else
            _next.Append(value);
      }
      public T Get(int i) => _next.Get(i);
   }
}