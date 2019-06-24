﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GuessTheNumber
{

	public class AIPlayer
    {
		public bool gameOver = false;
		bool AIGoLow = false;
		bool AIGoHigh = false;
		int converted;

		private readonly UserPlayer secretNumber = new UserPlayer();

        Random randomNumber = new Random();

        public void Run()
        {
            double guessNumber = randomNumber.Next(475, 525);
            int count = 1;

            double maxValue = 1000;
            double minValue = 1;


            while (!gameOver)
            {
				converted = (int)guessNumber + 1;
                Console.WriteLine("AI: My " + count + ". guess is " + converted);
                


                AIGoLow = secretNumber.TooHigh(converted);
                AIGoHigh = secretNumber.TooLow(converted);


                if (AIGoLow && !AIGoHigh)
                {
                    maxValue = guessNumber;

                    double half = (maxValue - minValue) / 2;
                    guessNumber -= half + 1;

					AskTheUser();
                }
                else if (!AIGoLow && AIGoHigh)
                {
                    minValue = guessNumber;

                    double half = (maxValue - minValue) / 2;
                    guessNumber += half;

					AskTheUser();
                }
                else if (AIGoLow && AIGoHigh)
                {
                    Console.WriteLine("AI win the game");
                    gameOver = true;
                }
                if (count == 10 && !gameOver)
                {
                    Console.WriteLine("AI lost the game");
                    gameOver = true;
                }

                count++;                
            }

        }
		public void AskTheUser()
		{
			
			//AIGoLow = secretNumber.TooHigh(converted);
			//AIGoHigh = secretNumber.TooLow(converted);

			string answer;
			Console.WriteLine("Is the number higher(H) or lower(L) than my guess?");
			answer = Console.ReadLine().ToLower();
			if (answer == "h" && AIGoHigh)
			{
				Console.WriteLine("Okay, let me guess again");
			}
			else if (answer == "l" && AIGoLow)
			{
				Console.WriteLine("Okay, let me guess again");
			}
			else
			{
				Console.WriteLine("Please enter only H or L, and do not try to cheat!");
				AskTheUser();
			}
		}

    }
}
