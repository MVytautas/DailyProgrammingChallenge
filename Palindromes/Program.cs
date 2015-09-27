using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Input polindrome word");
			string text = Console.ReadLine();

			IsPalindrome(text);

			Console.ReadLine();
		}

		public static Boolean IsPalindrome(String text)
		{
			var alpha = "abcdefghijklmnopqrstuvwxyz";
			var testText = text.Replace(" ", "").Replace("\r\n", "").Replace("\t", "").ToLower().Where(c => alpha.Contains(c)).ToList(); //  \r\n = new line and \t = tab
			int length = testText.Count;

			Boolean isPalindrome = true;

			for (int i = 0; i < length / 2; i++)
			{
				if (testText[i] != testText[length - i - 1])
				{
					Console.WriteLine("It is not polindrome");
					isPalindrome = false;
					break;
				}
			}
			if (isPalindrome)
				Console.WriteLine("It is  polindrome");

			return isPalindrome;
		}

	}
}
