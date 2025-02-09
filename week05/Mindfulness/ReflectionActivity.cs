using System;
using System.Collections.Generic;

namespace MindfulnessProgram
{
    public class ReflectionActivity : Activity
    {
        private List<string> prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private List<string> questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        public ReflectionActivity()
            : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
        {
        }

        public override void Start()
        {
            base.Start();
            Random random = new Random();
            int index = random.Next(prompts.Count);
            Console.WriteLine();
            Console.WriteLine(prompts[index]);
            Console.WriteLine("When you have something in mind, press Enter to continue.");
            Console.ReadLine();
        }

        public void Run()
        {
            DateTime endTime = DateTime.Now.AddSeconds(duration);
            Random random = new Random();
            while (DateTime.Now < endTime)
            {
                int index = random.Next(questions.Count);
                Console.WriteLine($"> {questions[index]}");
                AnimateSpinner(5);
                Console.WriteLine();
            }
        }
    }
}
