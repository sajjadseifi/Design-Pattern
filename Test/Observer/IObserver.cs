namespace design_pattern.Test.Observer
{
   public interface IObserver
   {
      string name { get; }
      void Update(ISubject sub);
   }
}