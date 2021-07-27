using System;

namespace Design_Pattern.Proxy
{
    public class RealImage : IImageProxy
    {
        private string _filename;
        public RealImage(string filename)
        {
            _filename = filename;
            LoadFromDisk();
        }
        protected void LoadFromDisk() => Console.WriteLine($"Loading {_filename}");
        public void Display() => Console.WriteLine($"Display {_filename}");
    }
}