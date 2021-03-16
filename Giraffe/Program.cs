using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = {4, 8, 5, 15, 16, 23, 43};

            int max = luckyNumbers[0];
            int min = luckyNumbers[0];
            for (int i = 1; i < luckyNumbers.Length; i++)
            {
                if (max < luckyNumbers[i])
                {
                    max = luckyNumbers[i];
                }

                if (min > luckyNumbers[i])
                {
                    min = luckyNumbers[i];
                }
            }
            Console.WriteLine($"max: {max}");
            
            Console.WriteLine($"min: {min}");
          
            Console.ReadLine();
        }
    }
}


//string color, pluralNoun, celebrity;
//Console.Write("Enter a color: ");
//color = Console.ReadLine();

//Console.Write("Enter a plural noun:");
//pluralNoun = Console.ReadLine();

//Console.Write("Enter a celebrity:");
//celebrity = Console.ReadLine();

//Console.WriteLine($"Rosses are {color}");
//Console.WriteLine($"{pluralNoun} are blue");
//Console.WriteLine($"I Love {celebrity}");