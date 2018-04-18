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

            // Var becomes a type at compile, but does not allow value change after that. 
            var ram = "ramMan";

            Console.WriteLine(ram);

            Console.WriteLine(ram + ", is a " + ram.GetTypeCode() + ".");
        }
    }
}
