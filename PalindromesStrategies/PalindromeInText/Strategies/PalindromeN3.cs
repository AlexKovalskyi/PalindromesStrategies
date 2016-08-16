using PalindromeInText.Interface;

namespace Strategies
{
	class PalindromeN3 : IPalindrome
	{
		public bool IsPalindrome(string VeryfiPalindrome)
		{
		int min = 0;
		int max = VeryfiPalindrome.Length - 1;
		while (true)
		{
			if (min > max)
			{
				return true;
			}
			char a = VeryfiPalindrome[min];
			char b = VeryfiPalindrome[max];
			if (char.ToLower(a) != char.ToLower(b))
				{
					return false;
				}
			min++;
			max--;
			}
		}
	}
}
