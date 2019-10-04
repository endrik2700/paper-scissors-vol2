using System;

namespace rock_paper_scissors_vol2
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            string name;
            int cpuNumber; // computer generated number

            int tries = 0;
            bool gameOver = false;
            Random rand = new Random();
            cpuNumber = rand.Next(1, 11);
            Console.WriteLine("Hello! Please eneter your name");
            name = Console.ReadLine();
            Console.WriteLine($"Hello, {name} .The game is started.");
            //Console.ReadLine();
            //notgameover true
            while (!gameOver)
            {
                Console.WriteLine("Try to guess the number:");
                int userNumber;
                userNumber = int.Parse(Console.ReadLine());

                if (userNumber > cpuNumber)
                {
                    Console.WriteLine("Your number is greater than the computer picked");
                    

                }
                else if (userNumber < cpuNumber)
                {
                    Console.WriteLine("Your number is smaller than the computer picked");
                }
                else
                {
                    Console.WriteLine("Got me! Play again? Y/N");
                    string userAnswer = Console.ReadLine();
                    //userAnswer.ToUpper();
                    //gameOver = true;
                    if (userAnswer.ToUpper() == "Y") {
                        goto Start;
                    }
                      else
                    {
                        Console.WriteLine();
                    }
                }
                Console.ReadLine();
            };


        }
    }
}
