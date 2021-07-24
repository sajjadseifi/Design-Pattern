namespace design_pattern.itrator
{
   public class LinkedListItrator<T>
   {
      private Node<T> _root;
      private Node<T> _current;
      public LinkedListItrator(Node<T> root)
      {
         _root = root;
         _current = _root;
      }
      public bool Completed => _current == null;
      public void Reset()
      {
         _current = _root;
      }
      public T Next()
      {
         var value = _current.Value;
         _current = _current.Next;
         return value;
      }
   }
}