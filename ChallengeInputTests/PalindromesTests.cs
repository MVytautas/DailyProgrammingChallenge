using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeInputTests
{
	[TestFixture]
	public class PalindromesTests
	{
		[TestCase("Solo gigolos", true)]
		[TestCase("Sologig olos", true)]
		[TestCase("Sologig olos.", true)]
		[TestCase("", true)]
		[TestCase("\t\t  \t\t", true)]
		[TestCase("Waterloo", false)]
		[TestCase(@"Was it a car
					or a cat
					I saw?", true)]
		public void Palindrome_Success(String palindromeTestText, Boolean expectedResult)
		{
			//Arrange
			

			//Act
			var result1 = Palindromes.Program.IsPalindrome(palindromeTestText);
			//Assert
			Assert.That(result1, Is.EqualTo(expectedResult), "result1 failed");
		}

	}
}
