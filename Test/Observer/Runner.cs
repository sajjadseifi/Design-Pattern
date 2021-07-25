namespace design_pattern.Test.Observer
{
   public class Runner : IRun
   {
      public void Run()
      {
         //create subject
         MyTopic topic = new MyTopic();

         //create observers
         IObserver obj1 = new MyTopicSubscriber("Obj1");
         IObserver obj2 = new MyTopicSubscriber("Obj2");
         IObserver obj3 = new MyTopicSubscriber("Obj3");

         topic.Registers(obj1, obj2, obj3);

         topic.PostMessage("Test Message");
      }
   }
}