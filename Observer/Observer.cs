namespace design_pattern.Observer
{
   public abstract class Observer<T>
   {
      public abstract void Update(Subject<T> subject);
   }
}