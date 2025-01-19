using System;

class Program
{
  
  static void DisplayMessage()
{
    
    Console.WriteLine("Welcome to the program!");

}

static void PromptUserName(string UserName)
{
    
    Console.WriteLine("Choose a User Name.")
    UserName = (Conesole.ReadLine);

}

static void FavoriteNumberFunction(int FavoriteNumber)
{

Console.WriteLine("What is your favorite number?")
FavoriteNumber = int.Parse(Console.ReadLine);

}



}