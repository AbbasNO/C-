using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.Clear();
            AIPlayer newGame = new AIPlayer();
			newGame.Run();
        }
    }
}
