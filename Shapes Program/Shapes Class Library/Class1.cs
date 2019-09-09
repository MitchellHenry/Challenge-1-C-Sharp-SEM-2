using System;

namespace Shapes_Class_Library
{
    public abstract class Shape
    {
        public string Color;

        public Shape(string color)
        {
            Color = color;
        }
    }
    public abstract class Quadrilateral : Shape
    {
        public int SideLength1;
        public int SideLength2;
        public int SideLength3;
        public int SideLength4;
        public Quadrilateral(string color, int sidelength1, int sidelength2, int sidelength3, int sidelength4) : base(color)
        {
            SideLength1 = sidelength1;
            SideLength2 = sidelength2;
            SideLength3 = sidelength3;
            SideLength4 = sidelength4;
        }
        public int GetPerimeter()
        {
            int Perimeter = 0;
            Perimeter = SideLength1 + SideLength2 + SideLength3 + SideLength4;
            return Perimeter;
        }
    }


    public class Square : Quadrilateral
    {
        public Square(string color, int sidelength1, int sidelength2, int sidelength3, int sidelength4) : base(color, sidelength1, sidelength2, sidelength3, sidelength4)
        { }
        public int GetArea()
        {
            int Area = 0;
            Area = SideLength1 * SideLength1;
            return Area;
        }
    }
    public class Rectangle : Quadrilateral
    {
        public Rectangle(string color, int sidelength1, int sidelength2, int sidelength3, int sidelength4) : base(color, sidelength1, sidelength2, sidelength3, sidelength4)
        { }
        public int GetArea()
        {
            int Area = 0;
            Area = SideLength1 * SideLength2;
            return Area;
        }
    }
   public class NoNumbersLessThan1 : Exception
    {
        public NoNumbersLessThan1(string message) : base(message)
        {

        }
    }
}

