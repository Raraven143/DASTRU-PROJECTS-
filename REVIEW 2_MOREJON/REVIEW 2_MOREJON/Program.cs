using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REVIEW_2_MOREJON
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        Circle circle1 = new Circle();
            circle1.Color = "Black";
            circle1.Radius = 10;

            circle1.GetArea();
            circle1.CalculateArea(10);

         Rectangle rectangle1 = new Rectangle();
            rectangle1.Color = "Pink";
            rectangle1.Width = 6.7;
            rectangle1.Height = 12.5;
            rectangle1.GetArea();
            rectangle1.CalculateArea(6.7 * 12.5);
        }
    }
}
