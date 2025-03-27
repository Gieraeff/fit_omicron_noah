using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Step: " + i.ToString());
            }

            DateTime now = DateTime.Now;

            while (DateTime.Now.Hour == 20)
            {
                //...
                // do something
                
            }

            int w = 0;

            do
            {
                Console.WriteLine("Step:" + w.ToString());
                w++;
            }
            while (w < 5);
        }
    }
}
