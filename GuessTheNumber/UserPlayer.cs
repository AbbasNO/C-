using System;
using System.Collections.Generic;
using System.Text;

namespace GuessTheNumber
{
    class UserPlayer
    {
        private int _secretNumber;


        public int SecretNumber
        {
            get { return _secretNumber; }
            set
            {
                if (value > 1000)
                {
                    _secretNumber = 1000;
                }
                else if (value < 1)
                {
                    _secretNumber = 1;
                }
                else
                {
                    _secretNumber = value;
                }

            }
        }



        public UserPlayer()
        {
            Console.WriteLine("Enter secret number between 1-1000");
            SecretNumber = Convert.ToInt32(Console.ReadLine());
        }



        public bool TooHigh(int number)
        {
            bool high = false;

            if (number >= _secretNumber)
            {
                high = true;

            }

            return high;
        }

        public bool TooLow(int number)
        {
            bool low = false;

            if (number <= _secretNumber)
            {
                low = true;
            }

            return low;
        }
    }
}
