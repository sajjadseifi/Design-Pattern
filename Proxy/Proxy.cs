using System;
using design_pattern;

namespace Design_Pattern.Proxy
{
    public class Proxy : IRun
    {
        public void Run()
        {

            var filename = "text.txt";

            Console.WriteLine("**** Without Proxy ****");

            var image = new RealImage(filename);//loading  image and use system resource	

            // Call some other methods to attach image to related user. 

            Console.WriteLine("image object attached to user object .");

            image.Display();

            //---------------------------------------------------------------------------------------------

            Console.WriteLine("**** Without Proxy ****");

            var proxImage = new ProxyImage(filename);//loading  image and use system resource	

            // Call some other methods to attach image to related user. 

            Console.WriteLine("image object attached to user object .");

            proxImage.Display();
        }
    }
}