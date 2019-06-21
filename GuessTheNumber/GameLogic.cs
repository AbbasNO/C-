using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GuessTheNumber
{
	class GameLogic
	{
		int correctNumber;
		int secretNumber;		

		public void InitialiseGame()
		{
			Console.WriteLine("Type a number between 1-1000");
			secretNumber = Convert.ToInt32(Console.ReadLine());
		}
		




		Console.WriteLine("My guess is 500!");
		Console.WriteLine("\nsi your number over over or under?");

		
	}
}
