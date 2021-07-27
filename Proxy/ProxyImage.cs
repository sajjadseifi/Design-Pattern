using System;

namespace Design_Pattern.Proxy
{
    public class ProxyImage : IImageProxy
    {
        protected string _id;
        protected RealImage _image;
        protected readonly string _filename;
        public ProxyImage(string filename)
        {
            _filename = filename;
            Console.WriteLine("Image Loaded Affter Call Display....");
        }


        public void Display()
        {
            if (_image == null)
                _image = new RealImage(_filename);

            _image.Display();
        }
    }
}