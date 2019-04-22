using System;
namespace TriangleTracker
{
     class Triangle
    {
        private int Side1;
        private int Side2;
        private int Side3;


        public Triangle(int side1, int side2, int side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }
        //is a triangle
        //side1 + side2 >= side3 && side1 + side3 >= side2 && side2 + side3 >= side1 && side1 !== 0 && side2 !== 0 && side3 !== 0
        //side1 === side2 && side1 === side3 && side2 === side3 equilateral
        //side1 === side2 || side1 === side3 || side2 === side3 isosceles
        //side1 !== side2 && side1 !== side3 && side2 !== side3 scalene
        public int IsTriangle(int side1, int side2, int side3)
        {
            if (side1 + side2 >= side3 && side1 + side3 >= side2 && side2 + side3 >= side1 && side1 != 0 && side2 != 0 && side3 != 0)
            {
                if (side1 == side2 && side1 == side3 && side2 == side3)
                {
                    return 1;
                }
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    return 2;
                }
                else if (side1 != side2 && side1 != side3 && side2 != side3)
                {
                    return 3;
                }
                else return 0;

            }
            else return 0;
        }
    }
}
