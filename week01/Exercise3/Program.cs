using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);


        Console.WriteLine("Guess the magic number.... ");
        int userGuess = int.Parse(Console.ReadLine());

        do
        {
            if (userGuess > number)
            {

                Console.WriteLine("Your guess was too high. Try again. ");
                userGuess = int.Parse(Console.ReadLine());
            }


            else if (userGuess < number)
            {
                Console.WriteLine("Your guess was too low. Try again. ");
                userGuess = int.Parse(Console.ReadLine());
            }

        } while (userGuess != number);

        Console.WriteLine("Congratulations! You guess the magic number! ");

    }
}