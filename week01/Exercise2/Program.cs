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

        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }

        else if (percentage >= 80)
        {
            letter = "B";
        }

        else if (percentage >= 70)
        {
            letter = "C";
        }

        else if (percentage >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }



        if (percentage >= 70)
        {
            Console.WriteLine($"You got a {letter}!");
            Console.WriteLine("You Passed.");
        }

        else
        {
            Console.WriteLine($"You got a {letter}.");
            Console.WriteLine("You Failed.");
        }



    }


}