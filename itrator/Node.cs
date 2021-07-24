namespace design_pattern.Itrator
{
   public class Node<T>
   {
      public Node<T> Next;
      public T Value;

      public void Append(T value)
      {
         if (Next == null)
            Next = new Node<T> { Value = value };
         else
            Next.Append(value);
      }
      public T Get(int i) => i == 0 ? Value : Next.Get(--i);
   }
}