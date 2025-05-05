using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ForcedPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listOfShapes = new IShape[]
            {
                new Circle("bastian",15),
                new Rectangle("Rechteck_1",5,15),
                new Circle("Olaf",20),
                new Rectangle("Rechteck_2",4,7),
                
                
            };

            Array.Sort(listOfShapes);

            DrawShaps(listOfShapes);
        }

        private static void DrawShaps(IShape[] listOfShapes)
        {
            foreach (var shape in listOfShapes)
            {
                Debug.WriteLine($"Drawing Shape {shape.Name}...");
                shape.Draw();
            }
        }
    }
}
