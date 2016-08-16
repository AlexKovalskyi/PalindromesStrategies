using PalindromeInText.Interface;
using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace PalindromesStrategy
{
    public class PalindromeTester
    {
        private IPalindrome _palindromeStrategy;
        private string _content;
        private string _outputFile;

        public PalindromeTester(IPalindrome palindromeStrategy, string content, string outputFile)
        {
			_palindromeStrategy  = palindromeStrategy;
			_content = content;
			_outputFile = outputFile;
        }

        public void Execute()
        {
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();

			TestPalindrome(_content, _outputFile);

			stopwatch.Stop();
			Console.WriteLine("Time Elapsed: {0}", stopwatch.Elapsed);
			stopwatch.Reset();
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
						if (_palindromeStrategy.IsPalindrome(words[i].ToLower()))
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
