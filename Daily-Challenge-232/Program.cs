using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyChallenge232
{
    class Program
    {
        static void Main()
        {
            string words = "";
            Console.Write("How many lines? ");
            var input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++) {
                words += string.Concat(Console.ReadLine().Where(ch => char.IsLetter(ch))).ToLower();
            }

            if (words == string.Concat(words.Reverse())) {
                Console.WriteLine("Palindrome!");
            }
            else {
                Console.WriteLine("Not a palindrome!");
            }
            
            Console.ReadKey();
        }
    }
}
