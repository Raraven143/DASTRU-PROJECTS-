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
            //User Input. Asked User to Input data asked
            Console.WriteLine("We will get the area of your shape Circle and Rectangle. Please provide the data asked below.\n");          

            Console.WriteLine();

            Console.WriteLine("The Shape Circle \n");

            Console.Write("Enter the Radius: ");
            double inputRadius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Color of the Shape: ");
            string circleColor = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("The Shape Rectangle \n");

            Console.Write("Enter the Width of a Rectangle: ");
            double inputWidth = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Height of the Rectangle: ");
            double inputHeight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Color of the Shape: ");
            string rectangleColor = Console.ReadLine();

            Console.WriteLine();
        
        //Instantiate the object Circle
        Circle circle1 = new Circle();

            circle1.Color = circleColor;
            circle1.Radius = inputRadius;

            //Call the methods
            circle1.GetArea();
            circle1.CalculateArea();

            Console.WriteLine();
        //Instantiate the object Rectangle
        Rectangle rectangle1 = new Rectangle();
            rectangle1.Color = rectangleColor;
            rectangle1.Width = inputWidth;
            rectangle1.Height = inputHeight;

            //Call the methods
            rectangle1.GetArea();
            rectangle1.CalculateArea();
        }
    }
}
