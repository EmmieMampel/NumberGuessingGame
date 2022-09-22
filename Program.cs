using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            //generate a number between 0 and 100
            int winNum = r.Next(0, 100);

            bool win = false;

            //loop
            do
            {
                Console.WriteLine("Guess a number inbetween 0 and 100: ");
                string s = Console.ReadLine();

                int i = int.Parse(s);

                if (i > winNum)
                {
                    Console.WriteLine("Too high, guess lower");
                }
                else if(i < winNum)
                {
                    Console.WriteLine("Too low, guess higher");
                }
                else if (i == winNum)
                {
                    Console.WriteLine("You win!");
                    win = true;
                }

            } while (win == false);
        }
    }
}
