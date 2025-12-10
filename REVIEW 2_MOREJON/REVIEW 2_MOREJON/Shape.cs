using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REVIEW_2_MOREJON
{
    abstract class Shape
    {
        //MOREJON, RAVEN T. | IT401A | REVIEW 2:  Object - Oriented Programming
        public string Color { get; set; }


        public virtual void GetArea()
        {
            Console.WriteLine($"The color of the shape is {Color}");
        }

        public abstract void CalculateArea(double Area);
    }

        class Circle : Shape
        {
            public double Radius { get; set; }

            public override void GetArea()
            {
                base.GetArea();
                Console.WriteLine($"The radius of the Circle: {Radius}");
            }

            public override void CalculateArea(double Area)
            {
                double circleArea = 3.14 * Radius;
                Console.WriteLine($"The area of the Circle: {circleArea}");
            }
        }

            class Rectangle : Shape
            {
                public double Width { get; set; }  
                public double Height { get; set; }
                
                public override void GetArea()
                {
                    base.GetArea();
                    Console.WriteLine($"The Width of the Rectangle: {Width}");
                    Console.WriteLine($"The Height of the Rectangle: {Height}");
                }

                public override void CalculateArea(double Area)
                {
                   double rectangleArea = Width * Height;
                    Console.WriteLine($"The Area of the Rectangle: {rectangleArea}");

                }

            }
    }
        

