using NUnit.Framework;
using Shapes_Class_Library;
using System;

namespace Shapes_Program
{
    [TestFixture]
    public class Tests
    {
        Square Sq1 { get; set; }
        Square Sq2 { get; set; }
        Square Sq3 { get; set; }
        Square Sq4 { get; set; }
        Square Sq5 { get; set; }
        Rectangle Rec1 { get; set; }
        Rectangle Rec2 { get; set; }
        Rectangle Rec3 { get; set; }
        Rectangle Rec4 { get; set; }
        Rectangle Rec5 { get; set; }



        [SetUp]
        public void Init()
        {
            Sq1 = new Square("Blue", 4 , 4, 4, 4);
            Sq2 = new Square("Blue", 6, 6, 6, 6);
            Sq3 = new Square("Blue", 5, 5, 5, 5);
            Sq4 = new Square("Blue", 15, 15, 15, 15);
            Sq5 = new Square("Blue", 7, 7, 7, 7);



            Rec1 = new Rectangle("Red", 4, 3, 4, 3);
            Rec2 = new Rectangle("Red", 5, 4, 5, 4);
            Rec3 = new Rectangle("Red", 5, 10, 5, 10);
            Rec4 = new Rectangle("Red", 4, 6, 4, 6);
            Rec5 = new Rectangle("Red", 9, 7, 9, 7);

        }

        [Test]
        public void SquareTests()
        {
            int area = 16;
            int perimeter = 16;

            Assert.AreEqual(area, Sq1.GetArea());
            Assert.AreEqual(perimeter, Sq1.GetPerimeter());

            area = 36;
            perimeter = 24;

            Assert.AreEqual(area, Sq2.GetArea());
            Assert.AreEqual(perimeter, Sq2.GetPerimeter());

            area = 25;
            perimeter = 20;

            Assert.AreEqual(area, Sq3.GetArea());
            Assert.AreEqual(perimeter, Sq3.GetPerimeter());

            area = 225;
            perimeter = 60;

            Assert.AreEqual(area, Sq4.GetArea());
            Assert.AreEqual(perimeter, Sq4.GetPerimeter());

            area = 49;
            perimeter = 28;

            Assert.AreEqual(area, Sq5.GetArea());
            Assert.AreEqual(perimeter, Sq5.GetPerimeter());

        }

        [Test]
        public void RectangleTests()
        {
            int area = 12;
            int perimeter = 14;

            Assert.AreEqual(area, Rec1.GetArea());
            Assert.AreEqual(perimeter, Rec1.GetPerimeter());

            area = 20;
            perimeter = 18;

            Assert.AreEqual(area, Rec2.GetArea());
            Assert.AreEqual(perimeter, Rec2.GetPerimeter());

            area = 50;
            perimeter = 30;

            Assert.AreEqual(area, Rec3.GetArea());
            Assert.AreEqual(perimeter, Rec3.GetPerimeter());

            area = 24;
            perimeter = 20;

            Assert.AreEqual(area, Rec4.GetArea());
            Assert.AreEqual(perimeter, Rec4.GetPerimeter());

            area = 63;
            perimeter = 32;

            Assert.AreEqual(area, Rec5.GetArea());
            Assert.AreEqual(perimeter, Rec5.GetPerimeter());

        }
    }
}