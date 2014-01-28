using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.ConwaysRow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conway's Row : Look-and-Say Sequence");
            Console.WriteLine("================================");
            Console.WriteLine("Try to guess the next number in the series!");
            Console.WriteLine("Press any key to generate the next number in the sequence, enter 'q' to quit.");
            Console.Write("Input starting number: ");
            string currentNumber = Console.ReadLine();

            Console.WriteLine(String.Format("Starting with number {0}. Press Enter to ", currentNumber));            
            while (true)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "q")
                {
                    break;
                }

                string nextNumber = GenerateNextNumber(currentNumber);
                Console.WriteLine(nextNumber);
                currentNumber = nextNumber;
            }
            Console.WriteLine("Application closed.");
        }

        private static string GenerateNextNumber(string currentNumber)
        {
            IList<String> elements = StringSplitter.Split(currentNumber);

            StringBuilder nextNumber = new StringBuilder();
            foreach (string s in elements)
            {
                char number = s[0];
                int amount = s.Length;

                nextNumber.Append(amount).Append(number);
            }

            return nextNumber.ToString();
        }


    }
}
