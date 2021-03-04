using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int SecretNum = SecretNumPicker();
            int chances = SetDifficulty();

            if (chances == -1)
            {
                int i = 0;
                while (true)
                {
                    Console.Write($"Guess the secret number({i + 1}): ");
                    string strGuess = Console.ReadLine();
                    int guess = int.Parse(strGuess);

                    if (guess == SecretNum)
                    {
                        Console.WriteLine("You guessed correctly!");
                        break;
                    }
                    else
                    {
                        i++;
                        Console.WriteLine("That wasn't the secret number.");
                        GuessRange(guess, SecretNum);
                    }
                }
            }
            else
            {
                for (int i = 0; i < chances; i++)
                {
                    Console.Write($"Guess the secret number({i + 1}): ");
                    string strGuess = Console.ReadLine();
                    int guess = int.Parse(strGuess);

                    if (guess == SecretNum)
                    {
                        Console.WriteLine("You guessed correctly!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That wasn't the secret number.");
                        GuessRange(guess, SecretNum);
                    }
                }
            }


        }

        static int SecretNumPicker()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 101);
            return num;
        }

        static void GuessRange(int guess, int target)
        {
            if (guess > target)
            {
                Console.WriteLine("Your guess was too high.");
            }
            else if (guess < target)
            {
                Console.WriteLine("Your guess was too low.");
            }

        }

        static int SetDifficulty()
        {
            string difficulty = "unknown";
            while (difficulty != "easy" && difficulty != "medium" && difficulty != "hard" && difficulty != "cheater")
            {
                Console.Write("Select a difficulty (easy/medium/hard): ");
                difficulty = Console.ReadLine().ToLower();
            }
            if (difficulty == "easy")
            {
                return 8;
            }
            else if (difficulty == "medium")
            {
                return 6;
            }
            else if (difficulty == "hard")
            {
                return 4;
            }
            else
            {
                return -1;
            }

        }
    }
}
