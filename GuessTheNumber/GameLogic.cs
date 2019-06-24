using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GuessTheNumber
{
	class GameLogic
	{
		int guessedNumber;
		int secretNumber;		

		public void InitialiseGame()
		{

			Console.WriteLine("Type a number between 1-1000");
			secretNumber = Convert.ToInt32(Console.ReadLine());			
		}
	}
}
