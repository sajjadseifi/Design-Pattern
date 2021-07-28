using System;
using System.Threading;

namespace Design_Pattern.Prototype
{
    public class File : IClonable<File>
    {
        public string _name { get; set; }
        public string _icon { get; set; }
        private bool _cloned { get; set; }
        public DateTime _createAt { get; set; }
        public File(string name, string icon)
        {
            _name = name;
            _icon = icon;
            _cloned = false;
        }
        public File(string name, string icon, bool cloned)
        {
            _name = name;
            _icon = icon;
            _cloned = cloned;
        }
        private File(string name, string icon, bool cloned, DateTime createAt)
        {
            _name = name;
            _icon = icon;
            _cloned = cloned;
            _createAt = createAt;
        }
        public File Clone()
        {
            Thread.Sleep(300);
            var newName = _name + " (1)";
            var newFile = new File(newName, _icon, true, new DateTime());
            var str = $"Copied File {_name} , target name {newName} , 300 ms";
            Prototype.AnimatedStr(str, 5);
            Console.WriteLine();
            return newFile;
        }

    }
}