using System;
using System.Collections.Generic;
using System.Text;

namespace GuessTheNumber
{
    class AIPlayer
    {
        private readonly UserPlayer secretNumber = new UserPlayer();

        Random randomNumber = new Random();

        public void Run()
        {
            double guessNumber = randomNumber.Next(475, 525);
            int count = 1;

            double maxValue = 1000;
            double minValue = 1;

            bool gameOver = false;

            while (!gameOver)
            {
				int converted = (int)guessNumber + 1;
                Console.WriteLine("AI: My " + count + ". guess is " + converted);
                bool AIGoLow = false;
                bool AIGoHigh = false;


                AIGoLow = secretNumber.TooHigh(converted);
                AIGoHigh = secretNumber.TooLow(converted);


                if (AIGoLow && !AIGoHigh)
                {
                    maxValue = guessNumber;

                    double half = (maxValue - minValue) / 2;
                    guessNumber -= half + 1;

                    Console.WriteLine("Player says: Go lower.");
                }
                else if (!AIGoLow && AIGoHigh)
                {
                    minValue = guessNumber;

                    double half = (maxValue - minValue) / 2;
                    guessNumber += half;

                    Console.WriteLine("Player says: Go higher.");

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
                //Update

            }

        }
    }
}
