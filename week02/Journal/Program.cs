using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator randomPrompt = new PromptGenerator();
        Console.WriteLine(randomPrompt.GetRandomPrompt());

        Console.ReadKey();
    }
}