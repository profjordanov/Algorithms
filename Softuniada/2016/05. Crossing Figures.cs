using System;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        public const double Epsilon = 0.01;

        private static Rectangle rectangle;
        private static Circle circle;

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            int testCases = int.Parse(Console.ReadLine());
            for (int testCase = 0; testCase < testCases; testCase++)
            {
                ReadFigures();
                bool topLeftInsideCircle = circle.IsInsideCircle(rectangle.TopLeft);
                bool topRightInsideCircle = circle.IsInsideCircle(rectangle.TopRight);
                bool bottomLeftInsideCircle = circle.IsInsideCircle(rectangle.BottomLeft);
                bool bottomRightInsideCircle = circle.IsInsideCircle(rectangle.BottomRight);

                bool topInsideRectangle = rectangle.IsInsideRectangle(circle.Top);
                bool rightInsideRectangle = rectangle.IsInsideRectangle(circle.Right);
                bool bottomInsideRectangle = rectangle.IsInsideRectangle(circle.Bottom);
                bool leftInsideRectangle = rectangle.IsInsideRectangle(circle.Left);
                if (topLeftInsideCircle && topRightInsideCircle && bottomLeftInsideCircle && bottomRightInsideCircle)
                {
                    Console.WriteLine("Rectangle inside circle");
                }
                else if (topInsideRectangle && rightInsideRectangle && bottomInsideRectangle && leftInsideRectangle)
                {
                    Console.WriteLine("Circle inside rectangle");
                }
                else
                {
                    // None is inside the other. Check boundary conditions
                    var centerDistance = new Point(Math.Abs(circle.Center.X - rectangle.Center.X), Math.Abs(circle.Center.Y - rectangle.Center.Y));
                    var width = rectangle.TopRight.X - rectangle.TopLeft.X;
                    var height = rectangle.TopLeft.Y - rectangle.BottomLeft.Y;
                    if (centerDistance.X > width / 2 + circle.Radius || centerDistance.Y > height / 2 + circle.Radius)
                    {
                        Console.WriteLine("Rectangle and circle do not cross");
                    }
                    else if (centerDistance.X <= width / 2 || centerDistance.Y <= height / 2)
                    {
                        Console.WriteLine("Rectangle and circle cross");
                    }
                    else
                    {
                        var cornerDistance = (centerDistance.X - width / 2) * (centerDistance.X - width / 2) + (centerDistance.Y - height / 2) * (centerDistance.Y - height / 2);
                        if (cornerDistance - circle.Radius * circle.Radius <= Epsilon)
                        {
                            Console.WriteLine("Rectangle and circle cross");
                        }
                        else
                        {
                            Console.WriteLine("Rectangle and circle do not cross");
                        }
                    }
                }
            }

        }

        private static void ReadFigures()
        {
            for (var i = 0; i < 2; i++)
            {
                var figureParts = Console.ReadLine().Split(new[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

                switch (figureParts[0])
                {
                    case "rectangle":
                        rectangle = Rectangle.Parse(figureParts[1]);
                        break;
                    case "circle":
                        circle = Circle.Parse(figureParts[1]);
                        break;
                }
            }
        }
    }

    public class Point
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; }

        public double Y { get; }
    }

    public class Circle
    {
        public Circle(Point center, double radius)
        {
            Center = center;
            Radius = radius;
            Top = new Point(center.X, center.Y + radius);
            Bottom = new Point(center.X, center.Y - radius);
            Right = new Point(center.X + radius, center.Y);
            Left = new Point(center.X - radius, center.Y);

        }

        public Point Center { get; }

        public double Radius { get; }

        public Point Top { get; }

        public Point Right { get; }

        public Point Bottom { get; }

        public Point Left { get; }

        public static Circle Parse(string circleString)
        {
            double[] circleCoords = circleString
                .Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            return new Circle(new Point(circleCoords[0], circleCoords[1]), circleCoords[2]);
        }

        public bool IsInsideCircle(Point point)
        {
            return (point.X - Center.X) * (point.X - Center.X) +
                   (point.Y - Center.Y) * (point.Y - Center.Y) -
                   Radius * Radius <= Program.Epsilon;
        }
    }

    public class Rectangle
    {

        public Rectangle(Point topLeft, Point topRight, Point bottomLeft, Point bottomRight, Point center)
        {
            TopLeft = topLeft;
            TopRight = topRight;
            BottomLeft = bottomLeft;
            BottomRight = bottomRight;
            Center = center;
        }

        public Point TopLeft { get; }

        public Point TopRight { get; }

        public Point BottomLeft { get; }

        public Point BottomRight { get; }

        public Point Center { get; }

        public static Rectangle Parse(string rectangleString)
        {
            var rectangleCoords = rectangleString
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            return new Rectangle(
                new Point(rectangleCoords[0], rectangleCoords[1]),
                new Point(rectangleCoords[2], rectangleCoords[1]),
                new Point(rectangleCoords[0], rectangleCoords[3]),
                new Point(rectangleCoords[2], rectangleCoords[3]),
                new Point((rectangleCoords[0] + rectangleCoords[2]) / 2, (rectangleCoords[1] + rectangleCoords[3]) / 2));
        }

        public bool IsInsideRectangle(Point point)
        {
            return TopLeft.X <= point.X &&
                   point.X <= TopRight.X &&
                   BottomRight.Y <= point.Y &&
                   point.Y <= TopRight.Y;
        }
    }
}
