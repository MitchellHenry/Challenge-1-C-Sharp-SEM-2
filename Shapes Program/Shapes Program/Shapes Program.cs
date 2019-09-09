using System;
using System.Collections.Generic;
using Shapes_Class_Library;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            List<Square> Squares = new List<Square>();
            List<Rectangle> Rectangles = new List<Rectangle>();
            while (count != 1)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" What Shape Would you like to Make?");
                    Console.WriteLine(" - Square");
                    Console.WriteLine(" - Rectangle");
                    string ShapeType = Console.ReadLine();

                    if (ShapeType != "Square" && ShapeType != "Rectangle")
                    {
                        Console.WriteLine("Unknown Shape");
                    }
                    if (ShapeType == "Square")
                    {
                        int length = 1;
                        string squarecolor = "";
                        Console.WriteLine("Whats the side length of the square?");
                       
                                         
                        length = int.Parse(Console.ReadLine());

                        if (length < 1)
                        {
                            throw new NoNumbersLessThan1("Number must be 1 or above!");
                        }

                        Console.WriteLine("Whats the color of the square?");
                        squarecolor = Console.ReadLine();
                        Square New = new Square(squarecolor, length, length, length, length);
                        Squares.Add(New);
                    }
                    if (ShapeType == "Rectangle")
                    {
                        int length = 0;
                        int width = 0;
                        string Rectanglecolor = "";
                        Console.WriteLine("Whats the side length of the rectangle?");
                        length = int.Parse(Console.ReadLine());
                        Console.WriteLine("Whats the side width of the rectangle?");
                        width = int.Parse(Console.ReadLine());
                        Console.WriteLine("Whats the color of the rectangle?");
                        Rectanglecolor = Console.ReadLine();
                        Rectangle New = new Rectangle(Rectanglecolor, length, width, length, width);
                        Rectangles.Add(New);
                    }
                    Console.WriteLine("Would you like to make another shape? Yes/No");
                    string response = Console.ReadLine();
                    if (response == "No")
                    {
                        count = 1;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Would you like try make another shape? Yes/No");
                    string response = Console.ReadLine();
                    if (response == "No")
                    {
                        Environment.Exit(0);
                    }
                }
                catch (NoNumbersLessThan1 e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Would you like try make another shape? Yes/No");
                    string response = Console.ReadLine();
                    if (response == "No")
                    {
                        Environment.Exit(0);
                    }
                }
            }
            Environment.Exit(0);
        }
    }
}