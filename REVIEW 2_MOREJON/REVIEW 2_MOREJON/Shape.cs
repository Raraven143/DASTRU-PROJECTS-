using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REVIEW_2_MOREJON
{   //MOREJON, RAVEN T. | IT401A | REVIEW 2:  Object - Oriented Programming
    abstract class Shape //THe Parent Class. Using Abstract
    {
        
        public string Color { get; set; }  //Short hand encapsulation for properties of Shape


        public virtual void GetArea() //Method for Parent Class
        {
            Console.WriteLine($"The color of the shape is {Color}");
        }

        public abstract void CalculateArea(); //Method for calculating the area. Will be inherit to Child Classes
    }

        class Circle : Shape //Child Class of Shape
        {
            public double Radius { get; set; } //Short hand encapsulation for properties of Circle

        public override void GetArea()
            {
                base.GetArea(); 
                Console.WriteLine($"The radius of the Circle: {Radius}"); 
            }

            public override void CalculateArea()
            {
                double circleArea = 3.14 * (Radius * Radius); //Calculation for getting are of the circle
                Console.WriteLine($"The area of the Circle: {circleArea}");
            }
        }

            class Rectangle : Shape //Child class of Shape 
            {
                //Short hand encapsulation for properties of Rectangle
                public double Width { get; set; }  
                public double Height { get; set; }
                
                public override void GetArea()
                {
                    base.GetArea();
                    Console.WriteLine($"The Width of the Rectangle: {Width}");
                    Console.WriteLine($"The Height of the Rectangle: {Height}");
                }

                public override void CalculateArea()
                {
                   double rectangleArea = Width * Height; //Calculation to get the Area of the Rectangle 
                    Console.WriteLine($"The Area of the Rectangle: {rectangleArea}");

                }

            }
    }
        

