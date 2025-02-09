using System;
using System.Threading;

namespace MindfulnessProgram
{
    public class Activity
    {
        protected string activityName;
        protected string description;
        protected int duration;

        public Activity(string name, string desc)
        {
            activityName = name;
            description = desc;
        }

        public virtual void Start()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Welcome to the {activityName} Activity.");
            Console.WriteLine(description);
            Console.Write("Please enter the duration of the activity in seconds: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out duration))
            {
                Console.WriteLine("Invalid input. Setting default duration to 30 seconds.");
                duration = 30;
            }
            Console.WriteLine("Get ready to begin...");
            CountDown(5);
        }

        protected void CountDown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
        }

        protected void AnimateSpinner(int seconds)
        {
            DateTime endTime = DateTime.Now.AddSeconds(seconds);
            while (DateTime.Now < endTime)
            {
                foreach (char c in new char[] { '|', '/', '-', '\\' })
                {
                    Console.Write(c);
                    Thread.Sleep(250);
                    Console.Write("\b \b");
                }
            }
        }

        public virtual void End()
        {
            Console.WriteLine();
            Console.WriteLine("Well done!");
            AnimateSpinner(3);
            Console.WriteLine($"You have completed the {activityName} Activity for {duration} seconds.");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();
        }
    }
}
