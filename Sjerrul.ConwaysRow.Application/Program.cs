using Sjerrul.ConwaysRow.Generator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sjerrul.ConwaysRow.Application
{
    public static class Program
    {
        private static readonly IGenerate generator = new ConwaysRowGenerator();

        static void Main(string[] args)
        {
            Console.WriteLine("Conway's Row : Look-and-Say Sequence");
            Console.WriteLine("================================");
            Console.WriteLine("Try to guess the next number in the series!");
            Console.WriteLine("Press any key to generate the next number in the sequence, enter 'q' to quit.");

            string currentItem = AskStartingNumber();

            Console.WriteLine(String.Format("Starting with number {0}. Press Enter to view the next number in the sequence", currentItem));            
            while (true)
            {
                if (Console.ReadLine().ToLower() == "q")
                {
                    break;
                }

                string nextNumber = generator.GenerateNextItem(currentItem);
                Console.WriteLine(nextNumber);
                currentItem = nextNumber;
            }

            Console.WriteLine("Application closed.");
        }

        private static string AskStartingNumber()
        {
            string currentItem = null;

            do
            {
                Console.Write("Input a valid number to start: ");

                currentItem = Console.ReadLine();

            } while (!int.TryParse(currentItem, out int startingNumber));

            return currentItem;
        }
    }
}
