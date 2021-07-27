using System;

namespace Design_Pattern.Template
{
    public abstract class HouseTemplate
    {
        public void Build()
        {
            BuildFoundation();
            BuildPillars();
            BuildWalls();
            BuildWindows();
        }
        private void BuildWindows() => Console.WriteLine("Building Glass Windows...");
        public abstract void BuildWalls();
        public abstract void BuildPillars();
        private void BuildFoundation() => Console.WriteLine("Building foundation with cement,iron rods and sand...");
    }
}