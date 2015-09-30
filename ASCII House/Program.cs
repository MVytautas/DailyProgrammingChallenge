using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_House
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many lines will beof this symbol * ?");
            string number = Console.ReadLine();
            Console.WriteLine("You enter: {0} floors would be build", number);

            string input1 = Console.ReadLine();

            var obj1 = Input(input1);

            Console.WriteLine(Floor(obj1));

            Console.Read();
        }

        static List<string> Input(string input)
        {
            return new List<string>(input); // what can I do here?
        }

        static string Floor(List<string> lines)
        {
            var output = new List<string>();

            for (var l = 0; l < lines.Count; l++)
            {
                var line = lines[l];

                var objToStore = new objToStore[23]; // In this variable I will store already made part of floor

                for (var a = 0; a < line.Length; l++)
                {
                    var obj = line[a];

                    if (obj = '*')
                    {
                        objToStore.Append("  ");
                    }

                    // now I have to create if this * is near another * is should be objToStore.Append("  ");

                }
            }
        }

        static string Roof(List<string> input)
        {

        }
    }
}
