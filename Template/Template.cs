using System;
using design_pattern;

namespace Design_Pattern.Template
{
    public class Template : IRun
    {
        public void Run()
        {
            HouseTemplate woodi = new WoodHouse();
            HouseTemplate glassi = new GlassHouse();

            woodi.Build();
            Console.WriteLine("**********");
            glassi.Build();
        }
    }
}