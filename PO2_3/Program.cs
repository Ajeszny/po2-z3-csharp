using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO2_3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Too few arguments!");
                return;
            }
            int N = Convert.ToInt32(args[0]);
            Random r = new Random();
            int rand = r.Next(N);
            bool guessed = false;
            int guess;
            while (!guessed)
            {
                Console.WriteLine("Input your guess");
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());
                } catch (FormatException e)
                {
                    Console.WriteLine("Incorrect input");
                    return;
                }
                if (guess == rand)
                {
                    Console.WriteLine("You guessed it!");
                    break;
                }
                if (guess > rand)
                {
                    Console.WriteLine("Too large!");
                    continue;
                }
                Console.WriteLine("Too small!");
            }
        }
    }
}
