// Scenario 1: Fixing the bug in the code
// You can run this code by executing `dotnet run` command in the terminal.

//Task 1: Please identify the bug, and then fix the bug in the code.
//Task 2: Once you have fixed the bug, please add error handling to the code to handle the negative radius values.

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] radii = { 2, 5, 7, 0, -3 };
        foreach (int r in radii)
        {
            double area = CalculateArea(r);
            Console.WriteLine("Area of circle with radius {r} is {area}");
        }
    }

    static double CalculateArea(int radius)
    {
        double area = 3.14 * radius * radius;
        return area;
    }
}
