using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> messageAction = ShowMessage;

            messageAction("Yurr Yurr");

            var shapesList = new List<Shape>
            {
                new Shape("Circle",int.MaxValue),
                new Shape("Rectangle", 4),
                new Shape("Hexagon", 6)
            };


            //make some subscriptions
            foreach (var shape in shapesList)
            {
                shape.ShapeIsDrawn += Shape_ShapeIsDrawn;
            }

            foreach (var shape in shapesList)
            {
                shape.Draw();
            }

            //remove some subscriptions
            //foreach (var shape in shapesList)
            //{
            //    shape.ShapeIsDrawn -= Shape_ShapeIsDrawn;
            //}

        }

        private static void Shape_ShapeIsDrawn(object sender, EventArgs e)
        {
            var shape = sender as Shape;
            if (shape == null)
            {
                return;
            }

            Console.WriteLine("EVENT:" + shape.Description + "is drawn.");
        }

        static void ShowMessage(string messageToShow)
        {
            Console.WriteLine(messageToShow.ToUpper());
        }
    }
}
