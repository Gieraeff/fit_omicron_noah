using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForcedPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape[] listOFShapes;

            foreach (var shape in listOFShapes)
            { 
                Debug.WriteLine($"Drawing Shape {shape.Name}...");
                shape.Draw();
            }
        }
    }
}
