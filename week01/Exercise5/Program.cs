using System;

class Program

{
  

  static void Main()
  {
    
    DisplayMessage();
    string UserName = PromptUserName();
    int FavoriteNumber = FavoriteNumberFunction();
    int SquaredNumber = SquareNumber(FavoriteNumber);
    Console.WriteLine($"Your username is {UserName}, the square of your favorite number is {SquaredNumber}.");
  }


static void DisplayMessage()
{
    
Console.WriteLine("Welcome to the program!");

}



static string PromptUserName()
{

Console.WriteLine("Please enter your User Name. ");
string UserName = (Console.ReadLine());
return UserName; 

}  


static int FavoriteNumberFunction()
{

Console.WriteLine("What is your favorite number? ");
int FavoriteNumber = int.Parse(Console.ReadLine());
return FavoriteNumber;

}


static int SquareNumber (int Number)
{

return Number * Number;

}



}