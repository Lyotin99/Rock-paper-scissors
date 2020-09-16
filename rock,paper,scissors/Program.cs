using System;

namespace rock_paper_scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int counterYou = 0,counterComputer=0;
            for (int i = 0; i <= 1; i++)
            {
                Console.WriteLine("Select-rock,paper or scissors(lowercase only):");
                string yourMove = Console.ReadLine();
                Random rand = new Random();
                int compMove = rand.Next(1, 4);
                if (compMove == 1)
                {
                    Console.WriteLine("Computer:Rock");
                    if (yourMove == "rock")
                    {
                        Console.WriteLine("draw");
                    }
                    else if (yourMove == "paper")
                    {
                        Console.WriteLine("You win");
                        counterYou++;

                    }
                    else
                    {
                        Console.WriteLine("Computer wins");
                        counterComputer++;
                    }
                }
                if (compMove == 2)
                {
                    Console.WriteLine("Computer:Scissors");
                    if (yourMove == "rock")
                    {
                        Console.WriteLine("You win");
                        counterYou++;
                    }
                    else if (yourMove == "paper")
                    {
                        Console.WriteLine("Computer wins");
                        counterComputer++;

                    }
                    else Console.WriteLine("Draw");

                }
                if (compMove == 3)
                {

                    Console.WriteLine("Computer:Paper");
                    if (yourMove == "rock")
                    {
                        Console.WriteLine("Computer wins");
                        counterComputer++;
                    }
                    else if (yourMove == "paper")
                    {
                        Console.WriteLine("Draw");

                    }
                    else
                    {
                        Console.WriteLine("You win");
                        counterYou++;
                    }
                }
                Console.WriteLine("Score: You:{0}-Computer: {1}",counterYou,counterComputer);
                Console.WriteLine("Another game?-y or n");
                string rematch = Console.ReadLine();
                if (rematch == "y")
                {
                    i--;
                }
                else break;
            }
            if(counterYou>counterComputer)
            Console.WriteLine("You win the game!!!Congratulations!");
            else if(counterComputer>counterYou)
                Console.WriteLine("You lost :(.Computer wins the game!");
            else Console.WriteLine("Draw!");
        }
    }
}
