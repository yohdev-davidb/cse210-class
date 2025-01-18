using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> userNumbers = new List<int>();
        
        Console.WriteLine("Enter a number to add to the list. Type 0 when you are done. ");
       
       int userInputs;
       userInputs = 0;

       do
       
       {
        userInputs = int.Parse(Console.ReadLine());

        if (userInputs > 0)
        {
            userNumbers.Add(userInputs);
        }
      
       } while (userInputs != 0);

    
        int totalSum = 0;


    foreach (int userNumber in userNumbers)
    {
        totalSum = (totalSum += userNumber);
    }
    
    
    Console.WriteLine($"The Total Sum is: {totalSum}");
    
    
    
    }





}