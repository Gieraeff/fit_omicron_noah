using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ForcedPolymorphism
{
    public class Circle : IShape
    {
        private string _name;
        private int _radius;
        private int _vertices;

        public Circle(string name, int radius)
        {
            _name = name;
            _radius = radius;
            _vertices = int.MaxValue;
        }

        #region IShape implemenation

        public string Name
        {
            get { return _name; }
        }

        public int Vertices
        {
            get { return _vertices; }
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing the Circle {_name} with Radius: {_radius}.");
        }

        #endregion

        #region IComparable implemenation
        public int CompareTo(object obj)
        {
            return ShapeSortHelper.CompareTo(this, obj);
        }
        #endregion
    }
}
