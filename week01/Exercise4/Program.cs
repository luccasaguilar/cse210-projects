using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;
        int sum = 0;
        int largest = 0;
        int smallest = 999999999;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0) {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0) {
                numbers.Add(number);
            }
                            
        }

        foreach  (int i in numbers) {
            sum += i;
            if (i > largest) {
                largest = i;
            }
            if (i < smallest && i > 0) {
            smallest = i;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum / numbers.Count()}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
    }
}