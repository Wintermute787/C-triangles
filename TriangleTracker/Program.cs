using System;

namespace TriangleTracker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter length for side 1");
            int side1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter length for side 2");
            int side2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter length for side 3");
            int side3 = int.Parse(Console.ReadLine());

            Triangle shape = new Triangle(side1, side2, side3);
            int holdNum = shape.IsTriangle(side1, side2, side3);
            if (holdNum == 1)
            {
                Console.WriteLine("It is an Equilateral Triangle");
            }
            else if (holdNum == 2)
            {
                Console.WriteLine("It is an Isosceles Triangle");
            }
            else if (holdNum == 3)
            {
                Console.WriteLine("It is a Scalene Triangle");
            }
            else if (holdNum == 0)
            {
                Console.WriteLine("NOT A TRIANLGE");
            }
            else Console.WriteLine("HOW DID YOU GET HERE");
        }
    }
}
