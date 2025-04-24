using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForcedPolymorphism
{
    public interface IShape
    {
        string Name { get; }
       
        int Vertices { get; }
       
        void Draw();

    }
}
