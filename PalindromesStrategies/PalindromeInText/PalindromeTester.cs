using PalindromesStrategy.Interface;
using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace PalindromesStrategy
{
	public class PalindromeTester : IApp
	{
		private string _content;
		private string _outputFile;
		
		public IPalindrome PalindromeStrategy { private get; set; }

		public PalindromeTester(string content, string outputFile) : this (content, outputFile, null)
		{
		}

		public PalindromeTester(string content, string outputFile, IPalindrome strategy)
		{
			PalindromeStrategy = strategy;
			_content = content;
			_outputFile = outputFile;
		}
		
        public void Execute()
        {
			try
			{
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();

				TestPalindrome(_content, _outputFile);

				stopwatch.Stop();
				Console.WriteLine("Time Elapsed: {0}", stopwatch.Elapsed);
			}
			catch (Exception ex)when(PalindromeStrategy == null)
			{
				Console.WriteLine("Error, please try again");
			}
			
		}

		private void TestPalindrome(string content, string destinationDir)
		{
			using (StreamWriter streamWriter = new StreamWriter(destinationDir))
			{
				content = Regex.Replace(content, "[-\\.\"?!)(,:]–", "");
				string[] words = content.Split(' ');
				for (int i = 0;i < words.Length-1;i++)
				{
					if (words[i].Length > 1)
					{
						string originalWord = string.Copy(words[i]);
						if (PalindromeStrategy.IsPalindrome(words[i].ToLower()))
						{
							Console.WriteLine("Word: {0}  - is Palindrome.", originalWord);
							streamWriter.WriteLine(originalWord);
						}
					}
				}
			}
		}
	}
}
