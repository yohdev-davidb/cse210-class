using System;

namespace MindfulnessProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Dave! Welcome to the Mindfulness Program.");
            bool continueProgram = true;
            while (continueProgram)
            {
                Console.WriteLine();
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Start Breathing Activity");
                Console.WriteLine("2. Start Reflection Activity");
                Console.WriteLine("3. Start Listing Activity");
                Console.WriteLine("4. Quit");
                Console.Write("Select an option (1-4): ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        BreathingActivity breathing = new BreathingActivity();
                        breathing.Start();
                        breathing.Run();
                        breathing.End();
                        break;
                    case "2":
                        ReflectionActivity reflection = new ReflectionActivity();
                        reflection.Start();
                        reflection.Run();
                        reflection.End();
                        break;
                    case "3":
                        ListingActivity listing = new ListingActivity();
                        listing.Start();
                        listing.Run();
                        listing.End();
                        break;
                    case "4":
                        Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye Dave!");
                        continueProgram = false;
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please choose a valid option from the menu.");
                        break;
                }
            }
        }
    }
}
