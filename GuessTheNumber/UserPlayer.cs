using System;
using System.Collections.Generic;
using System.Text;

namespace GuessTheNumber
{
    public class UserPlayer
    {
        private double _secretNumber;
		

        public double SecretNumber
        {
            get { return _secretNumber; }
            set
            {
				if (value < 1 || value > 1000)
				{
					Console.WriteLine("Wrong input, try again");
					var again = new UserPlayer();
				}
				else
				{
					_secretNumber = value;
				}

				////Alternative method to set the right property:
				
				//if (value > 1000)
				//{
				//	_secretNumber = 1000;
				//}
				//else if (value < 1)
				//{
				//	_secretNumber = 1;
				//}
				//else
				//{
				//	_secretNumber = value;
				//}

			}
        }

        public UserPlayer()
        {
			Console.WriteLine("Enter secret number between 1-1000");
			try
			{
				SecretNumber = Convert.ToInt32(Console.ReadLine());
			}
			catch (FormatException sfe)
			{
				Console.Clear();

				Console.WriteLine($"Error: {sfe.Message}");
				var again1 = new AIPlayer();
				again1.Run();
			}			
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
        }

        public bool TooHigh(double number)
        {
            bool high = false;

            if (number >= _secretNumber)
            {
                high = true;
            }

            return high;
        }

        public bool TooLow(double number)
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
