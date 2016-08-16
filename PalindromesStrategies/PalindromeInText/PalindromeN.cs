using PalindromeInText.Interface;

namespace PalindromesStrategy
{ 
	public class PalindromeN : IPalindrome
    {
		public bool IsPalindrome(string str)
		{ 
			for (int i = 0;i < str.Length / 2;i++)
			{
				if (str[i] != str[str.Length - i - 1])
				{
					return false;
				}
			}
			return true;
		}
	}
}
