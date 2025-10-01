using System;

class Program
{
    static void Main(string[] args)
    {
        var assignment1 = new Assignment("Luccas Aguilar", "Test");
        Console.WriteLine(assignment1.GetSummary());

        var assignment2 = new MathAssignment("Jose Aguilar", "Test 2", "1.2", "8-9");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        var assignment3 = new WritingAssignment("Maria Aguilar", "Test 3", "The Test of Assignment");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}