using System;

namespace AssignmentApp.Tasks
{
    public class TriangleTypeIdentifier
    {
        public static void Run()
        {
            Console.Write("Enter side 1: ");
            double side1 = double.Parse(Console.ReadLine());

            Console.Write("Enter side 2: ");
            double side2 = double.Parse(Console.ReadLine());

            Console.Write("Enter side 3: ");
            double side3 = double.Parse(Console.ReadLine());

            if (side1 == side2 && side2 == side3)
                Console.WriteLine("Triangle Type: Equilateral");
            else if (side1 == side2 || side1 == side3 || side2 == side3)
                Console.WriteLine("Triangle Type: Isosceles");
            else
                Console.WriteLine("Triangle Type: Scalene");
        }
    }
}
