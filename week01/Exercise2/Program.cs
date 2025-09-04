using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please inform your grade: ");
        int grade = int.Parse(Console.ReadLine());
        string letter;
        string grade_sign = "";
        Boolean approved = false;

        if (grade >= 90)
        {
            letter = "A";
            approved = true;
            if (grade < 93)
            {
                grade_sign = "-";
            }
        }
        else if (grade >= 80)
        {
            letter = "B";
            approved = true;
            if (grade >= 87)
            {
                grade_sign = "+";
            }
            if (grade < 83)
            {
                grade_sign = "-";
            }
        }
        else if (grade >= 70)
        {
            letter = "C";
            approved = true;
            if (grade >= 77)
            {
                grade_sign = "+";
            }
            if (grade < 73)
            {
                grade_sign = "-";
            }
        }
        else if (grade >= 60)
        {
            letter = "D";
            if (grade >= 67)
            {
                grade_sign = "+";
            }
            if (grade < 63)
            {
                grade_sign = "-";
            }
        }
        else
        {
            letter = "F";
        }


        if (approved)
        {
            Console.WriteLine($"Congratulations! You're approved with grade: {letter}{grade_sign}");
        }
        else
        {
            Console.WriteLine($"You're not approved with grade: {letter}{grade_sign}");
        }
    }    
}