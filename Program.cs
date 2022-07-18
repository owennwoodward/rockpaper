// See https://aka.ms/new-console-template for more information

using System;

namespace rockpaper
{
    class Program

    {

        static void Main(string[] args)

        {


            bool play = true;
            string q;
            int userPoints = 0;
            int computerPoints = 0;
            int tiePoints = 0;
            while (play)
            {


                string userInput;
                string systemInput = "";
                int randomNum;
                Console.Write("Give an input from Rock/Paper/Scissors");
                userInput = Console.ReadLine();
                Random rnd = new Random();
                randomNum = rnd.Next(1, 4);

                switch (randomNum)
                {

                    case 1:
                        systemInput = "Rock";
                        Console.WriteLine("Computer Chose Rock");
                        if (userInput == "Rock" || userInput == "rock")
                        {
                            tiePoints++;
                            Console.WriteLine("Draw");
                        }
                        else if (userInput == "Paper" || userInput == "paper")
                        {
                            userPoints++;
                            Console.WriteLine("You Win");
                        }
                        else
                        {
                            computerPoints++;
                            Console.WriteLine("You Lose");
                        }
                        break;

                    case 2:
                        systemInput = "Paper";
                        Console.WriteLine("Computer Chose Paper");
                        if (userInput == "Rock" || userInput == "rock")
                        {
                            computerPoints++;
                            Console.WriteLine("You Lose");
                        }
                        else if (userInput == "Paper" || userInput == "paper")
                        {
                            tiePoints++;
                            Console.WriteLine("Draw");
                        }
                        else
                        {
                            userPoints++;
                            Console.WriteLine("You Win");
                        }
                        break;


                    case 3:
                        systemInput = "Scissors";
                        Console.WriteLine("Computer chose Scissors");
                        if (userInput == "Rock" || userInput == "rock")
                        {
                            userPoints++;
                            Console.WriteLine("You Win");
                        }
                        else if (userInput == "Paper" || userInput == "paper")
                        {
                            computerPoints++;
                            Console.WriteLine("You Lose");
                        }
                        else
                        {
                            tiePoints++;
                            Console.WriteLine("You Tied");
                        }
                        break;

                    default:

                        Console.WriteLine("Invalid Entry!");
                        break;
                }
                Console.WriteLine("Your Points: " + userPoints);
                Console.WriteLine("Computer Points: " + computerPoints);
                Console.WriteLine("Ties: " + tiePoints);
                Console.WriteLine("Do you want to play again?");
                q = Console.ReadLine();
                if (q == "yes" || q == "Yes" || q == "y" || q == " y")
                {
                    continue;
                }
                else if (q == "no" || q == "No" || q == "n")
                {
                    play = false;
                }
                else
                {
                    Console.WriteLine("invalid entry!");
                    play = false;
                }
            }
        }
    }
}