using PalindromeInText.Interface;
using System;

namespace Strategies
{
	class Program
	{
		static void Main(string[] args)
		{
			string fileWithPalindromes = @"I:\Palindrome.txt";
			string fileWithText = Properties.Resources.LargeTXT;
			//IPalindrome palindromeN = new PalindromeN();
			//PalindromeTester palindromeTester = new PalindromeTester(palindromeN, fileWithText, fileWithPalindromes);
			//palindromeTester.Execute();



			//IPalindrome palindromeN2 = new PalindromeN2();
			//PalindromeTester palindromeTesterN2 = new PalindromeTester(palindromeN2, fileWithText, fileWithPalindromes);
			//palindromeTesterN2.Execute();

			IPalindrome palindromeN3 = new PalindromeN3();
			PalindromeTester palindromeTesterN3 = new PalindromeTester(palindromeN3, fileWithText, fileWithPalindromes);
			palindromeTesterN3.Execute();

			Console.ReadLine();
		}
	}
}
