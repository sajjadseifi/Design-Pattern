namespace design_pattern.Test.Observer
{
   public interface ISubject
   {
      void Register(IObserver obj);
      void Registers(params IObserver[] obj);
      void UnRegister(IObserver obj);
      void Notify();
      object GetUpdate();
      void PostMessage(string message);
   }
}