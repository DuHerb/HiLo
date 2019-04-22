using System;

using System.Collections.Generic;

namespace HiLoGame
{
  class Program
  {


    static void Main()
    {
      int userTarget;
      Console.WriteLine("Pick a number between 1 and 100");
      userTarget = int.Parse(Console.ReadLine());

      Guesser newGame = new Guesser(userTarget);

      newGame.Evaluate();

    }


  }
}
