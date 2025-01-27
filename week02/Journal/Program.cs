using System;

class Program
{
    static void Main(string[] args)
    {

        Entry journalEntry = new Entry();

        PromptGenerator randomPrompt = new PromptGenerator();
        Console.WriteLine(randomPrompt.GetRandomPrompt());

        Console.ReadKey();
    }
}