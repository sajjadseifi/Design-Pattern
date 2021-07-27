using System;

namespace Design_Pattern.Template
{

    public class WoodHouse : HouseTemplate
    {
        public override void BuildPillars() => Console.WriteLine("Building Wood Pillars...");
        public override void BuildWalls() => Console.WriteLine("Building Wood Walls...");
    }
    public class GlassHouse : HouseTemplate
    {
        public override void BuildPillars() => Console.WriteLine("Building Glass Pillars...");
        public override void BuildWalls() => Console.WriteLine("Building Glass Walls...");
    }
}