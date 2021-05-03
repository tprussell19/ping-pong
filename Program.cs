using System;
using System.Collections.Generic;


public class Program
{
  public static void Main()
  {
    Console.WriteLine("Please enter a number you would like to count up to for the game to begin: ");
    string userInput = Console.ReadLine();
    int parsedInput = int.Parse(userInput);

    Console.WriteLine("Your game is now starting:");
    for (int index = 1; index <= parsedInput; index++)
    {
      if (index % 3 == 0 && index % 5 == 0)
      {
        Console.WriteLine("ping-pong");
      }
      else if (index % 3 == 0)
      {
        Console.WriteLine("ping");
      }
      else if (index % 5 == 0)
      {
        Console.WriteLine("pong");
      }
      else
      {
        Console.WriteLine(index);
      }
    }
  }
}

