using System;

using System.Collections.Generic;

namespace HiLoGame
{

  class Guesser
  {
    Random rand = new Random();
    int compGuess;
    private int min = 0;
    private int max = 100;
    private int Target;

    public Guesser(int target)
    {
      Target = target;
    }

    public void Evaluate()
    {
      compGuess = rand.Next(min, max);
      if (compGuess == Target)
      {
        Console.WriteLine("Computer wins");
      }
      else
      {
        Console.WriteLine("If your number higher: 'Press 1'");
        Console.WriteLine("If your number lower: 'Press 2'");
        string userResponse = Console.ReadLine();
        Console.WriteLine(userResponse);
      }
    }
  }
}
