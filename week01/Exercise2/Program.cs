using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Let's calculate your letter grade.");
        Console.WriteLine();

        Console.WriteLine("What is your current grade percentage? ");
        string currentGrade = Console.ReadLine();
        int percentage = int.Parse(currentGrade);

        if (percentage >= 90)
        {
            Console.WriteLine("Your grade is an A.");
        }

        else if (percentage >= 80)

        {
            Console.WriteLine("Your grade is a B.");
        }

        else if (percentage >= 70)
        {
            Console.WriteLine("Your grade is a C.");
        }

        else if (percentage >= 60)
        {
            Console.WriteLine("Your grade is a D.");
        }

        else
        {
            Console.WriteLine("Your grade is a F.");
        }

        if (percentage >= 70)
        {
            Console.WriteLine("You Passed.");
        }

        else
        {
            Console.WriteLine("You Failed.");
        }



    }


}