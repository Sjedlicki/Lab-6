using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE GRAND CIRCUS CASINO!");
            DiceGame();
        }
        public static void DiceGame()
        {
            int i = 0;            

            bool run = true;
            while (run == true)
            {
                Console.Write("Care to roll the dice? (y/n)");
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "y")
                {
                    Console.Write("Select how many sides: ");
                    string input = Console.ReadLine();
                    int.TryParse(input, out int sides);

                    Random x = new Random();
                    int rando1 = x.Next(1, sides + 1);
                    int rando2 = x.Next(1, sides + 1);

                    i = i + 1;
                    Console.WriteLine("Roll "+ (i) +": " +rando1 + "  " + rando2);
                    if (rando1 == 1 && rando2 ==1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Snake Eyes!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (rando1 == 6 && rando2 ==6)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Box Cars!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else
                {
                    Console.WriteLine("Come Again!");
                    run = false;
                }
            }   
            Console.WriteLine("Press Any Key To Exit...");
            Console.ReadKey();            
        }        
    }
}
