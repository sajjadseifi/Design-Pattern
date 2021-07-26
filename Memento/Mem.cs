using design_pattern;

namespace Design_Pattern.Memento
{
    public class Mem : IRun
    {
        public void Run()
        {
            Originator<string> orig = new Originator<string>();
            orig.SetSate("state0");
            Caretaker<string>.SaveState(orig); //save state of the originator
            orig.ShowState();
            orig.SetSate("state1");
            Caretaker<string>.SaveState(orig); //save state of the originator
            orig.ShowState();
            orig.SetSate("state2");
            Caretaker<string>.SaveState(orig); //save state of the originator
            orig.ShowState();
            //restore state of the originator
            Caretaker<string>.RestoreState(orig, 0);
            orig.ShowState();  //shows state0

            //restore state of the originator
            Caretaker<string>.RestoreState(orig, 2);
            orig.ShowState();  //shows state2
        }
    }
}