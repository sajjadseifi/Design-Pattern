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
        private readonly int size;
        public File(string name, string icon, int size)
        {
            this.size = size;
            _name = name;
            _icon = icon;
            _cloned = false;
        }
        public File(string name, string icon, bool cloned, int size)
        {
            this.size = size;
            _name = name;
            _icon = icon;
            _cloned = cloned;

        }
        private File(string name, string icon, bool cloned, int size, DateTime createAt)
        {
            this.size = size;
            _name = name;
            _icon = icon;
            _cloned = cloned;
            _createAt = createAt;
        }
        public File Clone()
        {
            Thread.Sleep(this.size);
            var newName = _name + " (1)";
            var newFile = new File(newName, _icon, true, this.size, new DateTime());
            var str = $"Copied File {_name} , target name {newName} , {this.size} ms";
            Prototype.AnimatedStr(str, 5);
            Console.WriteLine();
            return newFile;
        }

    }
}