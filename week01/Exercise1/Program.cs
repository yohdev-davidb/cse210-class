using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("What is your First Name?");
        string FirstName = Console.ReadLine();

        Console.WriteLine("What is your last name?");
        string LastName = Console.ReadLine();

        Console.WriteLine($"Your name is {LastName}, {FirstName} {LastName}.");

    }
}