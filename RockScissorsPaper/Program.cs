using System;

namespace RockScissorsPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - камень
            //2 - ножницы
            //3 - бумага
            //камень бьет ножницы, ножницы режут бумагу, а бумага оборачивает камень
            //игра должна продолжаться до того момента, пока один из игроков не наберет 3 очка

            int userScore = 0;
            int cpuScore = 0;

            Console.WriteLine("Rock, Paper or Scissors");
            Console.WriteLine("plays up to three points");
            Console.WriteLine("Variant choice:");

            while (userScore < 3 && cpuScore < 3)
            {
                Console.WriteLine();
                Console.WriteLine("Rock, Paper or Scissors");
                string userChoice = Console.ReadLine().ToLower();

                Console.WriteLine($"User choice {userChoice}");

                Random rnd = new Random();
                int random = rnd.Next(1, 4);
                string cpuChoice = "";

                switch (random)
                {
                    case 1:
                        cpuChoice = "Paper";
                        break;
                    case 2:
                        cpuChoice = "Rock";
                        break;
                    case 3:
                        cpuChoice = "Scissors";
                        break;
                }

                Console.WriteLine($"Cpu choice {cpuChoice}");

                if ((cpuChoice == "Paper" && userChoice == "Rock") || (cpuChoice == "Scissors" && userChoice == "Paper") || (cpuChoice == "Rock" && userChoice == "Scissors"))
                {
                    cpuScore++;
                    Console.WriteLine("User lose. Cpu wins!");
                }
                else if ((userChoice == "Rock" && cpuChoice == "Scissors") || (userChoice == "Paper" && cpuChoice == "Rock") || (userChoice == "Scissors" && cpuChoice == "Paper"))
                {
                    userScore++;
                    Console.WriteLine("User win! Cpu lose.");
                }
                else if (userChoice == cpuChoice)
                {
                    Console.WriteLine("This game was a draw.");
                }
                else
                {
                    cpuScore++;
                    Console.WriteLine("Invalid input from User, Cpu wins.");
                }

                Console.WriteLine($"User score: {userScore} - Cpu score: {cpuScore}");

            }

            if (userScore == 3)
            {
                userScore++;
                Console.WriteLine("User Win");

            }
            else
            {
                cpuScore++;
                Console.WriteLine("Cpu Wins");

            }

            Console.WriteLine("Have a nice day!");



        }
    }
}