using System;
using System.Collections.Generic;
using System.Threading;

namespace Design_Pattern.Prototype
{
    public class Folder : IClonable<Folder>
    {
        public string _name { get; set; }
        public string _icon { get; set; }
        private bool _cloned { get; set; }
        public DateTime _createAt { get; set; }
        private List<File> _files { get; set; }
        private List<Folder> _childes { get; set; }
        public Folder(string name, string icon)
        {
            _name = name;
            _icon = icon;
            _cloned = false;
            _createAt = new DateTime();
            _files = new List<File>();
            _childes = new List<Folder>();
        }
        public void AddFolder(Folder folder) => _childes.Add(folder);
        public void RemoveFolder(Folder folder) => _childes.Remove(folder);
        public void AddFilde(File file) => _files.Add(file);
        public void RemoveFilde(File file) => _files.Remove(file);

        public Folder(string name, string icon, bool cloned)
        {
            _name = name;
            _icon = icon;
            _cloned = cloned;
            _createAt = new DateTime();
            _files = new List<File>();
            _childes = new List<Folder>();
        }
        private Folder(string name, string icon, bool cloned, DateTime createAt, List<Folder> childes, List<File> files)
        {
            _name = name;
            _icon = icon;
            _cloned = cloned;
            _createAt = createAt;
            _files = files;
            _childes = childes;
        }
        private Folder(string name, string icon, bool cloned, List<File> files)
        {
            _name = name;
            _icon = icon;
            _cloned = cloned;
            _createAt = new DateTime();
            _files = files;
            _childes = new List<Folder>();
        }
        private Folder(string name, string icon, bool cloned, List<File> files, List<Folder> childes)
        {
            _name = name;
            _icon = icon;
            _cloned = cloned;
            _createAt = new DateTime();
            _files = files;
            _childes = childes;
        }
        public Folder Clone()
        {
            var sleep = 100;
            Thread.Sleep(sleep);
            var clonedFiles = new List<File>();
            var clonedChildes = new List<Folder>();
            var newName = _name + " (1)";
            foreach (var f in _files)
                clonedFiles.Add(f.Clone());


            if (_childes.Count == 0)
            {
                ShowCopyDetale(_name, newName, clonedFiles, clonedChildes, sleep);
                return new Folder(newName, _icon, true, clonedFiles);
            }

            foreach (var folder in _childes)
            {
                Folder newFolder = folder.Clone();
                clonedChildes.Add(newFolder);
            }
            ShowCopyDetale(_name, newName, clonedFiles, clonedChildes, sleep);
            return new Folder(newName, _icon, true, clonedFiles, clonedChildes);
        }
        private void ShowCopyDetale(string prevName, string newName, List<File> files, List<Folder> childes, int ms)
        {

            var str = $"Copied Folder {_name} , target name {newName} , Folder {childes.Count} , Files {files.Count} , {ms} ms";
            Prototype.AnimatedStr(str, 5);
            //use builder
            Console.WriteLine();
        }


    }

}