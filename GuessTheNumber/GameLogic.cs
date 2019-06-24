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

		public void Guess()
		{
			Console.WriteLine("Is the number: ????");

		}
		//public Compare()
		//{
		//	char answer;
		//	if (true)
		//	{

		//	}
		//	Console.WriteLine("Is the guesse");
		//}









		//Console.WriteLine("My guess is 500!");
		//Console.WriteLine("\nsi your number over over or under?");


	}
}
