using System;
using System.Collections.Generic;

namespace MindfulnessProgram
{
    public class ListingActivity : Activity
    {
        private List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity()
            : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
        }

        public override void Start()
        {
            base.Start();
            Random random = new Random();
            int index = random.Next(prompts.Count);
            Console.WriteLine();
            Console.WriteLine(prompts[index]);
            Console.WriteLine("You will have a few seconds to think about it...");
            CountDown(3);
            Console.WriteLine("Now, list as many items as you can. When you're done, press Enter on an empty line.");
        }

        public void Run()
        {
            List<string> items = new List<string>();
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(duration);
            while (DateTime.Now < endTime)
            {
                Console.Write("Enter an item: ");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                items.Add(input);
            }
            Console.WriteLine($"You listed {items.Count} items.");
        }
    }
}
