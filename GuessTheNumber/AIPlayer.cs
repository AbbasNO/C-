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
            int guessNumber = randomNumber.Next(475, 525);
            int count = 1;

            int maxValue = 1000;
            int minValue = 1;

            bool gameOver = false;




            while (!gameOver)
            {
                Console.WriteLine("AI: My " + count + ". guess is " + guessNumber);
                bool AIGoLow = false;
                bool AIGoHigh = false;


                AIGoLow = secretNumber.TooHigh(guessNumber);
                AIGoHigh = secretNumber.TooLow(guessNumber);


                if (AIGoLow && !AIGoHigh)
                {
                    maxValue = guessNumber;

                    int half = (maxValue - minValue) / 2;
                    guessNumber -= half;

                    Console.WriteLine("Player says: Go lower.");
                }
                else if (!AIGoLow && AIGoHigh)
                {
                    minValue = guessNumber;

                    int half = (maxValue - minValue) / 2;
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
