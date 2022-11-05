using System;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public string Go(int number)
        {
            if (number % 15 == 0 )
            {
                return "FizzBuzz";
            }
            else if (number%5 == 0)
            {
                return "Buzz";
            }
            else if (number % 3 == 0)
            {
                return "Fizz";
            }

            return number.ToString();
        }
    }
}
