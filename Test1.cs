using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to calculate its factorial:");
        int number = int.Parse(Console.ReadLine());

        long factorial = CalculateFactorial(number);
        Console.WriteLine($"Factorial of {number} is: {factorial}");

        Console.ReadLine();
    }

    static long CalculateFactorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * CalculateFactorial(n - 1);
    }
}

