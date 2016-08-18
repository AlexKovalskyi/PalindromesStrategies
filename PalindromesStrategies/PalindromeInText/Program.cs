using PalindromesStrategy.Interface;
using PalindromesStrategy.Strategies;
using Strategies.Properties;
using System;
using System.IO;

namespace PalindromesStrategy
{
	class Program
	{
		static void Main(string[] args)
		{
			string fileWithPalindromes = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Palindromeqqq.txt");
			string fileWithText = Resources.LargeTXT;

			IApp palindromeTester = new PalindromeTester(fileWithText, fileWithPalindromes, new PalindromeN2());

			IPalindrome palindromeN2 = new PalindromeN2();
			PalindromeTester palindromeTesterN2 = new PalindromeTester(fileWithText, fileWithPalindromes);
			palindromeTesterN2.PalindromeStrategy = new PalindromeN3();
			palindromeTesterN2.Execute();

			Console.ReadLine();
		}
	}
}
