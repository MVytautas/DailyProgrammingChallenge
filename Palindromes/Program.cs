using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b;

            Console.WriteLine("Input polindrome word");
            string myString = Console.ReadLine();
            int length = myString.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (myString[i] != myString[length - i - 1])
                     
                Console.WriteLine("It is not polindrome");
            }
            Console.WriteLine("It is  polindrome");
            Console.ReadLine();
        }
    }
}
