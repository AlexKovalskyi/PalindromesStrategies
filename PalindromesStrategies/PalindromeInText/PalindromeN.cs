using PalindromeInText.Interface;

namespace PalindromesStrategy
{ 
	public class PalindromeN : IPalindrome
    {
		public bool IsPalindrome(string verifyPalindrome)
		{ 
			for (int i = 0;i < verifyPalindrome.Length / 2;i++)
			{
				if (verifyPalindrome[i] != verifyPalindrome[verifyPalindrome.Length - i - 1])
				{
					return false;
				}
			}
			return true;
		}
	}
}
