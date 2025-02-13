// Scenario 3: Code Review and Refactoring.
// You can run the code by 'dotnet run' command in terminal.

// Task 1: Refactor and improve the efficiency and readability of the provided code.
// Task 2: Develop function to benchmark the performance of the 'ProcessNumbers' function.


using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> result = ProcessNumbers(numbers);
        foreach (int number in result)
        {
            Console.WriteLine(number);
        }
    }

    static List<int> ProcessNumbers(List<int> numbers)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                result.Add(numbers[i] * 2);
            }
            else
            {
                result.Add(numbers[i] * 3);
            }
        }
        return result;
    }
}
