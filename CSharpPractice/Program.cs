using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a comment.
            /* This a multi-line comment. */

            Console.WriteLine("Hello World!");
            String name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);
            bool vote = false;
            char money = '$';

            if (money == '$')
            {
                vote = true;
            }

            if (vote == true)
            {
                Console.WriteLine("Vote equals true.");
            }

            // Var becomes a type at compile, but does not allow value change after that. 
            var ram = "ramMan";

            Console.WriteLine(ram);

            Console.WriteLine(ram + ", is a " + ram.GetTypeCode() + ".");

            double fivePointFive = 5.5;

            int five = (int)fivePointFive;

            // Math.Abs gets absolute value.
            // Math.Ceiling rounds up.
            // Math.Floor rounds down.
            // Math.Max sends largest from two numbers.
            // Math.Min sends the lowest of two numbers.
            // Math.Pow gives the power of a number. 
            // Math.Round rounds the number.
            // Math.Sqrt gets the square root of the number.

            Random rand = new Random();
            Console.WriteLine("Random number between 1 to 10 - " + (rand.Next(1, 11)));
        }
    }
}
