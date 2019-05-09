using System;
using System.Collections.Generic;

namespace Lab13RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Scissors!\n");
            Console.WriteLine("Please enter your name: ");
            Console.WriteLine();
            string input = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Hello " +input +"! ");
            Console.WriteLine(" Please select an opponent: ");
            Console.WriteLine();
            Console.WriteLine("1. Rocky");
            Console.WriteLine("2. Randy");
            Console.WriteLine("3. Robby");

            Boolean run = false;
            while (true)
            {   
                int userInput = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (userInput == 1)
                {
                    Console.WriteLine("You have selected Rocky as your opponent.\n");
                }

                if (userInput == 2)
                {
                    Console.WriteLine("You have selected Randy as your opponent.\n");
                }

                if (userInput == 3)
                {
                    Console.WriteLine("You have selected Robby as your opponent.\n");
                }
                    else
                    {
                    run = false;
                    Console.WriteLine("I'm sorry. I didn't understand your input. Please enter a number between 1 and 3.");
                    }
            }

            Random r = new Random();
            List<string> output = MakeGroup(r, 3);
            for (int i = 0; i < output.Count; i++);
            {
                Console.WriteLine(output);
            }

            List<string> MakeGroup(Random A, int groupSize)
            {
                List<string> weapons = new List<string> { "Rock", "Paper", "Scissors" };
                List<string> group = new List<string>();

                for (int i = 0; i < groupSize; i++)
                {
                    int pick = r.Next(0, weapons.Count);
                    string weaponName = weapons[pick];
                    //students.RemoveAt(pick);
                    //group.Add(studentName);
                }

                return group;
            }    
        }
    }
}
